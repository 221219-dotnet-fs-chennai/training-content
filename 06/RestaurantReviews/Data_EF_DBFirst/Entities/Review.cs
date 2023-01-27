using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data_EF_DBFirst.Entities;

public partial class Review
{
    [Key]
    public int Id { get; set; }

    public double OverallRating { get; set; }

    [Unicode(false)]
    public string? Comment { get; set; }

    public int TasteRating { get; set; }

    public int AmbienceRating { get; set; }

    public int ServiceRating { get; set; }

    public int? RestaurantId { get; set; }

    [Column("username")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Username { get; set; }

    [ForeignKey("RestaurantId")]
    [InverseProperty("Reviews")]
    public virtual Restaurant? Restaurant { get; set; }

    [ForeignKey("Username")]
    [InverseProperty("Reviews")]
    public virtual User? UsernameNavigation { get; set; }
}
