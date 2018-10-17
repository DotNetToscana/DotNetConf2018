using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Essentials
{
    public partial class MainPage : ContentPage
    {
        private Location currentPosition;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGetPosition(object sender, EventArgs e)
        {
            PositionLoading.IsRunning = true;
            currentPosition = await Geolocation.GetLocationAsync();
            PositionLoading.IsRunning = false;
            Latitude.Text = $"Latitude: {currentPosition.Latitude}";
            Longitude.Text = $"Longitude: {currentPosition.Longitude}";
        }

        private async void OnOpenMap(object sender, EventArgs e)
        {
            await currentPosition.OpenMapsAsync();
        }

        private void OnGetDeviceInfo(object sender, EventArgs e)
        {
            DeviceModel.Text = DeviceInfo.Model;
            DeviceManufacturer.Text = DeviceInfo.Manufacturer;
            OSVersion.Text = $"{DeviceInfo.Platform} {DeviceInfo.VersionString}";
        }
    }
}
