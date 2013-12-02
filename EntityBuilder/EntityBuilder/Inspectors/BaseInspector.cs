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
    public partial class BaseInspector : UserControl
    {
        public event EventHandler NameChanged;
        public event EventHandler InfoChanged;

        protected Entity TheEntity = null;

        public BaseInspector()
        {
            InitializeComponent();
        }

        public virtual void Set(object item, Entity ent)
        {
            TheEntity = ent;
        }

        public virtual string GetItemName() { return string.Empty; }

        public virtual void CallNameChanged( object sender)
        {
            if (NameChanged != null)
                NameChanged(sender, EventArgs.Empty);
        }

        public virtual void CallInfoChanged(object sender)
        {
            if (InfoChanged != null)
                InfoChanged(sender, EventArgs.Empty);
        }
    }
}
