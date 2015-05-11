using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _1_Request.Models;

namespace _1_Request.Repository
{
    public interface ITrainingRepository
    {
        Training GetTraining(int? id);
        List<Training> GetTrainings(TrainingFilter filter);
        List<int> AddTrainings(List<Training> trainings);
    }
}