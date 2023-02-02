using System;
using System.Collections.Generic;

namespace DataFluentApi.Entities;

public partial class User
{
    public string Username { get; set; } = null!;

    public string? Password { get; set; }

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();
}
