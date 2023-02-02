using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Review
    {
        public int Id { get; set; }

        public double OverallRating { get; set; }

        public string? Comment { get; set; }

        private int _rating;
        public int TasteRating { 
            get {
                return _rating;
            }
            
            set {

                if (value > 0)
                    _rating = value;
                else
                    throw new Exception("taste rating should be greater than zero");
            } 
        }

        public int AmbienceRating { get; set; }

        public int ServiceRating { get; set; }

        public int? RestaurantId { get; set; }
    }
}
