using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.Shared.CustomExceptions;
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class FeedbackService : IFeedbackService
    {
        private IRepository<Feedback> _feedbackRepository;

        public FeedbackService(IRepository<Feedback> feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }


        public List<FeedbackViewModel> GetAllFeedbacks()
        {
            List<Feedback> dbFeedbacks = _feedbackRepository.GetAll();

            return dbFeedbacks.Select(x => FeedbackMapper.FeedbackToFeedbackViewModel(x)).ToList();
        }

        public FeedbackDetailsViewModel GetFeedbackDetails(int id)
        {
            Feedback feedbackDb = _feedbackRepository.GetById(id);
            if (feedbackDb == null)
            {
                //log
                throw new Exception($"The feedback with id {id} was not found!");
            }
            return feedbackDb.FeedbackToFeedbackDetailsViewModel();
        }

        public void CreateFeedback(FeedbackViewModel feedbackViewModel)
        {
            List<Feedback> feedbacks = _feedbackRepository.GetAll().Where(x => x.Email == (feedbackViewModel.ToFeedback()).Email).ToList();
            if (feedbacks.Count == 3)
            {
                throw new Exception("You have already posted three reviews");
            }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(feedbackViewModel.Email);
            if (!match.Success)
            {
                throw new Exception("Email isn't in a correct form");
            }

            Feedback feedbackDb = feedbackViewModel.ToFeedback();
            _feedbackRepository.Insert(feedbackDb);
        }

        public void DeleteFeedback(int id)
        {
            //validations
            Feedback feedbackDb = _feedbackRepository.GetById(id);
            if (feedbackDb == null)
            {
                throw new ResourceNotFoundException($"The feedback with id {id} was not found!");
            }
            _feedbackRepository.DeleteById(id);
        }
       
        public void UpdateFeedback(FeedbackViewModel feedbackViewModel)
        {
            //validations
            Feedback feedbackDb = _feedbackRepository.GetById(feedbackViewModel.Id);
            if (feedbackDb == null)
            {
                throw new ResourceNotFoundException($"The Feedback with id {feedbackViewModel.Id} was not found!");
            }

            List<Feedback> feedbacks = _feedbackRepository.GetAll().Where(x => x.Email == (feedbackViewModel.ToFeedback()).Email).ToList();
            if (feedbacks.Count == 3)
            {
                throw new Exception("You have already posted three reviews");
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(feedbackViewModel.Email);
            if (!match.Success)
            {
                throw new Exception("Email isn't in a correct form");
            }
            //map to domain model

            Feedback editedFeedback = feedbackViewModel.ToFeedback();
            editedFeedback.Id = feedbackViewModel.Id; 

            //we send the edited domain model for update
            _feedbackRepository.Update(editedFeedback);
        }

        public FeedbackViewModel GetFeedbackForEditing(int id)
        {
            Feedback feedback = _feedbackRepository.GetById(id);
            if (feedback == null)
            {
                throw new Exception($"Feedback with id {id} was not found");
            }
            return feedback.FeedbackToFeedbackViewModel();
        }


    }
}
