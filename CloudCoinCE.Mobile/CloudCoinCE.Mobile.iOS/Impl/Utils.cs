using CloudCoinCE.Mobile.Interfaces;
using CloudCoinCE.Mobile.iOS.Impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(Utils))]
namespace CloudCoinCE.Mobile.iOS.Impl
{
    public class Utils :IUtils
    {
        public string GetHomeFolder()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CloudCoinCE";
        }
    }
}
