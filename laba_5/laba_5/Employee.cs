using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
	class Employee
	{
		public List<Work> LstWorksOfEmployee { get; set; } = new List<Work>();
		public string Surname { get; set; }

		public Employee()
		{
		}

		public Employee(string surname)
		{
			Surname = surname;
		}
		
		public void AddWork(string name, long salary, Work.WorkType type)
		{
			LstWorksOfEmployee.Add(new Work(name, salary, type));
		}

		public long GetSalary()
		{
			long result = 0;
			foreach(var work in LstWorksOfEmployee)
				result += work.Salary;
			return result;
		}
	}
}
