﻿using BassPlayer.Properties;
using System.Windows;

namespace BassPlayer.Controls
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TbbProxyPass.Password = Settings.Default.ProxyPassword;
            TbProxyPort.Text = Settings.Default.ProxyPort;
            TbProxyUrl.Text = Settings.Default.ProxyAddress;
            TbProxyUser.Text = Settings.Default.ProxyUser;
            CbMediaKeys.IsChecked = Settings.Default.MediaKeys;
            CbProxyEnabled.IsChecked = Settings.Default.ProxyEnabled;
            CbProxyAuth.IsChecked = Settings.Default.ProxyAuthReq;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.ProxyPassword = TbbProxyPass.Password;
            Settings.Default.ProxyPort = TbProxyPort.Text;
            Settings.Default.ProxyAddress = TbProxyUrl.Text;
            Settings.Default.ProxyUser = TbProxyUser.Text;
            Settings.Default.ProxyEnabled = (bool)CbProxyEnabled.IsChecked;
            Settings.Default.MediaKeys = (bool)CbMediaKeys.IsChecked;
            Settings.Default.ProxyAuthReq = (bool)CbProxyAuth.IsChecked;
            Settings.Default.Save();
            this.DialogResult = true;
        }
    }
}
