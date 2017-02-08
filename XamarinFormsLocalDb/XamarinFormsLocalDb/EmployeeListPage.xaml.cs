//
// EmployeeListPage.xaml.cs
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
	public partial class EmployeeListPage : ContentPage
	{
		public EmployeeListPage()
		{
			InitializeComponent();

			var toolbarItem = new ToolbarItem {
				Text = "+"
			};

			toolbarItem.Clicked += async (sender, e) => {
				await Navigation.PushAsync(new EmployeePage() { BindingContext = new Employee() });
			};

			ToolbarItems.Add(toolbarItem);
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();

			EmployeeListView.ItemsSource = await App.Database.GetEmployeesAsync();
		}

		async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null) {
				await Navigation.PushAsync(new EmployeePage() { BindingContext = e.SelectedItem as Employee });
			}
		}
	}
}
