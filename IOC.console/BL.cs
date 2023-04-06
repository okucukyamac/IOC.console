﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.console
{
    internal class BL
    {
        private DAL _dal { get; set; }

        public BL()
        {
            _dal = new DAL();
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();  
        }



    }
}
