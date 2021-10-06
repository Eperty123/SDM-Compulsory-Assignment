using Moq;
using SDM_Compulsory_Assignment.Core.Models;
using SDM_Compulsory_Assignment.Domain.IRepositories;
using SDM_Compulsory_Assignment.Domain.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace SDM_Compulsory_Assignment.Tests
{
    public class UnitTest1
    {
        //ReviewService reviewService = new ReviewService(new ReviewRepository());

        [Fact]
        public void TestNumberOfReviewsFromReviewer()
        {
            // arrange
            // act
            // assert
            //Mock<IReviewRepository> reviewMock = new Mock<IReviewRepository>();
            Mock<IDataCRUD> reviewMock = new Mock<IDataCRUD>();
            var reviewService = new ReviewService(reviewMock.Object);

            var test = new List<Review>()
            {
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 5, Grade = 4, Movie = 666, ReviewDate = DateTime.Now}
            };
            reviewMock.Setup(m => m.ReadAll()).Returns(() => test);

            //act
            int actualResult = reviewService.GetNumberOfReviewsFromReviewer(5);
            reviewMock.Verify(x => x.ReadAll(), Times.Once);
            var expectedResult = 1;
            Assert.Equal(expectedResult, actualResult);
        }

        //[Fact(Skip ="bla")]
        [Fact]
        public void TestGetAvarageRatingFromReviewer()
        {
            Mock<IDataCRUD> reviewMock = new Mock<IDataCRUD>();
            var reviewService = new ReviewService(reviewMock.Object);

            var test = new List<Review>()
            {
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 6, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 8, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 9, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 5, Grade = 4, Movie = 666, ReviewDate = DateTime.Now}
            };
            reviewMock.Setup(m => m.ReadAll()).Returns(() => test);

            //act
            double actualResult = reviewService.GetAverageRateFromReviewer(2);
            reviewMock.Verify(x => x.ReadAll(), Times.Once);
            var expectedResult = 5.375;
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestGetNumberOfRatesFromReviewer()
        {
            Mock<IDataCRUD> reviewMock = new Mock<IDataCRUD>();
            var reviewService = new ReviewService(reviewMock.Object);

            var test = new List<Review>()
            {
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 6, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 8, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 9, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 5, Grade = 4, Movie = 666, ReviewDate = DateTime.Now}
            };
            reviewMock.Setup(m => m.ReadAll()).Returns(() => test);

            //act
            double actualResult = reviewService.GetNumberOfRatesByReviewer(2, 4);
            reviewMock.Verify(x => x.ReadAll(), Times.Once);
            var expectedResult = 5;
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestGetNumberOfReviews()
        {
            Mock<IDataCRUD> reviewMock = new Mock<IDataCRUD>();
            var reviewService = new ReviewService(reviewMock.Object);

            var test = new List<Review>()
            {
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 4, Movie = 3, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 6, Movie = 4, ReviewDate = DateTime.Now},
            };
            reviewMock.Setup(m => m.ReadAll()).Returns(() => test);

            //act
            double actualResult = reviewService.GetNumberOfReviews(666);
            reviewMock.Verify(x => x.ReadAll(), Times.Once);
            var expectedResult = 1;
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void TestGetNumberOfRates()
        {
            Mock<IDataCRUD> reviewMock = new Mock<IDataCRUD>();
            var reviewService = new ReviewService(reviewMock.Object);

            var test = new List<Review>()
            {
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 4, Movie = 3, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 6, Movie = 4, ReviewDate = DateTime.Now},
            };
            reviewMock.Setup(m => m.ReadAll()).Returns(() => test);

            //act
            double actualResult = reviewService.GetNumberOfRates(666, 4);
            reviewMock.Verify(x => x.ReadAll(), Times.Once);
            var expectedResult = 1;
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestGetAverageRateOfMovie()
        {
            Mock<IDataCRUD> reviewMock = new Mock<IDataCRUD>();
            var reviewService = new ReviewService(reviewMock.Object);

            var test = new List<Review>()
            {
                new Review() {Reviewer = 2, Grade = 4, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 4, Movie = 3, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 6, Movie = 4, ReviewDate = DateTime.Now},
            };
            reviewMock.Setup(m => m.ReadAll()).Returns(() => test);

            //act
            double actualResult = reviewService.GetAverageRateOfMovie(666);
            reviewMock.Verify(x => x.ReadAll(), Times.Once);
            var expectedResult = 4;
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestGetMoviesWithHighestRatings()
        {
            Mock<IDataCRUD> reviewMock = new Mock<IDataCRUD>();
            var reviewService = new ReviewService(reviewMock.Object);

            var test = new List<Review>()
            {
                new Review() {Reviewer = 2, Grade = 5, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 5, Movie = 3, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 6, Movie = 4, ReviewDate = DateTime.Now},
            };
            reviewMock.Setup(m => m.ReadAll()).Returns(() => test);

            //act
            var actualResult = reviewService.GetMoviesWithHighestNumberOfTopRates().Count;
            reviewMock.Verify(x => x.ReadAll(), Times.Once);
            var expectedResult = 2;
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestGetMostProductiveReviewers()
        {
            Mock<IDataCRUD> reviewMock = new Mock<IDataCRUD>();
            var reviewService = new ReviewService(reviewMock.Object);

            var test = new List<Review>()
            {
                new Review() {Reviewer = 2, Grade = 5, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 5, Movie = 3, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 6, Movie = 4, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 1, Grade = 6, Movie = 4, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 1, Grade = 6, Movie = 4, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 15, Grade = 6, Movie = 4, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 18, Grade = 6, Movie = 4, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 16, Grade = 6, Movie = 4, ReviewDate = DateTime.Now},
            };
            reviewMock.Setup(m => m.ReadAll()).Returns(() => test);

            //act
            var actualResult = reviewService.GetMostProductiveReviewers().Count;
            reviewMock.Verify(x => x.ReadAll(), Times.Once);
            var expectedResult = 5;
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestGetTopRatedMovies()
        {
            Mock<IDataCRUD> reviewMock = new Mock<IDataCRUD>();
            var reviewService = new ReviewService(reviewMock.Object);

            var test = new List<Review>()
            {
                new Review() {Reviewer = 2, Grade = 5, Movie = 666, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 5, Movie = 3, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 4, Grade = 4, Movie = 1, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 4, Grade = 3, Movie = 1, ReviewDate = DateTime.Now},
            };
            reviewMock.Setup(m => m.ReadAll()).Returns(() => test);

            //act
            var actualResult = reviewService.GetTopRatedMovies(5).Count;
            reviewMock.Verify(x => x.ReadAll(), Times.AtLeastOnce);
            var expectedResult = 3;
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestGetTopMoviesByReviewer()
        {
            Mock<IDataCRUD> reviewMock = new Mock<IDataCRUD>();
            var reviewService = new ReviewService(reviewMock.Object);

            var test = new List<Review>()
            {
                new Review() {Reviewer = 2, Grade = 5, Movie = 3, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 5, Movie = 3, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 5, Movie = 1, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 5, Movie = 5, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 5, Movie = 2, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 1, Grade = 5, Movie = 2, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 1, Grade = 5, Movie = 2, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 1, Grade = 5, Movie = 6, ReviewDate = DateTime.Now},
                /*new Review() {Reviewer = 1, Grade = 4, Movie = 4, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 4, Grade = 3, Movie = 6, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 5, Grade = 1, Movie = 7, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 5, Grade = 0, Movie = 7, ReviewDate = DateTime.Now},*/
            };
            reviewMock.Setup(m => m.ReadAll()).Returns(() => test);

            //act
            var actualResult = reviewService.GetTopMoviesByReviewer(2).Count;
            reviewMock.Verify(x => x.ReadAll(), Times.AtLeastOnce);
            var expectedResult = 5;
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestGetReviewersByMovie()
        {
            Mock<IDataCRUD> reviewMock = new Mock<IDataCRUD>();
            var reviewService = new ReviewService(reviewMock.Object);

            var test = new List<Review>()
            {
                new Review() {Reviewer = 2, Grade = 5, Movie = 3, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 5, Movie = 3, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 2, Grade = 5, Movie = 2, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 1, Grade = 5, Movie = 2, ReviewDate = DateTime.Now},
                new Review() {Reviewer = 1, Grade = 5, Movie = 2, ReviewDate = DateTime.Now},
            };
            reviewMock.Setup(m => m.ReadAll()).Returns(() => test);

            //act
            var actualResult = reviewService.GetReviewersByMovie(2).Count;
            reviewMock.Verify(x => x.ReadAll(), Times.AtLeastOnce);
            var expectedResult = 3;
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
