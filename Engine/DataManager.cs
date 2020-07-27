using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections;
using System.ComponentModel;
using Engine.Logic;

namespace Engine
{
    public class DataManager
    {
        private SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
            "AttachDbFilename=C:\\Users\\inmun\\source\\repos\\Test2\\StOrgPro\\Engine\\DataBase.mdf;" +
            "Integrated Security=True");

        public User Login(string name, string password)
        {
            User user = GetUser(name);
            if (user.Password == password)
            {
                return user;
            }
            else
            {
                throw new FailedLogin();
            }
        }

        #region Insertar
        public void Insert(User user)
        {
            try
            {
                string query = "Insert INTO Users (Nombre, Password, PermisoUsuario, Permisoitems, PermisoInventario, PermisoAlmacen)" +
                    "Values (@nombre, @password, @permisoUsuario, @permisoItems, @permisoInventario, @permisoAlmacen)";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", user.UserName);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@permisoUsuario", user.IntPermitUserMang());
                command.Parameters.AddWithValue("@permisoitems", user.IntPermitCatalogMang());
                command.Parameters.AddWithValue("@permisoInventario", user.IntPermitInventoryMng());
                command.Parameters.AddWithValue("@permisoAlmacen", user.IntPermitStorageMng());
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                throw new AlreadyExists();
            }
        }

        public void Insert(Storage storage)
        {
            try
            {
                string query = "INSERT INTO Almacenes (Nombre, Largo, Ancho) " +
                    "VALUES (@nombre, @largo, @ancho)";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", storage.Name);
                command.Parameters.AddWithValue("@largo", storage.Dimensions[0]);
                command.Parameters.AddWithValue("@ancho", storage.Dimensions[1]);
                command.ExecuteNonQuery();
                connection.Close();
                CreateInventory(storage);
            }
            catch (Exception)
            {
                connection.Close();
                throw new AlreadyExists();
            }
        }

        private void CreateInventory(Storage storage)
        {
            try
            {
                string query = "CREATE TABLE " + storage.InventoryName() + " " +
                    "(Codigo VARCHAR(50) NOT NULL PRIMARY KEY, " +
                    "Descripcion VARCHAR(MAX) NOT NULL, " +
                    "Marca VARCHAR(50)  NOT NULL, " +
                    "Modelo VARCHAR(50)  NOT NULL, " +
                    "Cantidad INT NOT NULL)";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@inventory", storage.InventoryName());
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                throw new InventoryCreation();
            }
        }

        public void Insert(Item item)
        {
            try
            {
                string query = "INSERT INTO Items (Codigo, Descripcion, Marca, Modelo) " +
                    "Values (@codigo, @descripcion, @marca, @modelo)";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigo", item.Code);
                command.Parameters.AddWithValue("@descripcion", item.Description);
                command.Parameters.AddWithValue("@marca", item.Brand);
                command.Parameters.AddWithValue("@modelo", item.Model);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                throw new AlreadyExists();
            }
        }

        public void Insert(Item item, int quantity, Storage storage)
        {
            try
            {
                string query = "INSERT INTO " + storage.InventoryName() +" (Codigo, Descripcion, Marca, Modelo, Cantidad) " +
                    "Values (@codigo, @descripcion, @marca, @modelo, @cantidad)";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigo", item.Code);
                command.Parameters.AddWithValue("@descripcion", item.Description);
                command.Parameters.AddWithValue("@marca", item.Brand);
                command.Parameters.AddWithValue("@modelo", item.Model);
                command.Parameters.AddWithValue("@cantidad", quantity);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                throw new AlreadyExists();
            }
        }
        #endregion

        #region Update
        public void Update(User user)
        {
            try
            {
                string query = "UPDATE Users " +
                    "SET Password = @password, PermisoUsuario = @permisoUsuario " +
                    "Permisoitems = @permisoItems, PermisoInventario = @permisoInventario, " +
                    "PermisoAlmacen = @permisoAlmacen " +
                    "WHERE Nombre = @nombre";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", user.UserName);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@permisoUsuario", user.IntPermitUserMang());
                command.Parameters.AddWithValue("@permisoItems", user.IntPermitCatalogMang());
                command.Parameters.AddWithValue("@permisoInventario", user.IntPermitInventoryMng());
                command.Parameters.AddWithValue("@permisoAlmacen", user.IntPermitStorageMng());
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                throw new DoesNotExist();
            }
        }

        public void Update(Storage storage)
        {
            try
            {
                string query = "UPDATE Almacenes " +
                    "SET Largo = @largo, Ancho = @ancho " +
                    "WHERE Nombre = @nombre";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", storage.Name);
                command.Parameters.AddWithValue("@largo", storage.Dimensions[0]);
                command.Parameters.AddWithValue("@ancho", storage.Dimensions[1]);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                throw new DoesNotExist();
            }
        }

        public void Update(Item item)
        {
            try
            {
                string query = "UPDATE Items " +
                    "SET Descripcion = @descripcion, Marca = @marca, Modelo = @modelo " +
                    "WHERE Codigo = @Codigo";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigo", item.Code);
                command.Parameters.AddWithValue("@descripcion", item.Description);
                command.Parameters.AddWithValue("@marca", item.Brand);
                command.Parameters.AddWithValue("@modelo", item.Model);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                throw new DoesNotExist();
            }
        }

        public void Update(Storage storage, Item item, int quantity)
        {
            try
            {
                string query = "UPDATE " + storage.InventoryName() +  " " +
                    "SET Cantidad = @cantidad " +
                    "WHERE Codigo = @codigo";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigo", item.Code);
                command.Parameters.AddWithValue("@cantidad", quantity);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                throw new DoesNotExist();
            }
        }
        #endregion

        #region Delete
        public void Delete(User user)
        {
            try
            {
                string query = "DELETE FROM Users " +
                "WHERE Nombre = @nombre";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", user.UserName);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                throw new DoesNotExist();
            }
        }

        public void Delete(Storage storage)
        {
            try
            {
                string query = "DELETE FROM Almacenes " +
                    "WHERE Nombre = @nombre";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", storage.Name);
                command.ExecuteNonQuery();
                connection.Close();
                DeleteInventory(storage);
            }
            catch (Exception)
            {
                connection.Close();
                throw new DoesNotExist();
            }
        }

        public void DeleteInventory(Storage storage)
        {
            try
            {
                string query = "DROP TABLE " + storage.InventoryName();
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                throw new InventoryCreation();
            }
        }

        public void Delete(Item item)
        {
            try
            {
                string query = "DELETE FROM Items " +
                    "WHERE Codigo = @codigo";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigo", item.Code);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                throw new DoesNotExist();
            }
        }

        public void Delete(Storage storage, Item item)
        {
            try
            {
                string query = "DELETE FROM " + storage.InventoryName() + " " +
                    "WHERE Codigo = @codigo";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigo", item.Code);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
                throw new DoesNotExist();
            }
        }
        #endregion

        #region Getters Objects
        public User GetUser(string name)
        {
            string query = "SELECT * from Users WHERE Nombre = @nombre";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nombre", name);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                User user = new User(dataReader["Nombre"].ToString(), dataReader["Password"].ToString(),
                    Convert.ToInt32(dataReader["PermisoUsuario"].ToString()),
                    Convert.ToInt32(dataReader["Permisoitems"].ToString()),
                    Convert.ToInt32(dataReader["PermisoInventario"].ToString()),
                    Convert.ToInt32(dataReader["PermisoAlmacen"].ToString()));
                connection.Close();
                return user;
            }

            connection.Close();
            throw new Exception();
        }

        public Storage GetStorage(string name)
        {
            string query = "SELECT * from Almacenes WHERE Nombre = @nombre";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nombre", name);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                Storage storage = new Storage(dataReader["Nombre"].ToString(),
                    int.Parse(dataReader["Largo"].ToString()),
                    int.Parse(dataReader["Ancho"].ToString()));
                connection.Close();
                return storage;
            }

            connection.Close();
            return null;
        }

        public Item GetItem(string code)
        {
            string query = "SELECT * from Items WHERE Codigo = @codigo";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@codigo", code);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                Item item = new Item(dataReader["Codigo"].ToString(),
                    dataReader["Descripcion"].ToString(),
                    dataReader["Marca"].ToString(),
                    dataReader["Modelo"].ToString());
                connection.Close();
                return item;
            }

            connection.Close();
            return null;
        }

        public int GetItemQuantity(Storage storage, Item item)
        {
            string query = "SELECT * from " + storage.InventoryName() + " " +
                "WHERE Codigo = @codigo";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@codigo", item.Code);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                int quantity = int.Parse(dataReader["Cantidad"].ToString());
                connection.Close();
                return quantity;
            }

            connection.Close();
            return 0;
        }
        #endregion

        #region Getters Objects Collections
        public DataTable GetUsers()
        {
            string query = "Select * from Users";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable GetStorages()
        {
            string query = "Select * from Almacenes";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public DataTable GetItems()
        {
            string query = "Select * from Items";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public DataTable GetInventory(Storage storage)
        {
            string query = "Select * from " + storage.InventoryName();
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public DataTable GetSearchResults(Item item)
        {
            List<string> storagesNames = GetStorageName();
            List<Storage> storages = new List<Storage>();
            IList<SearchResult> results = new List<SearchResult>();
            foreach (string name in storagesNames)
            {
                storages.Add(GetStorage(name));
            }
            foreach (Storage storage in storages)
            {
                results.Add(new SearchResult(storage.Name, GetItemQuantity(storage, item)));
            }

            return ToDataTable(results);
        }
        #endregion

        #region Getters Objects IDs
        public List<string> GetUserNames()
        {
            List<string> Names = new List<string>();
            string query = "SELECT Nombre FROM Users";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader sqlData = command.ExecuteReader();
            while (sqlData.Read())
            {
                Names.Add(sqlData["Nombre"].ToString());
            }
            connection.Close();
            return Names;
        }

        public List<string> GetItemCodes(Storage storage = null)
        {
            List<string> Codes = new List<string>();
            string query;
            if (storage == null)
            {
                query = "SELECT Codigo FROM Items";
            }
            else
            {
                query = "SELECT Codigo From " + storage.InventoryName();
            }
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader sqlData = command.ExecuteReader();
            while (sqlData.Read())
            {
                Codes.Add(sqlData["Codigo"].ToString());
            }
            connection.Close();
            return Codes;
        }

        public List<string> GetStorageName()
        {
            List<string> Names = new List<string>();
            string query= "SELECT Nombre FROM Almacenes";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader sqlData = command.ExecuteReader();
            while (sqlData.Read())
            {
                Names.Add(sqlData["Nombre"].ToString());
            }
            connection.Close();
            return Names;
        }
        #endregion

        private static DataTable ToDataTable(IList<SearchResult> list)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SearchResult));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (SearchResult item in list)
            {
                for (int i = 0; i < values.Length; i++)
                    values[i] = props[i].GetValue(item) ?? DBNull.Value;
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
