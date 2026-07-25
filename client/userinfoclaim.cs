if (!loginResult.IsError)
{
    foreach (var claim in loginResult.User.Claims)
    {
        Console.WriteLine($"{claim.Type}: {claim.Value}");
    }
}
