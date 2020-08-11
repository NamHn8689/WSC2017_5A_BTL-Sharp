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
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            cbx.Items.Clear();
            flightDTOs = flightBUS.FethchFlights(txtBookRef.Text);
            if (flightDTOs.Count != 0)
            {
                cbx.Text = flightDTOs[0].ToString();
                for (int i = 0; i < flightDTOs.Count; i++)
                {
                    cbx.Items.Add(flightDTOs[i].ToString());
                }
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }
    }
}
