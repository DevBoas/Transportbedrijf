using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Transportbedrijf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Decimal berekenToeslag(Decimal lading)
        {
            Decimal toeslag = 0;
            toeslag = lading * 0.035m;
            if (toeslag < 45)
                toeslag = 45;
            return toeslag;
        }
        private void Bereken_Click(object sender, EventArgs e)
        {
            int km = 0;
            int bkm = 0;
            int m3 = 0;
            int kg = 0;
            Decimal priceBinnenLands = 0;
            Decimal priceBuitenLands = 0;
            Decimal price = 0;
            Decimal lading = 0;
            Decimal toeslag = 0;
            Decimal totalPrice = 0;
            Int32.TryParse(TextBoxBuitenKm.Text, out bkm);
            Int32.TryParse(TextBoxKm.Text, out km);
            Int32.TryParse(TextBoxM3.Text, out m3);
            Int32.TryParse(TextBoxKg.Text, out kg);

            if (CheckBoxVloeibaar.Checked)
            {
                price += m3 * 1.25m;
                price += kg * 0.45m;
                lading = price;
            }
            else
            {
                price += m3 * 0.80m;
                price += kg * 0.55m;
                lading = price;
            }
            priceBinnenLands = (price * km);
            priceBuitenLands = (price * bkm) * 1.45m;
            if (bkm > 0) 
                toeslag = berekenToeslag(lading);
            totalPrice = priceBinnenLands + priceBuitenLands + toeslag;
            Output.Text = "Transport kosten zijn €" + totalPrice.ToString("0.##");
        }
    }
}
