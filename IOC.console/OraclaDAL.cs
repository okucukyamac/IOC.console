using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.console
{
    internal class OraclaDAL:IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{Id=1,Name="or Kalem",Price=199,Stock=299},
                new Product{Id=2,Name="or Kitap",Price=19,Stock=2996},
                new Product{Id=3,Name="or Defter",Price=99,Stock=9},
                new Product{Id=4,Name="or Oyuncak",Price=1996,Stock=29},
            };
        }
    }
}
