using EmployeeApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.Models
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly EmployeeAppContext employeeAppContext;

		public EmployeeRepository(EmployeeAppContext employeeAppContext)
		{
			this.employeeAppContext = employeeAppContext;
		}

		public async Task<IEnumerable<Employee>> GetEmployees()
		{
			return await employeeAppContext.Employee.ToListAsync();
		}
		public async Task<Employee> GetEmployee(int? id)
		{
			return await employeeAppContext.Employee
				.FirstOrDefaultAsync(m => m.id == id);  
		}
		public async Task<Employee> AddEmployee(Employee employee)
		{
			var result = await employeeAppContext.Employee.AddAsync(employee);
			await employeeAppContext.SaveChangesAsync();
			return result.Entity;
		 
		}
		public async Task UpdateEmployee(Employee employee)
		{
			employeeAppContext.Update(employee);
			await employeeAppContext.SaveChangesAsync();
		}
		public async Task DeleteEmployee(int? id)
		{
			var employee = await employeeAppContext.Employee.FindAsync(id);
			employeeAppContext.Employee.Remove(employee);
			await employeeAppContext.SaveChangesAsync();
		}
	}
}
