using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_CodeFirst
{
    public class Review
    {
        public int Id { get; set; }
        public string? Comment { get; set; }
        [Range(1,5)]
        public int? TasteRating { get; set; }
        [Range(1, 5)]
        public int? AmbienceRating { get; set; }
        [Range(1, 5)]
        public int? ServiceRating { get; set; }

        public int? RestaurantId { get; set; }
    }
}
