using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCode
{
	public class Person
	{
		private string _Name;
		List<Chore> _Chores;
		private Household _Household;
		private List<Payment> _Payments;
		private double _TotalSpent;

		public Person(string name, Household household)
		{
			_Name = name;
			_Chores = new List<Chore>();
			_Household = household;
			_Payments = new List<Payment>();
			_TotalSpent = 0;
		}

		public string Name
		{
			get
			{
				return _Name;
			}
			set
			{
				_Name = value;
			}
		}

		public double TotalSpent
		{
			get
			{
				return _TotalSpent;
			}
			set
			{
				_TotalSpent = value;
			}
		}

		public void AddChore(Chore chore)
		{
			_Chores.Add(chore);
		}

		public void RemoveChore(Chore chore) {
			_Chores.Remove(chore);
		}
	}
}
