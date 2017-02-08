//
// LocalFileHelper.cs
//
// Author: Dheeraj Kumar Gunti <>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using System.IO;
using Xamarin.Forms;
using XamarinFormsLocalDb.iOS;


[assembly: Dependency(typeof(LocalFileHelper))]
namespace XamarinFormsLocalDb.iOS
{
	public class LocalFileHelper : ILocalFileHelper
	{
		public string GetLocalFilePath(string filename)
		{
			string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

			if (!Directory.Exists(libFolder))
			{
				Directory.CreateDirectory(libFolder);
			}

			return Path.Combine(libFolder, filename);
		}
	}
}
