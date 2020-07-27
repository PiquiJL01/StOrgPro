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
                BtnUser.Text = "Cambiar Password";
            }
            if (!user.PermitStoragesManagement)
            {
                BtnStorage.Text = "Ver Almacenes";
            }
            if (!user.PermitCatalogManagement)
            {
                BtnItem.Text = "Ver Catalogo";
            }

            Update();
        }

        #region Boton Events
        private void BtnUser_Click(object sender, EventArgs e)
        {
            Hide();
            if (user.GetPermit(DataType.User))
            {
                CommonMenus.Manage manage = new CommonMenus.Manage(user, DataType.User);
                manage.ShowDialog();
            }
            else
            {
               CommonMenus.ModifyDeleteFormulary modifyDelete = new CommonMenus.ModifyDeleteFormulary(user, DataType.User);
                modifyDelete.ShowDialog();
            }
            Show();
        }

        private void BtnStorage_Click(object sender, EventArgs e)
        {
            Hide();
            if (user.GetPermit(DataType.Storage))
            {
                CommonMenus.Manage manage = new CommonMenus.Manage(user, DataType.Storage);
                manage.ShowDialog();
            }
            else
            {
                CommonMenus.ModifyDeleteFormulary modifyDeleteFormulary = new CommonMenus.ModifyDeleteFormulary(Process.See, DataType.Storage);
                modifyDeleteFormulary.ShowDialog();
            }
            Show();
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            if (user.PermitCatalogManagement)
            {
                Hide();
                CommonMenus.Manage manage = new CommonMenus.Manage(user, DataType.Item);
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
