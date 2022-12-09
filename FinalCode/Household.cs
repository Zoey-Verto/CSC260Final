using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCode
{
	public class Household
	{
		private string _HouseholdName;
		private List<Person> _Residents;
		private List<Chore> _Chores;
		private double _TotalMoneySpent;

		public Household(string houseHoldName)
		{
			_HouseholdName = houseHoldName;
			_Residents = new List<Person>();
			_Chores = new List<Chore>();
			_TotalMoneySpent = 0;
		}

		public string HouseholdName
		{
			get
			{
				return _HouseholdName;
			}
			set
			{
				_HouseholdName = value;
			}
		}

		public double TotalMoneySpent
		{
			get
			{
				return _TotalMoneySpent;
			}
			set
			{
				_TotalMoneySpent = value;
			}
		}

		public Person CreatePerson(string name)
		{
			return new Person(name, this);
		}

		public void AddPerson(string name)
		{
			Person person = CreatePerson(name);
			_Residents.Add(person);
		}

        public Chore CreateChore(string name, string desc)
		{
			Chore chore = new Chore(name, desc);
			_Chores.Add(chore);
			return chore;
		}

        public void AssignChore(Person person, Chore chore)
		{
			person.AddChore(chore);
			chore.Assigned = true;
		}

        public void UnassignChore(Person person, Chore chore)
		{
			person.RemoveChore(chore);
			chore.Assigned = false;
		}

        public void BalancePayments()
		{
			throw new NotImplementedException();
		}
	}
}
