namespace Architecture.Application.User.Add;

public sealed record AddUserRequest(string Name, string Email, string Login, string Password);
