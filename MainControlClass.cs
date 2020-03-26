using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructuresFinal
{
    class MainControlClass
    {
        public static void showControl(System.Windows.Forms.Control control, System.Windows.Forms.Control content)
        {
            content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            content.BringToFront();
            control.Focus();

            content.Controls.Add(control);
        }
    }
}
