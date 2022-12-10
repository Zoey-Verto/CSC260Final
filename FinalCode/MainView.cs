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

        public MainView() {
			InitializeComponent();
			
		}

		private void btn_MainAddPerson_Click(object sender, EventArgs e)
		{
			string name;
			name = txt_MainAddPersonName.Text;
			//txt_MainAddPersonName.Text = "";

			Program.PayTotals.Add(new uc_PersonPayTotal());
			Program.PayTotals[Program.numPeople].PersonName = name;

			panel_MainPersonHolder.Controls.Add(Program.PayTotals[Program.numPeople]);
            Program.numPeople++;
		}

		private void txt_HouseholdName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
