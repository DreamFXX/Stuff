﻿namespace firstFormsApp_SQLServer;

public class Person
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? EmailAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public string FullInfo
    {get
        {
        return $"{FirstName} {LastName} - {EmailAddress} - {PhoneNumber}";
        }

    }

}

