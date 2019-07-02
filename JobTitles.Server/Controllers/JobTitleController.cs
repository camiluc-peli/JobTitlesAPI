using JobTitles.Business.Services;
using JobTitles.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobTitles.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTitleController : ControllerBase
    {
        private JobTitleService _service;

        public JobTitleController(JobTitleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<JobTitle>> Get()
        {
            return await _service.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<JobTitle> Get(int id)
        {
            return await _service.Get(id);
        }

        [HttpGet("{name}")]
        public async Task<JobTitle> Get(string name)
        {
            return await _service.Get(name);
        }

        [HttpPost]
        public async void Post([FromBody] string jobTitle)
        {
            _service.Insert(jobTitle);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _service.Update(id, value);
        }

        [HttpPut("{name}")]
        public void Put(string name, [FromBody] string value)
        {
            _service.Update(name, value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }

        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            _service.Delete(name);
        }
    }
}
