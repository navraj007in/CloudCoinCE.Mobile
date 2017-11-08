using CloudCoinCE.Mobile.Interfaces;
using Founders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CloudCoinCE.Mobile
{
	public partial class App : Application
	{
        public static FileUtils fileUtils;
        string homeFolder = DependencyService.Get<IUtils>().GetHomeFolder();
		public App ()
		{
			InitializeComponent();

            Console.WriteLine("Home Folder-" + homeFolder);

            fileUtils = FileUtils.GetInstance(homeFolder);
            fileUtils.CreateDirectoryStructure();

			MainPage = new CloudCoinCE.Mobile.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
