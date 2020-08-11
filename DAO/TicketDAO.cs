﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TicketDAO : DBConnect
    {
        public DataTable GetAllTicketsTable()
        {
            try
            {
                DataTable dt = base.GetTable("SELECT * FROM Tickets");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable GetTicketsTableByBookingReference(string bookRef)
        {
            try
            {
                string query = string.Format("SELECT * FROM Tickets WHERE BookingReference = '{0}'", bookRef);
                DataTable dt = base.GetTable(query);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetTicketTableByID(string ID)
        {
            try
            {
                string query = string.Format("SELECT * FROM Tickets WHERE ID = '{0}'", ID);
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