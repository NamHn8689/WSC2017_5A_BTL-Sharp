using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AmenitiDAO : DBConnect
    {
        public DataTable GetAllAmenitiesTable()
        {
            try
            {
                DataTable dt = base.GetTable("SELECT * FROM Amenities");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable GetAmenitiesTableByID(string amenitiID) //chua chac da dung
        {
            try
            {
                string query = string.Format("SELECT * FROM Amenities WHERE ID = '{0}'", amenitiID);
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
