using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thaw5
{
    internal class Category
    {
        public string id;
        public string nama;
        public Product product;

        public Category(string id, string nama)
        {
            this.id = id;
            this.nama = nama;
        }
    }
}
