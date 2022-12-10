using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCode
{
    public partial class uc_PersonPayTotal : UserControl
    {
        public uc_PersonPayTotal()
        {
            InitializeComponent();
        }

        public string PersonName
        {
            get
            {
                return this.label_PersonName.Text;
            }
            set
            {
                this.label_PersonName.Text = value;
            }
        }

        private void btn_AddToTotal_Click(object sender, EventArgs e)
        {
            string text = txt_Payment.Text;
            double payment, total;

            if(!double.TryParse(text, out payment)){
                txt_Payment.Text = "Error";
                return;
            }

            total = payment + double.Parse(label_TotalPaid.Text);

            label_TotalPaid.Text = total.ToString();

            txt_Payment.Text = "";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Program.PayTotals.Remove(this);
            this.Dispose();
            Program.numPeople--;
        }
    }
}
