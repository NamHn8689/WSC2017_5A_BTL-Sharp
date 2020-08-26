using DTO;
using System;
using System.Data;

namespace DAO
{
    public class ReportDAO : DBConnect
    {

        public DataTable GetReportByAmenityIDAndCabinID(string flightNumber, string amenityID, string cabinID, string dateFrom, string dateTo)
        {
            try
            {
                string query = string.Format("SELECT * FROM func_GetReportByAmenityIDAndCabinID(N'{0}', {1}, {2}, '{3}', '{4}')",
                    flightNumber,
                    amenityID,
                    cabinID,
                    dateFrom,
                    dateTo);
                DataTable dt = this.GetTable(query);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable GetReportTable(ReportDTO reportDTO)
        {
            try
            {
                AmenitiDAO amenitiDAO = new AmenitiDAO();
                CabinTypeDAO cabinTypeDAO = new CabinTypeDAO();

                DataTable amenitiesTable = amenitiDAO.GetAllAmenitiesTable();
                DataTable cabinTypesTable = cabinTypeDAO.GetAllCabinTypesTable();

                DataTable result = new DataTable();
                result.Columns.Add("Name");

                foreach (DataRow dr in amenitiesTable.Rows)
                    result.Columns.Add(dr["Service"].ToString());
                //add 12 columns to result table (12 service)

                foreach (DataRow drCabin in cabinTypesTable.Rows)//duyet 3 loai cabin
                {
                    DataRow dr;//dr of result table (report table)
                    dr = result.NewRow();
                    dr["Name"] = drCabin["Name"].ToString();

                    foreach (DataRow drAmenity in amenitiesTable.Rows)
                    {
                        DataTable dt = this.GetReportByAmenityIDAndCabinID(
                            reportDTO.FlightNumber.ToString(),
                            drAmenity["ID"].ToString(),
                            drCabin["ID"].ToString(),
                            reportDTO.From,
                            reportDTO.To);

                        String amenityService = drAmenity["Service"].ToString();

                        dr[amenityService] = (dt.Rows.Count != 0) ? dt.Rows[0]["Total"] : "0";

                    }

                    result.Rows.Add(dr);
                }

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public DataTable GetReportTable2()
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
