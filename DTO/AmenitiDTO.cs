﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AmenitiDTO
    {
        public int ID { get; set; }
        public string Service { get; set; }
        public decimal Price { get; set; }
        public AmenitiDTO()        {        }
        public AmenitiDTO(int ID, string Service, int Price)
        {
            this.ID = ID;
            this.Service = Service;
            this.Price = Price;
        }
    }
}
