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
    class ScheduleBUS
    {
        ScheduleDAO scheduleDAO = new ScheduleDAO();
        public ScheduleDTO GetScheduleByID(string ID)
        {
            DataTable dt = scheduleDAO.GetScheduleTableByID(ID);
            DataRow dr = dt.Rows[0];

            ScheduleDTO schedule = new ScheduleDTO();

            schedule.ID = int.Parse(dr[0].ToString());
            schedule.Date = dr[1].ToString();
            schedule.Time = dr[2].ToString();
            schedule.AircraftID = int.Parse(dr[3].ToString());
            schedule.RouteID = int.Parse(dr[4].ToString());
            schedule.EconomyPrice = decimal.Parse(dr[5].ToString());
            schedule.Confirmed = bool.Parse(dr[6].ToString());
            schedule.FlightNumber = dr[7].ToString();

            return schedule;
        }
    }
}
