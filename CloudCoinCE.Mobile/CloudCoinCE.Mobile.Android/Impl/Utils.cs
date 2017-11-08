using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CloudCoinCE.Mobile.Interfaces;
using CloudCoinCE.Mobile.Droid.Impl;

[assembly: Xamarin.Forms.Dependency(typeof(Utils))]
namespace CloudCoinCE.Mobile.Droid.Impl
{
    public class Utils : IUtils
    {
        public string GetHomeFolder()
        {
           return Android.OS.Environment.ExternalStorageDirectory.ToString() + "/CloudCoinCE";
        }
    }
}