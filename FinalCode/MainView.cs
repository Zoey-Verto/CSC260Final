using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCode {
	
	public partial class MainView : Form {
		public static Label totalSpentNum;
        public MainView() {
			InitializeComponent();
			txt_HouseholdName.Text = Program.EpicHouse.HouseholdName;
			label_TotalSpentNum.Text = Program.EpicHouse.TotalMoneySpent.ToString();
			totalSpentNum = label_TotalSpentNum;
		}

		private void btn_MainAddPerson_Click(object sender, EventArgs e)
		{
			string name;
			name = txt_MainAddPersonName.Text;
			if(name == "") {
				return;
			}
			txt_MainAddPersonName.Text = "";
			int num = Program.EpicHouse.NumPeople;
			Program.EpicHouse.AddPerson(name);

			Program.PeopleHolder.Add(new uc_PersonPayTotal());
			Program.PeopleHolder[num].PersonName = name;

			Program.PeopleHolder[num].myPerson = Program.EpicHouse.getPerson(num);
			Program.EpicHouse.getPerson(num).myUI = Program.PeopleHolder[num];

			panel_MainPersonHolder.Controls.Add(Program.PeopleHolder[num]);
		}

		private void txt_HouseholdName_TextChanged(object sender, EventArgs e)
		{
			Program.EpicHouse.HouseholdName = txt_HouseholdName.Text;
		}

		private void btn_BalPayments_Click(object sender, EventArgs e)
		{
			Program.EpicHouse.BalancePayments();
		}
	}
}
