using SDM_Compulsory_Assignment.Core.IServices;
using SDM_Compulsory_Assignment.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SDM_Compulsory_Assignment.Domain.Services
{
    public class ReviewService : IReviewService
    {
        readonly IReviewRepository _ReviewRepository;
        readonly IDataCRUD _DataCRUD;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _ReviewRepository = reviewRepository;
        }

        public ReviewService(IDataCRUD dataCRUD)
        {
            _DataCRUD = dataCRUD;
        }


        public double GetAverageRateFromReviewer(int reviewer)
        {
            // Total
            var reviewerReviews = _DataCRUD.ReadAll().ToList().FindAll(x => x.Reviewer == reviewer).ToList();
            int totalScore = 0;
            reviewerReviews.ForEach((review) =>
            {
                totalScore += review.Grade;
            });
            return ((double)totalScore / reviewerReviews.Count);
        }

        public double GetAverageRateOfMovie(int movie)
        {
            // Total
            var movies = _DataCRUD.ReadAll().ToList().FindAll(x => x.Movie == movie).ToList();
            int totalScore = 0;
            movies.ForEach((review) =>
            {
                totalScore += review.Grade;
            });
            return ((double)totalScore / movies.Count);
        }

        public List<int> GetMostProductiveReviewers()
        {
            // Reviewer id, reviewer amount/count
            var dict = new Dictionary<int, int>();
            var ids = new List<int>();

            var allReviewers = _DataCRUD.ReadAll().ToList();
            for (int i = 0; i < allReviewers.Count; i++)
            {
                var reviewer = allReviewers[i];

                // Check if the reviewer id exists, if not add.
                if (!dict.ContainsKey(reviewer.Reviewer))
                {
                    // Reviewer id, reviewer count.
                    dict.Add(reviewer.Reviewer, 1);
                }
                else
                {
                    // Reviewer id (key)
                    var amount = dict[reviewer.Reviewer]++;
                    dict[reviewer.Reviewer] = amount;
                }
            }

            var highestAmount = dict.Values.Max();
            foreach (var entry in dict)
            {
                if (entry.Value == highestAmount)
                    ids.Add(entry.Key);
            }

            //return dict.OrderByDescending(x => x.Key).ToList();
            //return _DataCRUD.ReadAll().GroupBy(i => i.Reviewer).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).ToList();
            return ids;
        }

        public List<int> GetMoviesWithHighestNumberOfTopRates()
        {
            var ids = new List<int>();
            var topMovies = _DataCRUD.ReadAll().ToList().FindAll(x => x.Grade == 5).OrderBy(x => x.Movie).ToList();
            topMovies.ForEach(x => ids.Add(x.Movie));
            return ids;
        }

        public int GetNumberOfRates(int movie, int rate)
        {
            return _DataCRUD.ReadAll().ToList().FindAll(x => x.Movie == movie && x.Grade == rate).Count;
        }

        public int GetNumberOfRatesByReviewer(int reviewer, int rate)
        {
            return _DataCRUD.ReadAll().ToList().FindAll(x => x.Reviewer == reviewer && x.Grade == rate).Count;
        }

        public int GetNumberOfReviews(int movie)
        {
            return _DataCRUD.ReadAll().ToList().FindAll(x => x.Movie == movie).Count;
        }

        public int GetNumberOfReviewsFromReviewer(int reviewer)
        {
            return _DataCRUD.ReadAll().ToList().FindAll(x => x.Reviewer == reviewer).Count;
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
