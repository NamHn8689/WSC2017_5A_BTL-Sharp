using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ReportDAO : DBConnect
    {
        public DataTable GetReportTable()
        {
            try
            {
                DataTable dt = base.GetTable("SELECT * FROM [dbo].[F1]()");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable GetReportTableWithProc(ReportDTO reportDTO)
        {
            try
            {
                string query = string.Format("exec P1 {0},'{1}','{2}'",
                    reportDTO.FlightNumber,
                    reportDTO.From,
                    reportDTO.To
                    );
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
