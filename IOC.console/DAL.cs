using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.console
{
    internal class DAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{Id=1,Name="Kalem",Price=199,Stock=299},
                new Product{Id=2,Name="Kitap",Price=19,Stock=2996},
                new Product{Id=3,Name="Defter",Price=99,Stock=9},
                new Product{Id=4,Name="Oyuncak",Price=1996,Stock=29},
            };
        }
    }
}
