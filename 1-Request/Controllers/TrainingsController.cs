using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _1_Request.Core;
using _1_Request.Models;
using _1_Request.Repository;

namespace _1_Request.Controllers
{
    [RoutePrefix("Trainings")]
    public class TrainingsController : ApiController
    {
        private readonly ITrainingRepository _trainingRepository;

        public TrainingsController(ITrainingRepository trainingRepository)
        {
            _trainingRepository = trainingRepository;
        }

        [Route("")]
        [HttpGet]
        public List<Training> GetTrainings([FromUri]TrainingFilter filter)
        {
            return _trainingRepository.GetTrainings(filter);
        }

        [HttpGet]
        [Route("{id:int}")]
        [ValidateFilter]
        public Training GetTraining(int? id)
        {
            if (id > 100)
            {
                throw new ValidationException("Id can't be greater than 100");
            }
            if (id > 90 && id < 99)
            {
                throw new Exception();
            }
            return _trainingRepository.GetTraining(id);
        }

        [HttpPost]
        [Route("{id:int}")]
        public IHttpActionResult AddTraining(int? id, [FromBody]Training training)
        {
            return BadRequest("Please use /trainings and pass one or more than one trainings in the request body");
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult AddTrainings([FromBody] List<Training> trainings)
        {
            if (trainings == null || trainings.Count == 0)
            {
                return BadRequest();
            }
            var trainingIds = _trainingRepository.AddTrainings(trainings);
            if (trainingIds == null || trainingIds.Count == 0)
            {
                return NotFound();
            }
            if (trainingIds.Count == 1)
            {
                return Created(Request.RequestUri + "/" + trainingIds[0], trainings);
            }
            return Created(Request.RequestUri, trainingIds);
        }
    }
}
