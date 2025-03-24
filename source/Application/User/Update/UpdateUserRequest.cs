namespace Architecture.Application.User.Update;

public sealed record UpdateUserRequest([property: JsonIgnore] long Id, string Name, string Email);
