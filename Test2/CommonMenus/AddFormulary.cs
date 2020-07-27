using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StOrgPro.CommonMenus
{
    public partial class AddFormulary : Form
    {
        private DataType dataType;

        #region Windows Initialization
        public AddFormulary(User user, DataType dataType)
        {
            if (user.GetPermit(dataType))
            {
                this.dataType = dataType;
                InitializeComponent();
                SetWindow();
                Update();
            }
            else
            {
                new Message().ShowError(new NoPermit());
                Close();
            }
        }

        private void SetWindow()
        {
            switch (dataType)
            {
                case DataType.User:
                    Text = Text + Constants.Usuario;
                    label1.Text = Constants.Nombre;
                    label2.Text = Constants.Password;
                    label3.Text = Constants.RepeatPAssword;
                    label4.Visible = false;
                    textBox4.Visible = false;
                    textBox4.Enabled = false;
                    checkBoxCatalogPermit.Enabled = true;
                    checkBoxCatalogPermit.Visible = true;
                    checkBoxInventoryPermit.Enabled = true;
                    checkBoxInventoryPermit.Visible = true;
                    checkBoxStoragePermit.Enabled = true;
                    checkBoxStoragePermit.Visible = true;
                    checkBoxUserPermit.Enabled = true;
                    checkBoxUserPermit.Visible = true;
                    break;
                case DataType.Storage:
                    Text = Text + Constants.Almacen;
                    label1.Text = Constants.Nombre;
                    textBox2.Enabled = false;
                    textBox2.Visible = false;
                    numericUpDown1.Visible = true;
                    numericUpDown1.Enabled = true;
                    label2.Text = Constants.Largo;
                    textBox3.Visible = false;
                    textBox3.Enabled = false;
                    label3.Text = Constants.Ancho;
                    textBox3.Visible = false;
                    textBox3.Enabled = false;
                    numericUpDown2.Enabled = true;
                    numericUpDown2.Visible = true;
                    label4.Visible = false;
                    textBox4.Enabled = false;
                    textBox4.Visible = false;
                    break;
                case DataType.Item:
                    Text = Text + Constants.Item;
                    label1.Text = Constants.Codigo;
                    label2.Text = Constants.Marca;
                    label3.Text = Constants.Modelo;
                    label4.Text = Constants.Descripcion;
                    break;
                default:
                    throw new Exception();
            }
        }
        #endregion


        #region Events
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    throw new InvalidInput();
                }
               switch (dataType)
                {
                    case DataType.User:
                        if (textBox2.Text == "")
                        {
                            throw new InvalidInput();
                        }
                        if (!(textBox2.Text == textBox3.Text))
                        {
                            throw new InvalidInput();
                        }
                        User newUser = new User(textBox1.Text, textBox2.Text,
                            checkBoxUserPermit.Checked, checkBoxCatalogPermit.Checked,
                            checkBoxInventoryPermit.Checked, checkBoxStoragePermit.Checked);
                        DataManager dataManager = new DataManager();
                        dataManager.Insert(newUser);
                        MessageBox.Show("Usuario creado exitosamente");
                        Close();
                        break;
                    case DataType.Storage:
                        Storage storage = new Storage(textBox1.Text, Decimal.ToInt32(numericUpDown1.Value), Decimal.ToInt32(numericUpDown2.Value));
                        DataManager dataManager1 = new DataManager();
                        dataManager1.Insert(storage);
                        MessageBox.Show("Almacen creado exitosamente.");
                        Close();
                        break;
                    case DataType.Item:
                        Item item = new Item(textBox1.Text, textBox4.Text, textBox2.Text, textBox3.Text);
                        DataManager dataManager2 = new DataManager();
                        dataManager2.Insert(item);
                        MessageBox.Show("Item creado exitosamente");
                        Close();
                        break;
                    default:
                        throw new WrongDataType();
                }
            }
            catch (Exception error)
            {
                Message message = new Message();
                message.ShowError(error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
