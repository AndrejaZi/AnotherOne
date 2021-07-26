using Android.App;
using Android.Content;
using AndroidX.AppCompat.App;
using System;
using System.Threading.Tasks;

namespace AnotherOne.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash",
              MainLauncher = true,
              NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            Task.Delay(TimeSpan.FromSeconds(10));
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            
        }

    }
}
