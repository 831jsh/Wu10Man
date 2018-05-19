﻿using System.Diagnostics;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace WereDev.Utils.Wu10Man
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
        }

        private void GitHub_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Hyperlink linkAnnouncements = (Hyperlink)sender;
            string site = linkAnnouncements.NavigateUri.ToString();
            Process.Start(new ProcessStartInfo(site));
            e.Handled = true;
        }
    }
}
