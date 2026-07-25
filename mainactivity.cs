using Auth0.OidcClient;
using Android.App;
using Android.Content;

[Activity(Label = "Auth0Sample", MainLauncher = true, Icon = "@drawable/icon",
    LaunchMode = LaunchMode.SingleTask)]
[IntentFilter(
    new[] { Intent.ActionView },
    Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
    DataScheme = "YOUR_ANDROID_PACKAGE_NAME",
    DataHost = "{yourDomain}",
    DataPathPrefix = "/android/YOUR_ANDROID_PACKAGE_NAME/callback")]
public class MainActivity : Activity
{
    private Auth0Client auth0Client;

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Initialize Auth0 client
        auth0Client = new Auth0Client(new Auth0ClientOptions
        {
            Domain = "{yourDomain}",
            ClientId = "{yourClientId}"
        }, this);
    }

    protected override async void OnNewIntent(Intent intent)
    {
        base.OnNewIntent(intent);
        Auth0.OidcClient.ActivityMediator.Instance.Send(intent.DataString);
    }
}
