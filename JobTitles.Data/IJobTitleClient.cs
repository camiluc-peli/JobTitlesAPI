using JobTitles.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobTitles.Data
{
    public interface IJobTitleClient
    {
        Task<List<JobTitle>> GetAllAsync();
        Task<JobTitle> GetAsync(int id);
        Task<JobTitle> GetAsync(string name);
        void InsertAsync(string jobTitle);
        void UpdateAsync(int id, string jobTitle);
        void UpdateAsync(string name, string jobTitle);
        void DeleteAsync(int id);
        void DeleteAsync(string name);
    }
}
