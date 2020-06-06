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
    public partial class ModifyDeleteFormulary : Form
    {
        #region Local Variables
        DataManager dataManager = new DataManager();
        readonly Storage storage;
        private readonly Process process;
        private readonly DataType dataType;
        private readonly User user;
        #endregion

        #region Create Formulary
        public ModifyDeleteFormulary(Process process, DataType dataType)
        {
            this.dataType = dataType;
            this.process = process;
            WindowsSetup();
        }

        public ModifyDeleteFormulary(Storage storage)
        {
            this.storage = storage;
            process = Process.Modify;
            dataType = DataType.Inventory;
            WindowsSetup();
        }

        public ModifyDeleteFormulary(User user)
        {
            this.user = user;
            process = Process.Modify;
            dataType = DataType.User;
        }
        #endregion
        private void WindowsSetup()
        {
            InitializeComponent();
            Text = Header();
            UpdateComboBox();
            switch (dataType)
            {
                case DataType.User:
                    lblSelect.Text = lblSelect.Text + Constants.Usuario;
                    lblQuantityLength.Enabled = false; lblQuantityLength.Visible = false;
                    numQuantityLength.Enabled = false; numQuantityLength.Visible = false;
                    lblWidth.Enabled = false; lblWidth.Visible = false;
                    numWidth.Enabled = false; numWidth.Visible = false;
                    lblPasswordBrand.Text = "Contraseña";
                    lblModel.Enabled = false; lblModel.Visible = false;
                    TxtModel.Enabled = false; TxtModel.Visible = false;
                    lblDescription.Enabled = false; lblDescription.Visible = false;
                    TxtDescription.Enabled = false; TxtDescription.Visible = false;
                    btnInventory.Enabled = false; btnInventory.Visible = false;
                    break;
                case DataType.Storage:
                    lblSelect.Text = lblSelect.Text + Constants.Almacen;
                    lblQuantityLength.Text = "Largo";
                    lblPasswordBrand.Visible = false; lblPasswordBrand.Enabled = false;
                    TxtPasswordBrand.Visible = false; TxtPasswordBrand.Enabled = false;
                    lblModel.Enabled = false; lblModel.Visible = false;
                    TxtModel.Enabled = false; TxtModel.Visible = false;
                    lblDescription.Enabled = false; lblDescription.Visible = false;
                    TxtDescription.Enabled = false; TxtDescription.Visible = false;
                    break;
                case DataType.Item:
                    lblSelect.Text = lblSelect.Text + Constants.Item;
                    lblQuantityLength.Visible = false; lblQuantityLength.Enabled = false;
                    numQuantityLength.Enabled = false; numQuantityLength.Visible = false;
                    lblWidth.Visible = false; lblWidth.Enabled = false;
                    numWidth.Visible = false; numWidth.Enabled = false;
                    lblPasswordBrand.Text = "Marca";
                    btnInventory.Visible = false; btnInventory.Enabled = false;
                    break;
                case DataType.Inventory:
                    lblSelect.Text = lblSelect.Text + Constants.Item;
                    lblQuantityLength.Text = "Cantidad";
                    lblWidth.Visible = false; lblWidth.Enabled = false;
                    numWidth.Visible = false; numWidth.Enabled = false;
                    lblPasswordBrand.Text = "Marca";
                    TxtPasswordBrand.Enabled = false;
                    TxtDescription.Enabled = false;
                    TxtModel.Enabled = false;
                    btnInventory.Visible = false; btnInventory.Enabled = false;
                    break;
            }
            switch (process)
            {
                case Process.Modify:
                    BtnDeleteModify.Text = Constants.Modificar;
                    break;
                case Process.Delete:
                    TxtDescription.Enabled = false;
                    TxtModel.Enabled = false;
                    TxtPasswordBrand.Enabled = false;
                    numQuantityLength.Enabled = false;
                    numWidth.Enabled = false;
                    BtnDeleteModify.Text = Constants.Eliminar;
                    break;
            }
            UpdateGrid();
            Update();
        }

        #region Aditional Methods
        private string Header()
        {
            string header;
            switch (process)
            {
                case Process.Modify:
                    header = Constants.Modificar + " ";
                    break;
                case Process.Delete:
                    header = Constants.Eliminar + " ";
                    break;
                default:
                    header = "";
                    break;
            }

            switch (dataType)
            {
                case DataType.User:
                    header = header + Constants.Usuario + "s";
                    break;
                case DataType.Storage:
                    header = header + Constants.Almacen + "s";
                    break;
                case DataType.Item:
                    header = header + Constants.Item + "s";
                    break;
                case DataType.Inventory:
                    header = header + Constants.Inventario + " de " + storage.Name;
                    break;
                default:
                    break;
            }

            return header;
        }

        private void UpdateGrid()
        {
            switch (dataType)
            {
                case DataType.User:
                    dataGrid.DataSource = dataManager.GetUsers();
                    break;
                case DataType.Storage:
                    dataGrid.DataSource = dataManager.GetStorages();
                    break;
                case DataType.Item:
                    dataGrid.DataSource = dataManager.GetItems();
                    break;
                case DataType.Inventory:
                    dataGrid.DataSource = dataManager.GetInventory(storage);
                    break;
                default:
                    break;
            }

            Update();
        }
        
        private void UpdateFormulary()
        {
            if (GetFromComboBox() != null)
            {
                switch (dataType)
                {
                    case DataType.Storage:
                        Storage dataStorage = GetFromComboBox();
                        numQuantityLength.Value = dataStorage.Dimensions[0];
                        numWidth.Value = dataStorage.Dimensions[1];
                        break;
                    case DataType.Item:
                        Item dataItem = GetFromComboBox();
                        TxtPasswordBrand.Text = dataItem.Brand;
                        TxtModel.Text = dataItem.Model;
                        TxtDescription.Text = dataItem.Description;
                        break;
                    case DataType.Inventory:
                        dataItem = GetFromComboBox();
                        TxtPasswordBrand.Text = dataItem.Brand;
                        TxtModel.Text = dataItem.Model;
                        TxtDescription.Text = dataItem.Description;
                        try
                        {
                            numQuantityLength.Value = dataManager.GetItemQuantity(storage, dataItem);
                        }
                        catch (Exception)
                        {

                        }
                        break;
                }
            }
            else
            {
                TxtDescription.Text = "";
                TxtModel.Text = "";
                TxtPasswordBrand.Text = "";
                numQuantityLength.Value = 0;
                numWidth.Value = 0;
            }
            Update();
        }

        private void UpdateComboBox()
        {
            CBoxSelect.Items.Clear();
            switch (dataType)
            {
                case DataType.User:
                    List<string> usersNames = dataManager.GetUsersName();
                    foreach (string name in usersNames)
                    {
                        CBoxSelect.Items.Add(name);
                    }
                    break;
                case DataType.Storage:
                    List<string> storagesNames = dataManager.GetStorageName();
                    foreach (string name in storagesNames)
                    {
                        CBoxSelect.Items.Add(name);
                    }
                    break;
                case DataType.Item:
                    List<string> itemsCodes = dataManager.GetItemCodes();
                    foreach (string code in itemsCodes)
                    {
                        CBoxSelect.Items.Add(code);
                    }
                    break;
                case DataType.Inventory:
                    List<string> itemCodes = dataManager.GetItemCodes();
                    foreach (string code in itemCodes)
                    {
                        CBoxSelect.Items.Add(code);
                    }
                    break;
            }
            Update();
        }

        private void UpdateForm()
        {
            if (CBoxSelect.SelectedItem != null)
            {
                UpdateComboBox();
                UpdateFormulary();
            }
            UpdateGrid();
            Update();
        }

        private dynamic GetFromComboBox()
        {
            string NameCode;
            try
            {
                NameCode = CBoxSelect.SelectedItem.ToString();
            }
            catch (Exception)
            {
                NameCode = "";
            }

            if (NameCode != "")
            {
                switch (dataType)
                {
                    case DataType.User:
                        return dataManager.GetUser(NameCode);
                    case DataType.Storage:
                        return dataManager.GetStorage(NameCode);
                    case DataType.Item:
                        return dataManager.GetItem(NameCode);
                    case DataType.Inventory:
                        return dataManager.GetItem(NameCode);
                }
            }

            return null;
    
        }
        #endregion

        #region Events
        private void CBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFormulary();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (dataType == DataType.Storage)
            {
                try
                {
                    Storage dataStorage = GetFromComboBox();
                    Hide();
                    ModifyDeleteFormulary modifyInventory = new ModifyDeleteFormulary(dataStorage);
                    modifyInventory.ShowDialog();
                    Show();
                }
                catch (Exception)
                {
                    Hide();
                    MessageBox.Show("Almacen no valido");
                    Show();
                }
            }

            UpdateForm();
        }

        private void BtnDeleteModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataType == DataType.Inventory)
                {
                    if (dataManager.GetItemQuantity(storage, GetFromComboBox()) == 0)
                    {
                        if (numQuantityLength.Value != 0)
                        {
                            dataManager.Insert(GetFromComboBox(), decimal.ToInt32(numQuantityLength.Value), storage);
                        }
                    }
                    else
                    {
                        if (numQuantityLength.Value == 0)
                        {
                            dataManager.Delete(storage, GetFromComboBox());
                        }
                        else
                        {
                            dataManager.Update(storage, GetFromComboBox(), decimal.ToInt32(numQuantityLength.Value));
                        }
                    }
                }
                else
                {
                    switch (process)
                    {
                        case Process.Modify:
                            switch (dataType)
                            {
                                case DataType.Storage:
                                    Storage dataStorage = GetFromComboBox();
                                    dataStorage.Dimensions[0] = decimal.ToInt32(numQuantityLength.Value);
                                    dataStorage.Dimensions[1] = decimal.ToInt32(numWidth.Value);
                                    dataManager.Update(dataStorage);
                                    break;
                                case DataType.Item:
                                    Item dataItem = GetFromComboBox();
                                    dataItem.Brand = TxtPasswordBrand.Text;
                                    dataItem.Model = TxtModel.Text;
                                    dataItem.Description = TxtDescription.Text;
                                    dataManager.Update(dataItem);
                                    break;
                            }
                            break;
                        case Process.Delete:
                            dataManager.Delete(GetFromComboBox());
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Hide();
                MessageBox.Show("Transaccion fallida");
                Show();
            }
            UpdateForm();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}