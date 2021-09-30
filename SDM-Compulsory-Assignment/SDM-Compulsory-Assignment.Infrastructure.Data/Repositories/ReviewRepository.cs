using SDM_Compulsory_Assignment.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SDM_Compulsory_Assignment.Infrastructure.Data.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        public double GetAverageRateFromReviewer(int reviewer)
        {
            // Total
            var reviewerReviews = ReviewMockData.Reviews.FindAll(x => x.Reviewer == reviewer).ToList();
            int totalScore = 0;
            reviewerReviews.ForEach((review) =>
           {
               totalScore += review.Grade;
           });
            //var biggestScore = reviewerReviews.Max(x => x.Grade);
            return ((double)totalScore / reviewerReviews.Count);
        }

        public double GetAverageRateOfMovie(int movie)
        {
            throw new NotImplementedException();
        }

        public List<int> GetMostProductiveReviewers()
        {
            throw new NotImplementedException();
        }

        public List<int> GetMoviesWithHighestNumberOfTopRates()
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfRates(int movie, int rate)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfRatesByReviewer(int reviewer, int rate)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfReviews(int movie)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfReviewsFromReviewer(int reviewer)
        {
            return ReviewMockData.Reviews.FindAll(x => x.Reviewer == reviewer).Count;
        }

        public List<int> GetReviewersByMovie(int movie)
        {
            throw new NotImplementedException();
        }

        public List<int> GetTopMoviesByReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }

        public List<int> GetTopRatedMovies(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
