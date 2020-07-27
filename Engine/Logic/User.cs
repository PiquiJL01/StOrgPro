using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool PermitUserManagement { get; set; }
        public bool PermitCatalogManagement { get; set; }
        public bool PermitInventoryManagement { get; set; }
        public bool PermitStoragesManagement { get; set; }
        public User(string userName, string password, bool permitUserManagement,
            bool permitCatalogManagement, bool permitInventoryManagement,
            bool permitStoragesManagement)
        {
            UserName = userName;
            Password = password;
            PermitUserManagement = permitUserManagement;
            PermitCatalogManagement = permitCatalogManagement;
            PermitInventoryManagement = permitInventoryManagement;
            PermitStoragesManagement = permitStoragesManagement;
        }

        public User(string userName, string password, int permitUserManagement,
            int permitCatalogManagement, int permitInventoryManagement,
            int permitStoragesManagement)
        {
            UserName = UserName;
            Password = password;
            if (permitUserManagement == 0)
            {
                PermitUserManagement = false;
            }
            else
            {
                PermitUserManagement = true;
            }

            if (permitCatalogManagement == 0)
            {
                PermitCatalogManagement = false;
            }
            else
            {
                PermitCatalogManagement = true;
            }

            if (permitInventoryManagement == 0)
            {
                PermitInventoryManagement = false;
            }
            else
            {
                PermitInventoryManagement = true;
            }

            if (permitStoragesManagement == 0)
            {
                PermitStoragesManagement = false;
            }
            else
            {
                PermitStoragesManagement = false;
            }
        }

        public void ValidatePassword(string PasswordToValidate)
        {
            if (!(Password == PasswordToValidate))
            {
                throw new FailedLogin();
            }
        }

        public int IntPermitUserMang()
        {
            if (PermitUserManagement)
            {
                return 1;
            }

            return 0;
        }

        public int IntPermitCatalogMang()
        {
            if (PermitCatalogManagement)
            {
                return 1;
            }

            return 0;
        }

        public int IntPermitInventoryMng()
        {
            if (PermitInventoryManagement)
            {
                return 1;
            }

            return 0;
        }

        public int IntPermitStorageMng()
        {
            if (PermitStoragesManagement)
            {
                return 1;
            }

            return 0;
        }

        public bool GetPermit(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.User:
                    return PermitUserManagement;
                case DataType.Storage:
                    return PermitStoragesManagement;
                case DataType.Item:
                    return PermitCatalogManagement;
                case DataType.Inventory:
                    return PermitInventoryManagement;
            }

            return false;
        }
    }
}
