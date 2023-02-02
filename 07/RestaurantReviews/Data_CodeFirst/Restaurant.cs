using System.ComponentModel.DataAnnotations;// add some conditions on the model for server side and client side valudations, may be for SQL constraints
using System.ComponentModel.DataAnnotations.Schema; // Purely for Sql Constraints

namespace Data_CodeFirst
{
    [Table("rest")]
    public class Restaurant
    {
        // Convention - property of type int named Id or ClassnameId is automatically considered as  Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [NotMapped] // excludes any the mapping of this property to db column
        //[Key] // using data annotations to mark it as a primary key, we use it specifically when Primary key is not as per EF core conventions
        public Guid rId { get; set; }
        [StringLength(30)]
        public string  Name { get; set; }
        public string? Cuisine { get; set; }
        [Column("otime")]
        public TimeSpan? OpenTime { get; set; }
        [Column("ctime")]
        public TimeSpan? CloseTime { get; set; }
        [StringLength(10)]
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        [Required]
        [StringLength(6)]
        //[RegularExpression("\d")] - pattern to be matched 
        public string Zipcode { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}