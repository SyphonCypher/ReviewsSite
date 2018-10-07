using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsSite.Models;

namespace ReviewsSite
{
    public class ReviewRepository : IReviewRepository
    {
        Dictionary<int, Review> allReviews = new Dictionary<int, Review>()
        {
            {1, new Review(){Id = 1, Name = "Mortarion"} },
            {2, new Review(){Id = 2, Name = "Roboute"} },
            {3, new Review(){Id = 3, Name = "Emperor"} },
        };

        public Review FindById(int id)
        {
            return allReviews[id];
        }

        public Dictionary<int, Review> GetAll()
        {
            return GetAll();
        }
    }
}
