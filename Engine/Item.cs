using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public Item(string code, string description, string brand, string model)
        {
            Code = code;
            Description = description;
            Brand = brand;
            Model = model;
        }
    }
}
