using System;
using System.Collections.Generic;

namespace coreEntityFrameworkDatabaseFirstLook.Models;
// My Database from SSMS
public partial class Customer
{ 
    public int CustomerId { get; set; }

    public string? CustomerFirstName { get; set; }

    public string? CustomerMiddleName { get; set; }

    public string? CustomerLastName { get; set; }

    public double CustomerAmount { get; set; }

    public string? CustomerEmail { get; set; }

    public int CustomerPhone { get; set; }

}
