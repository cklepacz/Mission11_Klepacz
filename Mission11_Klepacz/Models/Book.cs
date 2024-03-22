using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission11_Klepacz.Models;

//Create a Database model that matches the scaffolded database
public partial class Book
{
    [Key]
    public int BookID { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string Publisher { get; set; } = null!;

    public string ISBN { get; set; } = null!;

    public string Classification { get; set; } = null!;

    public string Category { get; set; } = null!;

    public int PageCount { get; set; }

    public double Price { get; set; }
}
