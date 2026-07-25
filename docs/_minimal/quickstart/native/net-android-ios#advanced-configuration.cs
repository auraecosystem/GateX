var auth0Client = new Auth0Client(new Auth0ClientOptions
{
    Domain = "{yourDomain}",
    ClientId = "{yourClientId}",
    Scope = "openid profile email offline_access read:posts"
});
