using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCode {
	internal static class Program {
		public static Household EpicHouse = new Household("My Household");
        public static List<uc_PersonPayTotal> PeopleHolder = new List<uc_PersonPayTotal>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainView());
		}
	}
}