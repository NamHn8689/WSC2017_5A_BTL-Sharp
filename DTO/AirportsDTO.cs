using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Airports
    {
        public string ID { get; set; }

        public string CountryID { get; set; }

        public string IATACode { get; set; }

        public string Name { get; set; }

        public Airports()
        {
            this.ID = string.Empty;
            this.CountryID = string.Empty;
            this.IATACode = string.Empty;
            this.Name = string.Empty;
        }
    }
}
