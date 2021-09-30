using SDM_Compulsory_Assignment.Core.Models;
using System;
using System.Collections.Generic;

namespace SDM_Compulsory_Assignment.Infrastructure.Data.Repositories
{
    public static class ReviewMockData
    {
        public static List<Review> Reviews = new List<Review>()
        {
            new Review()
            {
                Reviewer = 563,
                Movie = 781196,
                Grade = 2,
                ReviewDate = DateTime.Parse("2003-03-06")
            }
        };
    }
}
