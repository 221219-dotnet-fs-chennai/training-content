using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data_EF_DBFirst.Entities;

public partial class User
{
    [Key]
    [Column("username")]
    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("password")]
    [Unicode(false)]
    public string? Password { get; set; }

    [InverseProperty("UsernameNavigation")]
    public virtual ICollection<Review> Reviews { get; } = new List<Review>();
}
