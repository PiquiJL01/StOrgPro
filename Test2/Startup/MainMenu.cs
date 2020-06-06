using Engine;
using System;
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
    public partial class MainMenu : Form
    {
        User user;
        public MainMenu(User _user)
        {
            user = _user;

            InitializeComponent();
            if (!user.PermitUserManagement)
            {
                BtnUser.Text = "Gestion de Usuario";
            }
            if (!user.PermitStoragesManagement)
            {
                BtnStorage.Text = "Gestion de Inventario";
            }
            if (!user.PermitItemManagement)
            {
                BtnItem.Text = "Consultar Catalogo";
            }

            Update();
        }

        #region Boton Events
        private void BtnUser_Click(object sender, EventArgs e)
        {
            Hide();
            if (user.PermitUserManagement)
            {
                CommonMenus.Manage manage = new CommonMenus.Manage(DataType.User);
                manage.ShowDialog();
            }
            else
            {
               CommonMenus.ModifyDeleteFormulary modifyDelete = new CommonMenus.ModifyDeleteFormulary(user);
                modifyDelete.ShowDialog();
            }
            Show();
        }

        private void BtnStorage_Click(object sender, EventArgs e)
        {
            Hide();
            if (user.PermitStoragesManagement)
            {
                CommonMenus.Manage manage = new CommonMenus.Manage(DataType.Storage);
                manage.ShowDialog();
            }
            else
            {
                CommonMenus.ModifyDeleteFormulary modifyDeleteFormulary = new CommonMenus.ModifyDeleteFormulary(Process.Modify, DataType.Inventory);
                modifyDeleteFormulary.ShowDialog();
            }
            Show();
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            if (user.PermitItemManagement)
            {
                Hide();
                CommonMenus.Manage manage = new CommonMenus.Manage(DataType.Item);
                manage.ShowDialog();
                Show();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
