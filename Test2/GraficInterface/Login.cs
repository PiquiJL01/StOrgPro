using System;
using Engine;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StOrgPro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Botton Events
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            User user;

            try
            {
                DataManager fileManager = new DataManager();
                user = fileManager.Login(TxtUser.Text, TxtPassword.Text);
            }
            catch (Exception error)
            {
                user = null;
                this.Hide();
                new Message().ShowError(error);
                this.Show();
                return;
            }

            Hide();
            MainMenu menu = new MainMenu(user);
            menu.ShowDialog();
            Application.Exit();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
