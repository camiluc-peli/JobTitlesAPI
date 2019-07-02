using JobTitles.Business.Services;
using JobTitles.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobTitles.Server.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class JobTitleController : ControllerBase
    {
        private JobTitleService _service;

        public JobTitleController(JobTitleService service)
        {
            _service = service;
        }

        /// <summary>
        /// Provides a JSON with all the Job Titles.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<JobTitle>> Get()
        {
            return await _service.GetAll();
        }

        /// <summary>
        /// Provides the the information of a Job Title.
        /// </summary>
        /// <param name="id">Id of the wanted Job Title.</param>
        /// <returns>JSON with the Job Title's data.</returns>
        [HttpGet("{id}")]
        public async Task<JobTitle> Get(int id)
        {
            return await _service.Get(id);
        }

        /// <summary>
        /// Provides the the information of a Job Title.
        /// </summary>
        /// <param name="name">Name of the wanted Job Title.</param>
        /// <returns>JSON with the Job Title's data.</returns>
        [HttpGet("{name}")]
        public async Task<JobTitle> Get(string name)
        {
            return await _service.Get(name);
        }

        /// <summary>
        /// Inserts a new Job Title with the given data.
        /// </summary>
        /// <param name="jobTitle">JSON with the data to insert.</param>
        [HttpPost]
        public async void Post([FromBody] string jobTitle)
        {
            _service.Insert(jobTitle);
        }

        /// <summary>
        /// Updates the given Job Title.
        /// </summary>
        /// <param name="id">The id of the Job Title to update.</param>
        /// <param name="value">The new data to update.</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _service.Update(id, value);
        }

        /// <summary>
        /// Updates the given Job Title.
        /// </summary>
        /// <param name="name">The name og the Job Title to update.</param>
        /// <param name="value">The new data to update.</param>
        [HttpPut("{name}")]
        public void Put(string name, [FromBody] string value)
        {
            _service.Update(name, value);
        }

        /// <summary>
        /// Deletes the given Job Title.
        /// </summary>
        /// <param name="id">The id of the Job Title to delete.</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }

        /// <summary>
        /// Deletes the given Job Title.
        /// </summary>
        /// <param name="name">The name of the Job Title to delete.</param>
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            _service.Delete(name);
        }
    }
}
