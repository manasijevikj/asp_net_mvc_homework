using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.Shared.CustomExceptions;
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Refactored.Controllers
{
    public class FeedbackController : Controller
    {
        private IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        public IActionResult Index()
        {
            List<FeedbackViewModel> feedbackListViewModels = _feedbackService.GetAllFeedbacks();
            return View(feedbackListViewModels);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            try
            {
                FeedbackDetailsViewModel feedbackDetailsViewModel = _feedbackService.GetFeedbackDetails(id.Value);
                return View(feedbackDetailsViewModel);
            }
            catch (Exception e)
            {
                //log
                return View("ExceptionPage");
            }
        }

        public IActionResult Create()
        {
            FeedbackViewModel feedbackViewModel = new FeedbackViewModel();
            List<FeedbackViewModel> feedbacks = _feedbackService.GetAllFeedbacks();
            IEnumerable<string> emails = feedbacks.Select(x => x.Email);
            ViewBag.emails = emails;
            return View(feedbackViewModel);
        }

        [HttpPost]
        public IActionResult Create(FeedbackViewModel feedbackViewModel)
        {
            try
            {
                _feedbackService.CreateFeedback(feedbackViewModel);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");
            }
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            try
            {
                FeedbackViewModel feedbackViewModel = _feedbackService.GetFeedbackForEditing(id.Value);
                return View(feedbackViewModel);
            }
            catch (ResourceNotFoundException e)
            {
                return View("ResourceNotFound");
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }
        [HttpPost]
        public IActionResult Edit(FeedbackViewModel feedbackViewModel)
        {
            try
            {
                _feedbackService.UpdateFeedback(feedbackViewModel);
                return RedirectToAction("Index");
            }

            catch (ResourceNotFoundException e)
            {
                return View("ResourceNotFound");
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");
            }
        }




        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            try
            {
                FeedbackDetailsViewModel feedbackDetailsViewModel = _feedbackService.GetFeedbackDetails(id.Value);
                return View(feedbackDetailsViewModel);
            }
            catch (ResourceNotFoundException e)
            {
                return View("ResourceNotFound");
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }
        [HttpPost]
        public IActionResult Delete(FeedbackViewModel feedbackDetailsViewModel)
        {
            try
            {
                _feedbackService.DeleteFeedback(feedbackDetailsViewModel.Id);
                return RedirectToAction("Index");
            }
            catch (ResourceNotFoundException e)
            {
                return View("ResourceNotFound");
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }
    }
}

