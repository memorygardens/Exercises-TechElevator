﻿using Post.Web.Models;
using System.Collections.Generic;

namespace Post.Web.DAL
{
    public interface IReviewDAO
    {
        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        List<Review> GetAllReviews();

        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
        int SaveReview(Review newReview);
    }
}