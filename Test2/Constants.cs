using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StOrgPro
{
    public class Constants
    {
        public const string Crear = "Crear";
        public const string Modificar = "Modificar";
        public const string Eliminar = "Eliminar";

        public const string Usuario = "Usuario";
        public const string Almacen = "Almacen";
        public const string Item = "Ítem";
        public const string Inventario = "Inventario";

        public const string Nombre = "Nombre";
        public const string Largo = "Largo";
        public const string Ancho = "Ancho";

        public const string Modelo = "Modelo";
        public const string Marca = "Marca";
        public const string Codigo = "Codigo";
        public const string Descripcion = "Descripción";
    }
    public enum Process
    {
        Create,
        Modify,
        Delete
    }

    public enum DataType
    {
        User,
        Storage,
        Item,
        Inventory
    }
}
