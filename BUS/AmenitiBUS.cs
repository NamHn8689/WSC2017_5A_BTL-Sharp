using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AmenitiBUS
    {
        AmenitiDAO amenitiDAO = new AmenitiDAO();
        public DataTable GetAmenitiesTableByCabinTypeID(string cabinTypeID)
        {
            return amenitiDAO.GetAmenitiesTableByCabinTypeID(cabinTypeID);
        }
        public List<AmenitiDTO> GetAmenitiesListByCabinTypeID(string cabinTypeID)
        {
            List<AmenitiDTO> lsAmenities = new List<AmenitiDTO>();
            DataTable dt = GetAmenitiesTableByCabinTypeID(cabinTypeID);

            foreach (DataRow dr in dt.Rows)
            {
                AmenitiDTO amenity = new AmenitiDTO();

                amenity.ID = int.Parse(dr["ID"].ToString());
                amenity.Service = dr["Service"].ToString();
                amenity.Price = decimal.Parse(dr["Price"].ToString());

                lsAmenities.Add(amenity);
            }

            return lsAmenities;
        }
    }
}
