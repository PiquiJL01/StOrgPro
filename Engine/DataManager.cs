using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Engine
{
    public class DataManager
    {
        private SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
            "AttachDbFilename=C:\\Users\\inmun\\source\\repos\\Test2\\StOrgPro\\Engine\\DataBase.mdf;" +
            "Integrated Security=True");

        public User Login(string name, string password)
        {
            string Domain = System.Reflection.Assembly.GetEntryAssembly().Location;
            connection.Open();
            User user;
            if (name == "admin")
            {
                user = new User(name, "admin", true, true, true, true, true);
                user.ValidatePassword(password);
            }
            else if (name == "super")
            {
                user = new User(name, "super", false, true, false, true, true);
                user.ValidatePassword("super");
            }
            else if (name == "manager")
            {
                user = new User(name, "manager", false, false, true, true, false);
                user.ValidatePassword("manager");
                user.PermitUserManagement = false;
                user.PermitStoragesManagement = true;
                user.PermitItemManagement = false;
                user.PermitInventoryManagement = true;
                user.PermitHistoryViewer = false;
            }
            else
            {
                throw new FailedLogin();
            }

            connection.Close();

            return user;
        }

        #region Insertar
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
                throw new AlreadyExists();
            }
        }
        #endregion

        #region Update
        public void Update(Storage storage)
        {
            try
            {
                string query = "UPDATE Almacenes " +
                    "SET largo = @largo, ancho = @ancho " +
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
                throw new DoesNotExist();
            }
        }
        #endregion

        #region Delete
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
                throw new DoesNotExist();
            }
        }
        #endregion

        #region Getters Objects

        public User GetUser(string name)
        {
            string query = "SELECT * from Usuarios WHERE Nombre = @nombre";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nombre", name);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Close();
                return new User(dataReader["Nombre"].ToString(), dataReader["Password"].ToString(),
                    true, true, true, true, true);
            }

            connection.Close();
            return null;
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
            string query = "Select * from Usuarios";
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
        #endregion

        #region Getters Objects IDs
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

        public List<string> GetUsersName()
        {
            List<string> Names = new List<string>();
            string query = "SELECT Nombre FROM Usuarios";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader sqlData = command.ExecuteReader();
            while (sqlData.Read())
            {
                Names.Add(sqlData["Codigo"].ToString());
            }
            connection.Close();
            return Names;
        }
        #endregion
    }
}
