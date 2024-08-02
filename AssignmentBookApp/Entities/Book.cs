using System;
using System.Collections.Generic;

namespace AssignmentBookApp.Entities;

public partial class Book
{
    public int BookId { get; set; }

    public string BookName { get; set; } = null!;

    public int? Price { get; set; }

    public string Author { get; set; } = null!;

    public string Lang { get; set; } = null!;

    public DateOnly? ReleaseDate { get; set; }
}
