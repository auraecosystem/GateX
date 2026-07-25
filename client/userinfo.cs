var loginResult = await auth0Client.LoginAsync();

if (!loginResult.IsError)
{
    // Access tokens
    var accessToken = loginResult.AccessToken;
    var idToken = loginResult.IdentityToken;
    var refreshToken = loginResult.RefreshToken;

    // Access user claims
    var user = loginResult.User;
    var name = user.FindFirst("name")?.Value;
    var email = user.FindFirst("email")?.Value;
    var picture = user.FindFirst("picture")?.Value;

    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Email: {email}");
}
