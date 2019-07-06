using JobTitles.Data;
using JobTitles.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobTitles.Business.Services
{
    public class JobTitleService
    {
        private static IJobTitleClient _client;

        JobTitleService(IJobTitleClient client)
        {
            _client = client;
        }
        /// <summary>
        /// Finds all the existing Job Titles.
        /// </summary>
        /// <returns>A list of Job Titles.</returns>
        public async Task<IEnumerable<JobTitle>> GetAllAsync()
        {
            return await _client.GetAllAsync();
        }

        /// <summary>
        /// Finds one Job Title by the given Id.
        /// </summary>
        /// <param name="id">The id of the Job Title.</param>
        /// <returns>A Job Title.</returns>
        public async Task<JobTitle> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds one Job Title by the given name.
        /// </summary>
        /// <param name="name">The name of the Job Title.</param>
        /// <returns>A Job Title.</returns>
        public async Task<JobTitle> GetAsync(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new Job Title with the given information.
        /// </summary>
        /// <param name="jobTitle">JSON with the Job Title's information.</param>
        public async void InsertAsync(string jobTitle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the given Job Title.
        /// </summary>
        /// <param name="id">The Id of the Job Title.</param>
        /// <param name="jobTitle">JSON with the new data to save.</param>
        public async void UpdateAsync(int id, string jobTitle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the given Job Title.
        /// </summary>
        /// <param name="name">The Name of the Job Title.</param>
        /// <param name="jobTitle">JSON with the new data to save.</param>
        public async void UpdateAsync(string name, string jobTitle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the given Job Title.
        /// </summary>
        /// <param name="id">The id of the given Job Title.</param>
        public async void DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the given Job Title.
        /// </summary>
        /// <param name="name">The name of the given Job Title.</param>
        public async void DeleteAsync(string name)
        {
            throw new NotImplementedException();
        }

    }
}
