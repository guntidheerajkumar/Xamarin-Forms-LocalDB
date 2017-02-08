
using Xamarin.Forms;

namespace XamarinFormsLocalDb
{
	public partial class App : Application
	{
		static EmployeeDatabase database;
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new EmployeeListPage());
		}

		public static EmployeeDatabase Database {
			get {
				if (database == null) {
					database = new EmployeeDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("EmployeeDb.db3"));
				}
				return database;
			}
		}


		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
