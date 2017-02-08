//
// EmployeeDatabase.cs
//
// Author: Dheeraj Kumar Gunti <>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace XamarinFormsLocalDb
{
	public class EmployeeDatabase
	{
		readonly SQLiteAsyncConnection database;

		public EmployeeDatabase(string dbPath)
		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Employee>().Wait();
		}

		public Task<List<Employee>> GetEmployeesAsync()
		{
			return database.Table<Employee>().ToListAsync();
		}
 

		public Task<Employee> GetEmployeeAsync(int id)
		{
			return database.Table<Employee>().Where(i => i.EmpId == id).FirstOrDefaultAsync();
		}

		public Task<int> SaveEmployeeAsync(Employee item)
		{
			if (item.EmpId != 0)
			{
				return database.UpdateAsync(item);
			}
			else {
				return database.InsertAsync(item);
			}
		}

		public Task<int> DeleteEmployeeAsync(Employee item)
		{
			return database.DeleteAsync(item);
		}
	}
}
