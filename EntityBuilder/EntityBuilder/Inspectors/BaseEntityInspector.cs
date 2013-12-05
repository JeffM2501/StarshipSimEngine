using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SimCore.Entities;

namespace EntityBuilder.Inspectors
{
    public partial class BaseEntityInspector : BaseInspector
    {
        public BaseEntityInspector()
            : base()
        {
            InitializeComponent();
        }

        public override string GetItemName() { return TheEntity.Name; }

        public override void Set(object item, Entity ent)
        {
            base.Set(item, ent);

            if (TheEntity.ParrentID == UInt64.MaxValue)
                ParrentID.Value = -1;
            else
                ParrentID.Value = TheEntity.ParrentID;
            Radius.Value = (decimal)TheEntity.Radius;
        }

        private void ParrentID_ValueChanged(object sender, EventArgs e)
        {
            if (ParrentID.Value == -1 && TheEntity.ParrentID == UInt64.MaxValue)
                return;

            if (TheEntity.ParrentID == (UInt64)ParrentID.Value)
                return;

            if (ParrentID.Value == -1)
                TheEntity.ParrentID = UInt64.MaxValue;
            else
                TheEntity.ParrentID = (UInt64)ParrentID.Value;
            CallInfoChanged(TheEntity);
        }

        private void Radius_ValueChanged(object sender, EventArgs e)
        {
            if (TheEntity.Radius == (double)Radius.Value)
                return;

            TheEntity.Radius = (double)Radius.Value;
            CallInfoChanged(TheEntity);
        }
    }
}
