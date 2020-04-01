using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace DataStructuresFinal
{
    public partial class MainPanelForm : Form
    {
       
        public MainPanelForm()
        {
            InitializeComponent();
        }
        private void MainPanelForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            CategoryUserControl ca = new CategoryUserControl();
            MainControlClass.showControl(ca, contentPanel);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Exits the form
        }
    }
}
