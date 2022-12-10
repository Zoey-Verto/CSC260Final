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
			
		}
	}
}


/*
import re
live = True

if(not live):
  f = open('data', 'r')

print('To use this program, follow the pattern below')
print('Name $#.##')
print('When you are done inputting data, type \"done\"')

data = {}
names = []

totalMoney = 0
avgSpent = 0
count = 0

pattern = re.compile(r"[a-z]+ \$[\d]+\.[\d]{2}")

#test = "zoey $50.00"
#if(re.fullmatch(pattern, test)):
#  print("Pattern match")
#else:
#  print("Wrong pattern")

while (live):
  val = input().lower()
  if val == "done":
    break
  if re.fullmatch(pattern, val):
    val = val.split(" $")
    #print(val)
    name = val[0]
    amount = float(val[1])
    if (name in names):
      data[name] += amount
    else:
      names.append(name)
      data[name] = amount
      count += 1
    totalMoney += amount
    #print(data)
  else:
    print("Incorrect input, try again: ")


while (not live):
  val = f.readline()
  val = val[:-1]
  print(val)
  if val == "done":
    break
  if re.fullmatch(pattern, val):
    val = val.split(" $")
    #print(val)
    name = val[0]
    amount = float(val[1])
    if (name in names):
      data[name] += amount
    else:
      names.append(name)
      data[name] = amount
      count += 1
    totalMoney += amount
    #print(data)
  else:
    print("Incorrect input, try again: ")
    
#totalMoney = 482.74
#count = 5

avgSpent = totalMoney/count
print("\n")
print(f"Total spent: ${totalMoney}")
print(f"Average spent: ${avgSpent:.2f}\n")

debts = data.copy()

for name in names:
  debts[name] -= avgSpent
  debt = debts[name]
  if(debts[name] > 0):
    print(f"{name} is owed ${debt:.2f}")
  else:
    debt = debt * -1
    print(f"{name} owes ${debt:.2f}")


 */