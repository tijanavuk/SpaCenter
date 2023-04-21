using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        ControllerUI ui;
        public Login()
        {
            InitializeComponent();
            ui = new ControllerUI();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //nov kod
            try
            {
                bool result = ui.ConnectToServer();
                if (result)
                {
                    ui.FindEmployee(textBoxUsername, textBoxPassword);

                }
                else
                {
                    MessageBox.Show("Failed to connect to server!");
                }
            }
            catch (Exception ex)
            {
                this.Text = ex.Message;
                return;
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    bool result = ui.ConnectToServer();
            //    if (!result)
            //    {
            //        return;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Text = ex.Message;
            //    return;
            //}
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = Color.White;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
        }
    }
}
