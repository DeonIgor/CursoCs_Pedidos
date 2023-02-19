using System;

namespace Entities;

public class Client {
    public String Name { get; set; }
    public String Email { get; set; }
    public DateTime birthDate { get; set; }

    public Client(string name, string email, DateTime birthDate)
    {
        Name = name;
        Email = email;
        this.birthDate = birthDate;
    }
}