using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;

namespace AnotherOne.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("Korisnik je kliknuo");
        }
    }
}
