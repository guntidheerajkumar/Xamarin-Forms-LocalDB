//
// EmployeePage.xaml.cs
//
// Author: Dheeraj Kumar Gunti <>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsLocalDb
{
	public partial class EmployeePage : ContentPage
	{
		public EmployeePage()
		{
			InitializeComponent();
		}

		async void Save_Clicked(object sender, System.EventArgs e)
		{
			var personItem = (Employee)BindingContext;
			await App.Database.SaveEmployeeAsync(personItem);
			await Navigation.PopAsync();
		}
	}
}
