using Auth0.OidcClient;
using Foundation;
using UIKit;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    private Auth0Client auth0Client;

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        // Initialize Auth0 client
        auth0Client = new Auth0Client(new Auth0ClientOptions
        {
            Domain = "{yourDomain}",
            ClientId = "{yourClientId}"
        });

        return true;
    }

    public override bool OpenUrl(UIApplication application, NSUrl url,
        string sourceApplication, NSObject annotation)
    {
        ActivityMediator.Instance.Send(url.AbsoluteString);
        return true;
    }
}
