public async Task LogoutAsync()
{
    var logoutResult = await auth0Client.LogoutAsync();

    if (logoutResult == BrowserResultType.Success)
    {
        // Clear stored credentials
        // Update UI to logged-out state
        Console.WriteLine("Logged out successfully");
    }
}
