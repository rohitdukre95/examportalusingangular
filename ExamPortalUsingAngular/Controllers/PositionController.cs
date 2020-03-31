using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamPortalAngular.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamPortalAngular.Controllers
{
    [Route("api/Position")]
    public class PositionController : Controller
    {
        private IPositionRepository positionRepository;

        public PositionController(IPositionRepository positionRepository)
        {
            this.positionRepository = positionRepository;
        }
        // GET: api/<controller>
        [HttpGet]
        public ActionResult GetAll()
        {
            var positionList=positionRepository.GetAllPositions();
            return Json(new { success = positionList });
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
