using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data_EF_DBFirst.Entities;

public partial class Restaurant
{
    [Key] // This means this property is a primary Key
    public int Id { get; set; }

    [StringLength(25)] // varchar(25)
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Cuisine { get; set; }

    public TimeSpan? OpenTime { get; set; }

    public TimeSpan? CloseTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Website { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? Zipcode { get; set; }

    [InverseProperty("Restaurant")]
    public virtual ICollection<Review> Reviews { get; } = new List<Review>();// this is denoting one to manmy multiplicity
}
