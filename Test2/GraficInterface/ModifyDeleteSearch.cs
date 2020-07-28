using Engine;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StOrgPro.CommonMenus
{
    public partial class ModifyDeleteFormulary : Form
    {
        #region Local Variables
        DataManager dataManager = new DataManager();
        readonly Storage storage;
        private Process process;
        private DataType dataType;
        private User user;
        #endregion

        #region Create Formulary
        public ModifyDeleteFormulary(User user, Process process, DataType dataType)
        {
            this.user = user;
            this.dataType = dataType;
            this.process = process;
            WindowsSetup();
        }

        public ModifyDeleteFormulary(User user, Storage storage)
        {
            this.user = user;
            this.storage = storage;
            process = Process.Modify;
            dataType = DataType.Inventory;
            WindowsSetup();
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
                    label3.Text = "Password"; label3.Visible = true;
                    txtBox1.Visible = true;
                    if (process == Process.Modify)
                    {
                        txtBox1.Enabled = true;
                        label4.Text = "Repetir Password"; label4.Visible = true;
                        txtBox2.Enabled = true; txtBox2.Visible = true;
                    }
                    checkBoxUserPermit.Visible = true;
                    checkBoxCatalogPermit.Visible = true;
                    checkBoxStoragePermit.Visible = true;
                    checkBoxInventoryPermit.Visible = true;
                    BtnAceptar.Enabled = true; BtnAceptar.Visible = true;
                    if (process == Process.Modify)
                    {
                        txtBox1.Enabled = true;
                    }
                    if (user.GetPermit(DataType.User) && (process == Process.Modify))
                    {
                        checkBoxUserPermit.Enabled = true;
                        checkBoxCatalogPermit.Enabled = true;
                        checkBoxStoragePermit.Enabled = true;
                        checkBoxInventoryPermit.Enabled = true;
                    }
                    else if (!(process == Process.Delete))
                    {
                        CBox.Items.Add(user.UserName);
                        CBox.SelectedItem = user.UserName;
                        CBox.Enabled = false;
                        Text = "Cambiar Password";
                        dataGrid.Visible = false;
                        dataGrid.Enabled = false;
                    }
                    break;
                case DataType.Storage:
                    lblSelect.Text = lblSelect.Text + Constants.Almacen;
                    label1.Text = "Largo"; label1.Visible = true;
                    label2.Text = "Ancho"; label2.Visible = true;
                    numUpDown1.Visible = true;
                    numUpDown2.Visible = true;
                    btnInventory.Visible = true; btnInventory.Enabled = true;
                    if (!(user.GetPermit(DataType.Inventory)))
                    {
                        btnInventory.Text = "Ver Inventario";
                    }
                    if (user.GetPermit(DataType.Storage))
                    {
                        if (process == Process.Modify)
                        {
                            numUpDown1.Enabled = true;
                            numUpDown2.Enabled = true;
                        }
                        BtnAceptar.Visible = true; BtnAceptar.Enabled = true;
                    }
                    break;
                case DataType.Item:
                    lblSelect.Text = lblSelect.Text + Constants.Item;
                    label3.Text = "Marca"; label3.Visible = true;
                    txtBox1.Visible = true;
                    label4.Text = "Modelo"; label4.Visible = true;
                    txtBox2.Visible = true;
                    label5.Text = "Descripcion"; label5.Visible = true;
                    txtBox3.Visible = true;
                    if (user.GetPermit(DataType.Item))
                    {
                        if (process == Process.Modify)
                        {
                            txtBox1.Enabled = true;
                            txtBox2.Enabled = true;
                            txtBox3.Enabled = true;
                        }
                        BtnAceptar.Visible = true; BtnAceptar.Enabled = true;
                    }
                    break;
                case DataType.Inventory:
                    lblSelect.Text = lblSelect.Text + Constants.Item;
                    label1.Text = "Cantidad";
                    numUpDown1.Visible = true;
                    label3.Text = "Marca"; label3.Visible = true;
                    txtBox1.Visible = true;
                    label4.Text = "Modelo"; label4.Visible = true;
                    label5.Text = "Descripcion"; label5.Visible = true;
                    txtBox3.Visible = true;
                    if (user.GetPermit(DataType.Inventory))
                    {
                        numUpDown1.Enabled = true;
                        BtnAceptar.Enabled = true;
                        BtnAceptar.Visible = true;
                    }
                    break;
                case DataType.Search:
                    lblSelect.Text = lblSelect.Text + Constants.Item;
                    label3.Text = "Marca"; label3.Visible = true;
                    txtBox1.Visible = true;
                    label4.Text = "Modelo"; label4.Visible = true;
                    txtBox2.Visible = true;
                    label5.Text = "Descripcion"; label5.Visible = true;
                    txtBox3.Visible = true;
                    break;
            }
            if (!(process == Process.Search))
            {
                UpdateGrid();
            }
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
                case Process.See:
                    header = Constants.Ver + " ";
                    break;
                case Process.Search:
                    header = "Busqueda";
                    return header;
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
                case DataType.Search:
                    dataGrid.DataSource = dataManager.GetSearchResults(GetFromComboBox());
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
                    case DataType.User:
                        User dataUser = GetFromComboBox();
                        txtBox1.Text = dataUser.Password;
                        txtBox2.Text = dataUser.Password;
                        checkBoxCatalogPermit.Checked = dataUser.PermitCatalogManagement;
                        checkBoxInventoryPermit.Checked = dataUser.PermitInventoryManagement;
                        checkBoxStoragePermit.Checked = dataUser.PermitStoragesManagement;
                        checkBoxUserPermit.Checked = dataUser.PermitUserManagement;
                        break;
                    case DataType.Storage:
                        Storage dataStorage = GetFromComboBox();
                        numUpDown1.Value = dataStorage.Dimensions[0];
                        numUpDown2.Value = dataStorage.Dimensions[1];
                        break;
                    case DataType.Item:
                        Item dataItem = GetFromComboBox();
                        txtBox1.Text = dataItem.Brand;
                        txtBox2.Text = dataItem.Model;
                        txtBox3.Text = dataItem.Description;
                        break;
                    case DataType.Inventory:
                        dataItem = GetFromComboBox();
                        txtBox1.Text = dataItem.Brand;
                        txtBox2.Text = dataItem.Model;
                        txtBox3.Text = dataItem.Description;
                        numUpDown1.Value = dataManager.GetItemQuantity(storage, dataItem);
                        break;
                    case DataType.Search:
                        Item dataItem1 = GetFromComboBox();
                        txtBox1.Text = dataItem1.Brand;
                        txtBox2.Text = dataItem1.Model;
                        txtBox3.Text = dataItem1.Description;
                        break;
                }
            }
            else
            {
                txtBox3.Text = "";
                txtBox2.Text = "";
                txtBox1.Text = "";
                numUpDown1.Value = 0;
                numUpDown2.Value = 0;
                checkBoxCatalogPermit.Checked = false;
                checkBoxInventoryPermit.Checked = false;
                checkBoxStoragePermit.Checked = false;
                checkBoxUserPermit.Checked = false;
            }
            Update();
        }

        private void UpdateComboBox()
        {
            if(!((process == Process.Modify) && (dataType == DataType.User) && !user.GetPermit(DataType.User)))
            {
                CBox.ResetText();
                CBox.Items.Clear();
                switch (dataType)
                {
                    case DataType.User:
                        List<string> usersNames = dataManager.GetUserNames();
                        foreach (string name in usersNames)
                        {
                            CBox.Items.Add(name);
                        }
                        break;
                    case DataType.Storage:
                        List<string> storagesNames = dataManager.GetStorageName();
                        foreach (string name in storagesNames)
                        {
                            CBox.Items.Add(name);
                        }
                        break;
                    case DataType.Item:
                        List<string> itemsCodes = dataManager.GetItemCodes();
                        foreach (string code in itemsCodes)
                        {
                            CBox.Items.Add(code);
                        }
                        break;
                    case DataType.Inventory:
                        List<string> itemCodes = dataManager.GetItemCodes();
                        foreach (string code in itemCodes)
                        {
                            CBox.Items.Add(code);
                        }
                        break;
                    case DataType.Search:
                        List<string> itemCodes1 = dataManager.GetItemCodes();
                        foreach (string code in itemCodes1)
                        {
                            CBox.Items.Add(code);
                        }
                        break;
                }
            }
            Update();
        }

        private void UpdateForm()
        {
            if (CBox.SelectedItem != null)
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
                NameCode = CBox.SelectedItem.ToString();
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
                    case DataType.Search:
                        return dataManager.GetItem(NameCode);
                }
            }

            return null;
    
        }
        #endregion

        #region Events
        private void CBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (process == Process.Search)
            {
                UpdateGrid();
            }
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
                    ModifyDeleteFormulary modifyInventory = new ModifyDeleteFormulary(user, dataStorage);
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataType == DataType.Inventory)
                {
                    if (dataManager.GetItemQuantity(storage, GetFromComboBox()) == 0)
                    {
                        if (numUpDown1.Value != 0)
                        {
                            int quantity = Decimal.ToInt32(numUpDown1.Value);
                            dataManager.Insert(GetFromComboBox(), quantity, storage);
                        }
                    }
                    else
                    {
                        if (numUpDown1.Value == 0)
                        {
                            dataManager.Delete(storage, GetFromComboBox());
                        }
                        else
                        {
                            dataManager.Update(storage, GetFromComboBox(), decimal.ToInt32(numUpDown1.Value));
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
                                case DataType.User:
                                    if (txtBox1.Text == txtBox2.Text)
                                    {
                                        User newUser = GetFromComboBox();
                                        newUser.Password = txtBox1.Text;
                                        newUser.PermitUserManagement = checkBoxUserPermit.Checked;
                                        newUser.PermitCatalogManagement = checkBoxCatalogPermit.Checked;
                                        newUser.PermitStoragesManagement = checkBoxStoragePermit.Checked;
                                        newUser.PermitInventoryManagement = checkBoxInventoryPermit.Checked;
                                        dataManager.Update(newUser);
                                    }
                                    break;
                                case DataType.Storage:
                                    Storage dataStorage = GetFromComboBox();
                                    dataStorage.Dimensions[0] = decimal.ToInt32(numUpDown1.Value);
                                    dataStorage.Dimensions[1] = decimal.ToInt32(numUpDown2.Value);
                                    dataManager.Update(dataStorage);
                                    break;
                                case DataType.Item:
                                    Item dataItem = GetFromComboBox();
                                    dataItem.Brand = txtBox1.Text;
                                    dataItem.Model = txtBox2.Text;
                                    dataItem.Description = txtBox3.Text;
                                    dataManager.Update(dataItem);
                                    break;
                            }
                            break;
                        case Process.Delete:
                            dataManager.Delete(GetFromComboBox());
                            break;
                    }
                }
                if (process == Process.Modify)
                {
                    MessageBox.Show("Cambios guardados exitosamente.");
                }
                else
                {
                    MessageBox.Show("Se elimino el elemento correctamente.");
                }
            }
            catch (Exception error)
            {
                Hide();
                new Message().ShowError(error);
                Show();
            }
            CBox.ResetText();
            UpdateForm();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}