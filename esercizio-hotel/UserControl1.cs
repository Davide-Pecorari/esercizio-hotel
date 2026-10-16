using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizio_hotel
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void lbl_n1_Click(object sender, EventArgs e)
        {

        }

        private void btn_invia_Click(object sender, EventArgs e)
        {
            int ngiorni;
            string stanza, stagione, parcheggio;

            ngiorni = 0;
            stagione = cmb_n1.SelectedItem.ToString();

            if (stagione == "bassa stagione")
            {
                if (stanza == )
            }
        }

        private void cmb_n1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
