using System;
using System.IO;
using Xamarin.Forms;
using XamarinFormsLocalDb.Droid;

[assembly: Dependency(typeof(LocalFileHelper))]
namespace XamarinFormsLocalDb.Droid
{
	public class LocalFileHelper : ILocalFileHelper
	{
		public string GetLocalFilePath(string filename)
		{
			string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

			if (!Directory.Exists(libFolder)) {
				Directory.CreateDirectory(libFolder);
			}

			return Path.Combine(libFolder, filename);
		}
	}
}
