using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Implementations
{
    public class FeedbackRepository : IRepository<Feedback>
    {
        public void DeleteById(int id)
        {
            Feedback feedbackDb = StaticDb.Feedbacks.FirstOrDefault(x => x.Id == id);
            StaticDb.Feedbacks.Remove(feedbackDb);
        }

        public List<Feedback> GetAll()
        {
            return StaticDb.Feedbacks;
        }

        public Feedback GetById(int id)
        {
            return StaticDb.Feedbacks.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Feedback entity)
        {
            entity.Id = ++StaticDb.FeedbackId;
            StaticDb.Feedbacks.Add(entity);
            return entity.Id;
        }

        public void Update(Feedback entity)
        {
            Feedback feedbackDb = StaticDb.Feedbacks.FirstOrDefault(x => x.Id == entity.Id);
            if (feedbackDb == null)
            {
                throw new Exception($"Pizza with id {entity.Id} was not found");
            }
            int index = StaticDb.Feedbacks.IndexOf(feedbackDb);
            StaticDb.Feedbacks[index] = entity;
        }
    }
}
