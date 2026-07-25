public async Task LoginAsync()
{
    var loginResult = await auth0Client.LoginAsync();

    if (!loginResult.IsError)
    {
        // Authentication successful
        var accessToken = loginResult.AccessToken;
        var idToken = loginResult.IdentityToken;
        var user = loginResult.User;

        // Store credentials and update UI
        Console.WriteLine($"Logged in as: {user.FindFirst("name")?.Value}");
    }
    else
    {
        // Handle authentication error
        Console.WriteLine($"Login error: {loginResult.Error}");
    }
}
