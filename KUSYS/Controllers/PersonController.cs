using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestProje.Core.Models;
using TestProje.Core.Services;

namespace TestProje.API.Controllers
{
    /// <summary>
    /// person için repository oluşturmadık Iservices üzerinden işlemleri yapıyor... dto oluşturmadık gerekirse oluşturulabilir
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly IService<Person> _personservice;
        public PersonController(IService<Person>service)
        {
            _personservice = service;
        }

        [HttpGet]
        public async Task<IActionResult>GetAll()
        {
            var person = await _personservice.GetAllAsync();
            return Ok(person);

        }


        [HttpPost]  
        public async Task<IActionResult>Save(Person person)
        {
            var saveperson = await _personservice.AddAsync(person);
            return Ok(saveperson);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var person = await _personservice.GetByIdAsync(id);
            return Ok(person);
        }

    }
}
