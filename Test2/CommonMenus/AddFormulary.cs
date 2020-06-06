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

        public AddFormulary(DataType dataType)
        {
            this.dataType = dataType;
            InitializeComponent();
            SetWindow();
            Update();
        }

        private void SetWindow()
        {
            switch (dataType)
            {
                case DataType.User:
                    Text = Text + Constants.Usuario;
                    label1.Text = Constants.Nombre;
                    break;
                case DataType.Storage:
                    Text = Text + Constants.Almacen;
                    label1.Text = Constants.Nombre;
                    label2.Text = Constants.Largo;
                    label3.Text = Constants.Ancho;
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

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            try
            {
               switch (dataType)
                {
                    case DataType.User:
                        break;
                    case DataType.Storage:
                        Storage storage = new Storage(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                        DataManager dataManager1 = new DataManager();
                        dataManager1.Insert(storage);
                        MessageBox.Show("Almacen creado exitosamente.");
                        Close();
                        break;
                    case DataType.Item:
                        Item item = new Item(textBox1.Text, textBox4.Text, textBox2.Text, textBox3.Text);
                        DataManager dataManager = new DataManager();
                        dataManager.Insert(item);
                        MessageBox.Show("Item creado exitosamente");
                        Close();
                        break;
                    default:
                        throw new Exception();
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
    }
}
