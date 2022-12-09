using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODFinal.Untitled
{
	public class Household
	{
		private string _HouseholdName;
		private List<Person> _Residents;
		private List<Chore> _Chores;
		private double _TotalMoneySpent;

		public Household(string houseHoldName)
		{
			throw new NotImplementedException();
		}

		public string HouseholdName
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public double TotalMoneySpent
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		private Person CreatePerson(string name)
		{
			throw new NotImplementedException();
		}

		private void AddPerson(string name)
		{
			throw new NotImplementedException();
		}

		private Chore CreateChore(string name, string desc)
		{
			throw new NotImplementedException();
		}

		private void AssignChore(Person person, Chore chore)
		{
			throw new NotImplementedException();
		}

		private void UnassignChore(Person person, Chore chore)
		{
			throw new NotImplementedException();
		}

		private void BalancePayments()
		{
			throw new NotImplementedException();
		}
	}
}
