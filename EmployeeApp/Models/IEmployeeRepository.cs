using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.Models
{
	public interface IEmployeeRepository
	{
		Task<IEnumerable<Employee>> GetEmployees();
		Task<Employee> GetEmployee(int? id);
		Task<Employee> AddEmployee(Employee employee);
		Task UpdateEmployee(Employee employee);
		Task DeleteEmployee(int? id);

	}
}
