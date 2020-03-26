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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the  form
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            //TODO add btn click to send to category
            CategoryUserControl cg = new CategoryUserControl();
            MainControlClass.showControl(cg , contentPanel);
        }
    }
}
