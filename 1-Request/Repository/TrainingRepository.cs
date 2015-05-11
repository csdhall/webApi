using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using _1_Request.Controllers;
using _1_Request.Models;

namespace _1_Request.Repository
{
    public class TrainingRepository : ITrainingRepository
    {
        public Training GetTraining(int? id)
        {
            //Demo Purpose only. Technically you should make a call to the database and grab the only id
            return Trainings.FirstOrDefault(x => x.Id == id);
        }

        public List<Training> GetTrainings(TrainingFilter filter)
        {
            if (filter == null)
            {
                return Trainings;
            }

            //Not Good Code. Just for Demo. You will need to handle all cases here. 
            return Trainings.Where(x => String.Equals(x.City, filter.City, StringComparison.CurrentCultureIgnoreCase)
                                  || (x.Country != null && (String.Equals(x.Country, filter.Country, StringComparison.CurrentCultureIgnoreCase)))
                                  || (x.Country != null && (String.Equals(x.Country, filter.Country, StringComparison.CurrentCultureIgnoreCase)))
                                  || (x.Zip != null && (String.Equals(x.Zip, filter.Zip, StringComparison.CurrentCultureIgnoreCase)))).ToList();

        }

        public List<int> AddTrainings(List<Training> trainings)
        {
            Trainings.AddRange(trainings);
            int count = Trainings.Count;
           
            //Faking database logic
            foreach (var training in trainings)
            {
                training.Id = ++count;
            }
            return trainings.Select(x => x.Id).ToList();
        }

        public static List<Training> Trainings = new List<Training>
            {
                new Training
                {
                    Id = 1,
                    Title = "Training 1",
                    Description = "Web API Best Practices",
                    City = "London",
                    Country = "UK",
                    Zip = "9011"
                },
                new Training
                { 
                    Id = 2,
                    Title = "Training 2",
                    Description = "Best Practices on Scaling Web Apps",
                    City = "London",
                    Country = "UK",
                    Zip = "9011"
                },
                 new Training
                {
                    Id = 3,
                    Title = "Training 3",
                    Description = "MVC Best Practices",
                    City = "London",
                    Country = "UK",
                    Zip = "9011"
                },
                new Training
                { 
                    Id = 4,
                    Title = "Training 4",
                    Description = ".NET Best Practices",
                    City = "London",
                    Country = "UK",
                    Zip = "9011"
                },
                 new Training
                {
                    Id = 5,
                    Title = "Training 5",
                    Description = "No-Sql Best Practices",
                    City = "London",
                    Country = "UK",
                    Zip = "9011"
                },
                new Training
                { 
                    Id = 6,
                    Title = "Training 6",
                    Description = "Azure Best Practices",
                    City = "London",
                    Country = "UK",
                    Zip = "9011"
                }
                ,
                 new Training
                {
                    Id = 7,
                    Title = "Training 7",
                    Description = "ASP.NET Best Practices",
                    City = "London",
                    Country = "UK",
                    Zip = "9011"
                },
                new Training
                { 
                    Id = 8,
                    Title = "Training 8",
                    Description = "SignalR Best Practices",
                    City = "London",
                    Country = "UK",
                    Zip = "9011"
                },
                 new Training
                {
                    Id = 9,
                    Title = "Training 9",
                    Description = "Node.js Best Practices",
                    City = "London",
                    Country = "UK",
                    Zip = "9011"
                },
                new Training
                { 
                    Id = 10,
                    Title = "Training 10",
                    Description = "Socket.IO Best Practices",
                    City = "London",
                    Country = "UK",
                    Zip = "9011"
                },
                 new Training
                {
                    Id = 11,
                    Title = "Training 11",
                    Description = "Web API Best Practices",
                   City = "Austin",
                    Country = "US",
                    Zip = "75080"
                },
                new Training
                { 
                    Id = 12,
                    Title = "Training 12",
                    Description = "Best Practices on Scaling Web Apps",
                   City = "Austin",
                    Country = "US",
                    Zip = "75080"
                },
                 new Training
                {
                    Id = 13,
                    Title = "Training 13",
                    Description = "Azure Best Practices",
              City = "Austin",
                    Country = "US",
                    Zip = "75080"
                },
                new Training
                { 
                    Id = 14,
                    Title = "Training 15",
                    Description = "ASP.NET Best Practices",
                   City = "Austin",
                    Country = "US",
                    Zip = "75080"
                },
                 new Training
                {
                    Id = 16,
                    Title = "Training 16",
                    Description = "SignalR Best Practices",
             City = "Austin",
                    Country = "US",
                    Zip = "75080"
                },
                new Training
                { 
                    Id = 17,
                    Title = "Training 17",
                    Description = ".NET Best Practices",
                 City = "Austin",
                    Country = "US",
                    Zip = "75080"
                },
                new Training
                {
                    Id = 18,
                    Title = "Training 18",
                    Description = "MVC Best Practices",
                   City = "Austin",
                    Country = "US",
                    Zip = "75080"
                },
                new Training
                { 
                    Id = 19,
                    Title = "Training 19",
                    Description = "Azure Best Practices",
                  City = "Austin",
                    Country = "US",
                    Zip = "75080"
                },
                new Training
                { 
                    Id = 20,
                    Title = "Training 20",
                    Description = "Socket.IO Best Practices",
                    City = "Austin",
                    Country = "US",
                    Zip = "75080"
                }

            };
    }
}