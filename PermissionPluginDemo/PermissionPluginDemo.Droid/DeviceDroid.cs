using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Net.Wifi;
using PermissionPluginDemo.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceDroid))]
namespace PermissionPluginDemo.Droid
{
    public class DeviceDroid:IDevice
    {
        public string GetDeviceMac()
        {
            WifiManager wifiManager = ((WifiManager)Application.Context
    .GetSystemService(Context.WifiService));
            var wifiInfo = wifiManager.ConnectionInfo;
            IList<ScanResult> scanResults = wifiManager.ScanResults;
            if (scanResults.Count !=0 )
            {
                return scanResults[0].Bssid;
            }
            return "null";
            //return wifiInfo.MacAddress;
        }
    }
}