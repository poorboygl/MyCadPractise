using System;
using System.Windows.Forms;
using System.Collections;

namespace Core
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void StartUpForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowItems_Click(object sender, EventArgs e)
        {
            string choice = "";
            choice =  cbbOptions.SelectedItem.ToString();
            MyCommands lispCad = new MyCommands();
            if (choice == "Layer")
            {
               /* ArrayList layers = lispCad.GetLay*/
            }    

        }
    }
}
