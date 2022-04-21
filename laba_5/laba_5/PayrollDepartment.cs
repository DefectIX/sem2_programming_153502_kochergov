using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
	public class PayrollDepartment
	{
		private List<Employee> LstEmployees { get; set; } = new List<Employee>();
		private List<Work> LstWorks { get; set; } = new List<Work>();

		public void AddEmployee(string surname)
		{
			LstEmployees.Add(new Employee(surname));
		}

		public void AddWork(string workName, long salary, Work.WorkType type)
		{
			LstWorks.Add(new Work(workName, salary, type));
		}

		public void AddWorkForEmployee(string employeeSurname, string workName)
		{
			Work work = new Work();
			foreach (var curWork in LstWorks)
			{
				if (curWork.Name == workName)
				{
					work = curWork;
					break;
				}
			}

			Employee employee = new Employee();
			foreach (var curEmployee in LstEmployees)
			{
				if (curEmployee.Surname == employeeSurname)
				{
					employee = curEmployee;
					break;
				}
			}

			employee.LstWorksOfEmployee.Add(work);
		}

		public long GetSalaryBySurname(string surname)
		{
			Employee employee = new Employee();
			foreach (var curEmployee in LstEmployees)
			{
				if (curEmployee.Surname == surname)
				{
					employee = curEmployee;
					break;
				}
			}

			return employee.GetSalary();
		}

		public long GetTotalPayment()
		{
			long total = 0;
			foreach (var curEmployee in LstEmployees)
			{
				total += curEmployee.GetSalary();
			}

			return total;
		}
	}
}
