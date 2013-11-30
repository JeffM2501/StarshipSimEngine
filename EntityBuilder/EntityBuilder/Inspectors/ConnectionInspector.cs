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
    public partial class ConnectionInspector : BaseInspector
    {
        public Entity.InternalLocation.ConnectionInfo TheConnection = null;

        public ConnectionInspector()
        {
            InitializeComponent();
        }

        public override void Set(object item)
        {
            TheConnection = item as Entity.InternalLocation.ConnectionInfo;
        }
    }
}
