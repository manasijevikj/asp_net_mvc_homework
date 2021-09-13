using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Mappers
{
    public static class FeedbackMapper
    {
        public static FeedbackViewModel FeedbackToFeedbackViewModel(this Feedback feedback)
        {
            return new FeedbackViewModel
            {
                Id = feedback.Id,
                Name = feedback.Name,
                Email = feedback.Email,
                Message = feedback.Message
            };
        }


        public static FeedbackDetailsViewModel FeedbackToFeedbackDetailsViewModel(this Feedback feedback)
        {
            return new FeedbackDetailsViewModel
            {
                Id = feedback.Id,
                Name = feedback.Name,
                Message = feedback.Message
            };
        }

        

        public static Feedback ToFeedback(this FeedbackViewModel feedbackViewModel)
        {
            return new Feedback
            {
                Id = feedbackViewModel.Id,
                Name = feedbackViewModel.Name,
                Email = feedbackViewModel.Email,
                Message = feedbackViewModel.Message
            };
        }


    }
}
