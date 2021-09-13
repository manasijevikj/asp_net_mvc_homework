﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.PizzaApp.ViewModels.FeedbackViewModels
{
    public class FeedbackDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Customer")]
        public string Email { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
