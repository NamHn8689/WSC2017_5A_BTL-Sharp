using System;
using System.Data;

namespace DAO
{
    public class ScheduleDAO : DBConnect
    {
        public DataTable GetScheduleTableByID(string ID)
        {
            try
            {
                string query = string.Format("select * from Schedules where ID like '{0}'", ID);
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
