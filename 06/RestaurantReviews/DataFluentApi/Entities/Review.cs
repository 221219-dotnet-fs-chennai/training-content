using System;
using System.Collections.Generic;

namespace DataFluentApi.Entities;

public partial class Review
{
    public int Id { get; set; }

    public double OverallRating { get; set; }

    public string? Comment { get; set; }

    public int TasteRating { get; set; }

    public int AmbienceRating { get; set; }

    public int ServiceRating { get; set; }

    public int? RestaurantId { get; set; }

    public string? Username { get; set; }

    public virtual Restaurant? Restaurant { get; set; }

    public virtual User? UsernameNavigation { get; set; }
}
