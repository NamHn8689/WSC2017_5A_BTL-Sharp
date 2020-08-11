using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CabinTypeDAO : DBConnect
    {
        public DataTable GetAllCabinTypesTable()
        {
            try
            {
                DataTable dt = base.GetTable("SELECT * FROM CabinTypes");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable GetCabinTypeTableByID(string cabinTypeID)
        {
            try
            {
                string query = string.Format("SELECT * FROM CabinTypes WHERE ID = '{0}'", cabinTypeID);
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
