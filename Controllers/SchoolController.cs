using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMap.Data;
using WebMap.Models.Dto;
using WebMap.Models.Entities;
using AutoMapper; // Add this

namespace WebMap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly SchoolDbContext dbContext;
        private readonly IMapper mapper; // Add this

        public SchoolController(SchoolDbContext dbContext, IMapper mapper) // Add IMapper to constructor
        {
            this.dbContext = dbContext;
            this.mapper = mapper; // Assign it
        }

        [HttpGet]
        public IActionResult Get()
        {
            var a = dbContext.SchoolDetails;
            return Ok(a);
        }

        [HttpPost]
        public IActionResult Post(SchooDto abc)
        {
            // Use AutoMapper to map SchooDto to School
            var scl = mapper.Map<School>(abc);
            dbContext.SchoolDetails.Add(scl);
            dbContext.SaveChanges();

            return Ok(scl);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var user = dbContext.SchoolDetails.FirstOrDefault(s => s.Id == id);
            dbContext.Remove(user);
            dbContext.SaveChanges();
            return Ok(user);
        }
    }
}