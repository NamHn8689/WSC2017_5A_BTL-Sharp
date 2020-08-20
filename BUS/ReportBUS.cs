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
    public class ReportBUS
    {
        ReportDAO reportDAO = new ReportDAO();
        public DataTable GetReportTable(ReportDTO reportDTO)
        {
            return reportDAO.GetReportTable(reportDTO);
        }
        public DataTable GetReportTable2()
        {
            return reportDAO.GetReportTable2();

        }
        
        public DataTable GetReportTableWithProc(ReportDTO reportDTO)
        {
            return reportDAO.GetReportTableWithProc(reportDTO);
        }
    }
}
