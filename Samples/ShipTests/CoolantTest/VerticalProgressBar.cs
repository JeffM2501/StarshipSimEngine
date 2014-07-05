using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoolantTest
{
    public partial class VerticalProgressBar : ProgressBar
    {
        public VerticalProgressBar()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams p = base.CreateParams;
                p.Style = p.Style | 0x00000004;
                return p;
            }
        }
    }
}
