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


        private void form_Load(object sender, EventArgs e)
        {
            txtBookRef.Text = "12345B";
            grbAmenities.Enabled = false;
            itemChoose = 0;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
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
            grbAmenities.Enabled = true;

            TicketBUS ticketBUS = new TicketBUS();

            TicketDTO ticket = ticketBUS.GetTicketByID(ticketId);

            CabinTypeBUS cabinTypeBUS = new CabinTypeBUS();

            CabinTypeDTO cabintype = cabinTypeBUS.GetCabinTypeByID(ticket.CabinTypeID.ToString());

            lbName.Text = ticket.Firstname + " " + ticket.Lastname;
            lbPassport.Text = ticket.PassportNumber;
            lbCabinClass.Text = cabintype.Name;

            AmenitiBUS amenitiBUS = new AmenitiBUS();
            List<AmenitiDTO> lsAmenities = amenitiBUS.GetAmenitiesListByCabinTypeID(ticket.CabinTypeID.ToString());

            AmenitiesTicketsBUS amenitiesTicketsBUS = new AmenitiesTicketsBUS();

            //list amnities da mua tai phien lam viec truoc load tu db
            List<AmenitiesTicketsDTO> lsAmenitiesTicket = amenitiesTicketsBUS.GetListAmenitiesTicketsByTicketID(ticketId);

            List<CheckBox> lsCheckBox = new List<CheckBox>();

            foreach (Control control in grbAmenities.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox chkb = (CheckBox)control;

                    chkb.Checked = false;
                    chkb.Enabled = false;

                    lsCheckBox.Add(chkb);
                }
            }
            //Hien thi nhung checkbox co the check
            for (int i = 0; i < lsAmenities.Count; i++)
            {
                for (int j = 0; j < lsCheckBox.Count; j++)
                {

                    if (lsAmenities[i].Service + " (Free)" == lsCheckBox[j].Text)
                    {
                        lsCheckBox[j].Checked = true;
                        lsCheckBox[j].Enabled = false;
                        break;
                    }
                    if (lsAmenities[i].Service + " ($" + Decimal.ToInt32(lsAmenities[i].Price) + ")" == lsCheckBox[j].Text)
                    {
                        lsCheckBox[j].Enabled = true;

                        break;
                    }
                }
            }
            //load amenities da tich tu db
            for (int i = 0; i < lsAmenitiesTicket.Count; i++)
            {
                for (int j = 0; j < lsCheckBox.Count; j++)
                {
                    if (lsAmenitiesTicket[i].AmenityID == getAmenityIDByChkbText(lsCheckBox[j].Text))
                        lsCheckBox[j].Checked = true;
                }
            }


        }

        private void CheckThenShow()
        {

            itemChoose = 0;
            setValue(itemChoose);
            List<CheckBox> lsCheckBox = new List<CheckBox>();

            foreach (Control control in grbAmenities.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox chkb = (CheckBox)control;
                    if (chkb.Enabled == true)
                        lsCheckBox.Add(chkb);
                }
                //chkb.Checked = false;
            }
            for (int i = 0; i < lsCheckBox.Count; i++)
            {
                if (lsCheckBox[i].Checked == true)
                {
                    itemChoose += getPrice(lsCheckBox[i].Text);
                    setValue(itemChoose);
                }
            }

        }

        static decimal itemChoose;
        private void btnSave_Click(object sender, EventArgs e)
        {
            string ticketId = cbx.SelectedValue.ToString();
            AmenitiesTicketsBUS amenitiesTicketsBUS = new AmenitiesTicketsBUS();

            amenitiesTicketsBUS.DeleteRowsByTicketId(ticketId);
            foreach (Control control in grbAmenities.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox chkb = (CheckBox)control;
                    if (chkb.Checked == true)
                    {
                        if (getAmenityIDByChkbText(chkb.Text) == 7 || getAmenityIDByChkbText(chkb.Text) == 11)
                            amenitiesTicketsBUS.AddARow(
                                new AmenitiesTicketsDTO(
                                    getAmenityIDByChkbText(chkb.Text),
                                    int.Parse(ticketId),
                                    0
                                ));
                        else
                            amenitiesTicketsBUS.AddARow(
                                new AmenitiesTicketsDTO(
                                    getAmenityIDByChkbText(chkb.Text),
                                    int.Parse(ticketId),
                                    getPrice(chkb.Text)
                                ));
                    }
                }
                //chkb.Checked = false;
            }
        }
        public int getAmenityIDByChkbText(string name)
        {
            switch (name)
            {
                case "Extra Blanket ($10)":
                    return 1;
                case "Next Seat Free ($30)":
                    return 2;
                case "Two Neighboring Seats Free ($35)":
                    return 3;
                case "Tablet Rental ($12)":
                    return 4;
                case "Laptop Rental ($15)":
                    return 5;
                case "Lounge Access ($25)":
                    return 6;
                case "Soft Drinks (Free)":
                    return 7;
                case "Premium Headphones Rental ($5)":
                    return 8;
                case "Extra Bag ($15)":
                    return 9;
                case "Fast Checkin Lane ($10)":
                    return 10;
                case "Wi-Fi 50 mb (Free)":
                    return 11;
            }
            return 12;
        }
        public decimal getPrice(string text)
        {
            string[] texts = text.Split('$');
            return decimal.Parse((texts[1].Split(')')[0]));
        }
        public void setValue(decimal itemChoose)
        {
            lbSelected.Text = "$" + itemChoose.ToString();
            lbFee.Text = "$" + (itemChoose * 5 / 100).ToString();
            lbTotal.Text = "$" + (itemChoose * 105 / 100).ToString();
        }

        private void chkbPHR_CheckedChanged(object sender, EventArgs e)
        {
            CheckThenShow();
        }
        private void chkbFCL_CheckedChanged(object sender, EventArgs e)
        {
            CheckThenShow();
        }

        private void chkbEBlanket_CheckedChanged(object sender, EventArgs e)
        {
            CheckThenShow();
        }

        private void chkbTR_CheckedChanged(object sender, EventArgs e)
        {
            CheckThenShow();
        }

        private void chkbLR_CheckedChanged(object sender, EventArgs e)
        {
            CheckThenShow();
        }

        private void chkbEBag_CheckedChanged(object sender, EventArgs e)
        {
            CheckThenShow();
        }

        private void chkbWF250_CheckedChanged(object sender, EventArgs e)
        {
            CheckThenShow();
        }

        private void chkbLA_CheckedChanged(object sender, EventArgs e)
        {
            CheckThenShow();
        }

        private void chkbNSF_CheckedChanged(object sender, EventArgs e)
        {
            CheckThenShow();
        }

        private void chkb2NSF_CheckedChanged(object sender, EventArgs e)
        {
            CheckThenShow();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Environment.Exit(0);
        }
    }
}
