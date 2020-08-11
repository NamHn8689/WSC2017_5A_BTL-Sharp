using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC2017_5A
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }


        FlightBUS flightBUS = new FlightBUS();
        List<FlightDTO> flightDTOs = new List<FlightDTO>();
        private void form_Load(object sender, EventArgs e)
        {
            txtBookRef.Text = "12345B";
            grbAmenities.Enabled = false;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            //cbx.Items.Clear();
            string bookRef = txtBookRef.Text;

            FlightBUS flightBUS = new FlightBUS();
            List<FlightDTO> lsFlight = flightBUS.GetFlightsListByBookingReference(bookRef);

            DataTable items = new DataTable();
            items.Columns.Add("FlightDetail", typeof(string));
            items.Columns.Add("TicketID", typeof(string));

            foreach (FlightDTO flight in lsFlight)
            {
                items.Rows.Add(
                    string.Format(
                        "{0}, {1}-{2}, {3}, {4}",
                        flight.FlightNumber,
                        flight.DepartureIATACode,
                        flight.ArrivalIATACode,
                        flight.Date,
                        flight.Time
                    ),
                    flight.TicketID
                );
            }
            cbx.DataSource = items;
            cbx.DisplayMember = "FlightDetail";
            cbx.ValueMember = "TicketID";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string ticketId = cbx.SelectedValue.ToString();
            TicketBUS ticketBUS = new TicketBUS();

            TicketDTO ticket = ticketBUS.GetTicketByID(ticketId);

            CabinTypeBUS cabinTypeBUS = new CabinTypeBUS();
            CabinTypeDTO cabintype = cabinTypeBUS.GetCabinTypeByID(ticket.CabinTypeID.ToString());

            lbName.Text = ticket.Firstname + ticket.Lastname;
            lbPassport.Text = ticket.PassportNumber;
            lbCabinClass.Text = cabintype.Name;

            grbAmenities.Enabled = true;
            foreach (Control control in grbAmenities.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox chkb = (CheckBox)control;
                    chkb.Checked = false;
                }
            }
        }
    }
}
