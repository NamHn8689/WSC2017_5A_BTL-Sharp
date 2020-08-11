using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AmenitiesCabinTypeDAO : DBConnect
    {
        public DataTable GetAllAmenitiesCabinTypeTable()
        {
            try
            {
                DataTable dt = base.GetTable("SELECT * FROM AmenitiesCabinType");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable GetCabinTypeTableByID(string cabinTypeID)//cabinTypeID get from ChoosedTicket
        {
            try
            {
                string query = string.Format("SELECT * FROM AmenitiesCabinType WHERE ID = '{0}'", cabinTypeID);
                DataTable dt = base.GetTable(query);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
