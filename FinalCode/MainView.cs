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
		int numPeople = 0;
		List<uc_PersonPayTotal> PayTotals = new List<uc_PersonPayTotal>();
        public MainView() {
			InitializeComponent();
			
		}

		private void btn_MainAddPerson_Click(object sender, EventArgs e)
		{
			string name;
			name = txt_MainAddPersonName.Text;
			//txt_MainAddPersonName.Text = "";

			PayTotals.Add(new uc_PersonPayTotal());

			/*PayTotals[numPeople].

			personNames.Add(new Label());
			personNames[numPeople].Text = name;

			personTotals.Add(new Label());
			personTotals[numPeople].Text = "$0.00";

			panel_MainPersonHolder.Controls.Add(personNames[numPeople]);
			panel_MainPersonHolder.Controls.Add(personTotals[numPeople]);
			numPeople++;
			*/
		}
	}
}
