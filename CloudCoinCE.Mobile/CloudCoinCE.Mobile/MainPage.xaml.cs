using Founders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CloudCoinCE.Mobile
{
	public partial class MainPage : ContentPage
	{
        public static bool isRAIDAReady = false;
        
		public MainPage()
		{
			InitializeComponent();

            lblRAIDA.Text = "RAIDA status: " + (isRAIDAReady ? "Ready" : "Not ready");

            Task.Run(() => {
                CoinOps.echoRaida();
                isRAIDAReady = GetRAIDAStatus();
                Device.BeginInvokeOnMainThread(()=> {
                    lblRAIDA.Text = "RAIDA status: " + (isRAIDAReady ? "Ready" : "Not ready");
                    if (isRAIDAReady)
                        cmdImport.IsEnabled = true;

                    });
                });

        }

        public bool GetRAIDAStatus()
        {

            int failCount = RAIDA_Status.failsEcho.Where(c => c).Count();
            if (failCount > 8)
                return false;
            else
                return true;
        }
        private void cmdImport_Clicked(object sender, EventArgs e)
        {

        }

        private void cmdBank_Clicked(object sender, EventArgs e)
        {

        }

        private void cmdExport_Clicked(object sender, EventArgs e)
        {

        }
    }
}
