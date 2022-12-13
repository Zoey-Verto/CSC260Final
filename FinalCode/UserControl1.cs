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
        public Person myPerson;
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

        public bool OweVisible
        {
            get
            {
                return this.label_Owe.Visible;
            }
            set
            {
                this.label_Owe.Visible = value;
            }
        }

        public string OweText
        {
            get
            {
                return this.label_Owe.Text;
            }
            set
            {
                this.label_Owe.Text = value;
            }
        }

        public string TotalPaid
        {
            get
            {
                return this.label_TotalPaid.Text;
            }
            set
            {
                this.label_TotalPaid.Text = value;
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

            Program.EpicHouse.TotalMoneySpent += payment;
            MainView.totalSpentNum.Text = Program.EpicHouse.TotalMoneySpent.ToString();
            myPerson.TotalSpent = total;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Program.PeopleHolder.Remove(this);
            Program.EpicHouse.RemovePerson(myPerson);
            this.Dispose();
        }
    }
}
