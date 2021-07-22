using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;

namespace AnotherOne.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Korisnik je kliknuo");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                int[] errorArray = { 1, 2, 3 };
                Console.WriteLine(errorArray[10]); //kreira gresku
            }
            catch (Exception exc)
            {
                var greska = new Dictionary<string, string>
                {
                    { "Greska", "string greske" },
                    { "Korisni podaci", "ukljuceni"}
                };
                Crashes.TrackError(exc, greska);
                
            }
        }
    }
}
