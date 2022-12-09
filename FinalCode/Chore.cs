using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCode
{
	public class Chore
	{
		private string _Name;
		private string _Description;
		private bool _Assigned;

		public Chore(string name, string desc = "No description")
		{
			_Name = name;
			_Description = desc;
			_Assigned = false;
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

		public bool Assigned
		{
			get
			{
				return _Assigned;
			}
			set
			{
				_Assigned = value;
			}
		}
	}
}
