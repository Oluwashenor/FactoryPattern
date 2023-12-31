﻿namespace FactoryPattern.Models;

public interface IUserData
{
    string? Name { get; set; }
}

public class UserData : IUserData
{
    public string? Name { get; set; }
}
