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

namespace StOrgPro.CommonMenus
{
    public partial class Manage : Form
    {
        private DataType dataType;
        private User user;

        public Manage(User user, DataType dataType)
        {
            this.user = user;
            this.dataType = dataType;
            string type;
            switch (dataType)
            {
                case DataType.User:
                    type = Constants.Usuario;
                    break;
                case DataType.Storage:
                    type = Constants.Almacen;
                    break;
                case DataType.Item:
                    type = Constants.Item;
                    break;
                default:
                    throw new Exception();
            }
            InitializeComponent();
            this.Text = this.Text + type + "s";
            BtnAdd.Text = BtnAdd.Text + type;
            BtnModify.Text = BtnModify.Text + type;
            BtnDelete.Text = BtnDelete.Text + type;
            Update();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Hide();
            AddFormulary addformulary = new AddFormulary(user, dataType);
            addformulary.ShowDialog();
            Show();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            Hide();
            ModifyDeleteFormulary modifyDeleteFormulary = new ModifyDeleteFormulary(user, Process.Modify, dataType);
            modifyDeleteFormulary.ShowDialog();
            Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Hide();
            ModifyDeleteFormulary modifyDeleteFormulary = new ModifyDeleteFormulary(user, Process.Delete, dataType);
            modifyDeleteFormulary.ShowDialog();
            Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
