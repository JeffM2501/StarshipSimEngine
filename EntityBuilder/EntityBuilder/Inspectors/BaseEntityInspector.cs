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
    }
}
