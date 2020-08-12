﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AmenitiesTicketsBUS
    {
        AmenitiesTicketsDAO amenitiesTicketsDAO = new AmenitiesTicketsDAO();
        public List<AmenitiesTicketsDTO> GetListAmenitiesTicketsDTO()
        {

            List<AmenitiesTicketsDTO> lsAmenitiesTickets = new List<AmenitiesTicketsDTO>();
            DataTable dt = amenitiesTicketsDAO.GetAllAmenitiesTicketsTypesTable();

            foreach (DataRow dr in dt.Rows)
            {
                AmenitiesTicketsDTO obj = new AmenitiesTicketsDTO();

                obj.AmenityID = int.Parse(dr["AmenityID"].ToString());
                obj.TicketID = int.Parse(dr["TicketID"].ToString());
                obj.Price = decimal.Parse(dr["Price"].ToString());

                lsAmenitiesTickets.Add(obj);
            }

            return lsAmenitiesTickets;
        }
        public void AddARow(AmenitiesTicketsDTO amenitiesTicket)
        {
            amenitiesTicketsDAO.AddARow(amenitiesTicket);
        }
        public void DeleteRowsByTicketId(string ticketID)
        {
            amenitiesTicketsDAO.DeleteRowsByTicketId(ticketID);
        }

    }
}
