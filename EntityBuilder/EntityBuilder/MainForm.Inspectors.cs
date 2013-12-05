using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SimCore.Entities;
using SimCore.Data.Systems;

using EntityBuilder.Inspectors;
using EntityBuilder.Inspectors.Entities;
using EntityBuilder.Inspectors.Systems;

namespace EntityBuilder
{
    partial class MainForm
    {
        protected Dictionary<Type, Type> InspectorMap = new Dictionary<Type, Type>();

        protected void InitInspectors()
        {
            InspectorMap.Add(typeof(Entity.InternalLocation), typeof(LocationInspector));
            InspectorMap.Add(typeof(Entity.InternalLocation.ConnectionInfo), typeof(ConnectionInspector));

            InspectorMap.Add(typeof(Entity), typeof(BaseEntityInspector));
            InspectorMap.Add(typeof(StarShip), typeof(ShipEntityInspector));

            InspectorMap.Add(typeof(BaseSystem), typeof(BaseSystemInspector));
            InspectorMap.Add(typeof(ComputerSystem), typeof(ComputerInspector));
            InspectorMap.Add(typeof(GenerationSystem), typeof(GeneratorInspector));
            InspectorMap.Add(typeof(FluidTankSystem), typeof(FluidTankInspector));
        }

        public void LoadInspector(object item)
        {
            InspectorArea.Controls.Clear();

            if (item == null)
                return;

            BaseInspector inspector = null;

            if (InspectorMap.ContainsKey(item.GetType()))
                inspector = (BaseInspector)Activator.CreateInstance(InspectorMap[item.GetType()]);
            else if (item as BaseSystem != null)
                inspector = (BaseInspector)Activator.CreateInstance(InspectorMap[typeof(BaseSystem)]);
            else
            {
                if (item == TheEntity)
                    inspector = new BaseEntityInspector();
                else
                {
                    inspector = new LocationInspector();
                    item = GetSelectedLocation();
                }
            }

            if (inspector == null)
                return;

            inspector.Set(item,TheEntity);
            InspectorArea.Controls.Add(inspector);
            inspector.NameChanged += new EventHandler(inspector_NameChanged);
            inspector.InfoChanged += new EventHandler(inspector_GeometryChanged);
            inspector.Show();
        }

        void inspector_GeometryChanged(object sender, EventArgs e)
        {
            Dirty();
        }

        void inspector_NameChanged(object sender, EventArgs e)
        {
            BaseInspector inspector = sender as BaseInspector;
            if (inspector == null)
                return;
            if (ComponentsList.SelectedNode != null)
                ComponentsList.SelectedNode.Text = inspector.GetItemName();
            Dirty();
        }
    }
}
