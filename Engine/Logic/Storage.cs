using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Storage
    {
        public string Name { get; set; }
        public int[] Dimensions = new int[2];

        public Storage(string name, int length, int width)
        {
            Name = name;
            Dimensions[0] = length;
            Dimensions[1] = width;
        }

        public string InventoryName()
        {
            return "Inventario" + Name; 
        }
    }
}
