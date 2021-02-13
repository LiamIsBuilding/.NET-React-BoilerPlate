using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;


namespace _NET_React_Boiler.Controllers
{
    //[controller]s
    [ApiController]
    [Route("route")]

    public class Controller : ControllerBase
    {
        private readonly IRepository<//class> _//repository;

        public Controller(IRepository<//class> //repository)
        {
            //_repository(private) = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() // name whatever you want
        {
            try
            {
                var allTils = await //_privateRepository.GetAll();
                return Ok(allTils);
            }
            catch (Exception)
            {
                return BadRequest();
            }


        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var singleTils = await //_repository(private).GetOne(id);
                return Ok(singleTils);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] //classType //lcClass)
        {
            try
            {
                var newTil = await //_repository(private).Insert(todayILearned);
                return Ok(newTil);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task DeleteTodayILearned(int id)
        {
            try
            {
                await //_repository(private).Delete(id);

            }
            catch (Exception)
            {
                NotFound($"No  with id {id}");
            }
        }


    }
}