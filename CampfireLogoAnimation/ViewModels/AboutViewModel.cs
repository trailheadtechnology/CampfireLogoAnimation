﻿using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CampfireLogoAnimation.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://trailheadtechnology.com/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}