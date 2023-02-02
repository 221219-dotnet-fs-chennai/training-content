using System;
using System.Collections.Generic;

namespace DataFluentApi.Entities;

public partial class Restaurant
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Cuisine { get; set; }

    public TimeSpan? OpenTime { get; set; }

    public TimeSpan? CloseTime { get; set; }

    public string? Phone { get; set; }

    public string? Website { get; set; }

    public string? Email { get; set; }

    public string? Zipcode { get; set; }

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();
}
