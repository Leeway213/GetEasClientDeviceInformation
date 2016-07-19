using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.ExchangeActiveSyncProvisioning;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GetEasClientDeviceInformation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            var deviceInfo = new EasClientDeviceInformation();

            FriendlyName.Text = deviceInfo.FriendlyName;
            OperatingSystem.Text = deviceInfo.OperatingSystem;
            SystemFirmwareVersion.Text = deviceInfo.SystemFirmwareVersion;
            SystemHardwareVersion.Text = deviceInfo.SystemHardwareVersion;
            SystemManufacturer.Text = deviceInfo.SystemManufacturer;
            SystemProductName.Text = deviceInfo.SystemProductName;
            SystemSku.Text = deviceInfo.SystemSku;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var deviceInfo = new EasClientDeviceInformation();

            FriendlyName.Text = deviceInfo.FriendlyName;
            OperatingSystem.Text = deviceInfo.OperatingSystem;
            SystemFirmwareVersion.Text = deviceInfo.SystemFirmwareVersion;
            SystemHardwareVersion.Text = deviceInfo.SystemHardwareVersion;
            SystemManufacturer.Text = deviceInfo.SystemManufacturer;
            SystemProductName.Text = deviceInfo.SystemProductName;
            SystemSku.Text = deviceInfo.SystemSku;
        }
    }
}
