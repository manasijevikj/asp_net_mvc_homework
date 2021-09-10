using SEDC.PizzaApp.ViewModels.FeedbackViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Interfaces
{
    public interface IFeedbackService
    {
        List<FeedbackViewModel> GetAllFeedbacks();
        FeedbackDetailsViewModel GetFeedbackDetails(int id);
        void CreateFeedback(FeedbackViewModel feedbackViewModel);
        void DeleteFeedback(int id);
        void UpdateFeedback(FeedbackViewModel feedbackViewModel);
        FeedbackViewModel GetFeedbackForEditing(int id);
    }
}
