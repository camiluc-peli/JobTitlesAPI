using JobTitles.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobTitles.Business.Services
{
    public class JobTitleService
    {
        /// <summary>
        /// Finds all the existing Job Titles.
        /// </summary>
        /// <returns>A list of Job Titles.</returns>
        public async Task<IEnumerable<JobTitle>> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds one Job Title by the given Id.
        /// </summary>
        /// <param name="id">The id of the Job Title.</param>
        /// <returns>A Job Title.</returns>
        public async Task<JobTitle> Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds one Job Title by the given name.
        /// </summary>
        /// <param name="name">The name of the Job Title.</param>
        /// <returns>A Job Title.</returns>
        public async Task<JobTitle> Get(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new Job Title with the given information.
        /// </summary>
        /// <param name="jobTitle">JSON with the Job Title's information.</param>
        public async void Insert(string jobTitle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the given Job Title.
        /// </summary>
        /// <param name="id">The Id of the Job Title.</param>
        /// <param name="jobTitle">JSON with the new data to save.</param>
        public async void Update(int id, string jobTitle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the given Job Title.
        /// </summary>
        /// <param name="name">The Name of the Job Title.</param>
        /// <param name="jobTitle">JSON with the new data to save.</param>
        public async void Update(string name, string jobTitle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the given Job Title.
        /// </summary>
        /// <param name="id">The id of the given Job Title.</param>
        public async void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the given Job Title.
        /// </summary>
        /// <param name="name">The name of the given Job Title.</param>
        public async void Delete(string name)
        {
            throw new NotImplementedException();
        }

    }
}
