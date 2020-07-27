using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Logic
{
    class SearchResult
    {
        public string Storagename { get; set; }
        public int Quantity { get; set; }

        public SearchResult(string storageName, int quantity)
        {
            Storagename = storageName;
            Quantity = quantity;
        }
    }
}
