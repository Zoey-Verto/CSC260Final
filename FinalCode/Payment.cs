using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCode
{
	public class Payment
	{
		private double _Amount;
		private string _Description;

		public Payment(double amount, string desc = "No description")
		{
			_Amount = amount;
			_Description = desc;
		}

		public double Amount
		{
			get
			{
				return _Amount;
			}
			set
			{
				_Amount = value;
			}
		}

		public string Description
		{
			get
			{
				return _Description;
			}
			set
			{
				_Description = value;
			}
		}
	}
}
