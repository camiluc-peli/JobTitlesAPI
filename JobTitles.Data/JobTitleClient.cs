using JobTitles.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JobTitles.Data
{
    public class JobTitleClient : IJobTitleClient
    {
        private static HttpClient client = new HttpClient();
        JobTitleClient()
        {
            var byteArray = Encoding.ASCII.GetBytes("hhkgBYNxYd0HIaLwhpzucEkmLr%2fHbDOZ6HkmDvFvjGFG1nnMgmnAcw%3d%3d:");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
                    "Basic",
                    Convert.ToBase64String(byteArray)
                    );
        }

        public async void DeleteAsync(int id)
        {
            throw new NotImplementedException();


            var url = "https:// app-dev.woffu.com/api/v1/jobtitles";
            var response = await client.GetAsync(url);
            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }
        }

        public async void DeleteAsync(string name)
        {
            throw new NotImplementedException();


            var url = "https:// app-dev.woffu.com/api/v1/jobtitles";
            var response = await client.GetAsync(url);
            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }
        }

        public async Task<List<JobTitle>> GetAllAsync()
        {
            var url = "https:// app-dev.woffu.com/api/v1/jobtitles";
            var response = await client.GetAsync(url);
            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            var hola = json;

            return JsonConvert.DeserializeObject<List<JobTitle>>(json);
        }

        public async Task<JobTitle> GetAsync(int id)
        {
            throw new NotImplementedException();



            var url = "https:// app-dev.woffu.com/api/v1/jobtitles";
            var response = await client.GetAsync(url);
            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<JobTitle>(json);
        }

        public async Task<JobTitle> GetAsync(string name)
        {
            throw new NotImplementedException();



            var url = "https:// app-dev.woffu.com/api/v1/jobtitles";
            var response = await client.GetAsync(url);
            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<JobTitle>(json);
        }

        public async void InsertAsync(string jobTitle)
        {
            throw new NotImplementedException();



            var url = "https:// app-dev.woffu.com/api/v1/jobtitles";
            var response = await client.GetAsync(url);
            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

        }

        public async void UpdateAsync(int id, string jobTitle)
        {
            throw new NotImplementedException();



            var url = "https:// app-dev.woffu.com/api/v1/jobtitles";
            var response = await client.GetAsync(url);
            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            
        }

        public async void UpdateAsync(string name, string jobTitle)
        {
            throw new NotImplementedException();



            var url = "https:// app-dev.woffu.com/api/v1/jobtitles";
            var response = await client.GetAsync(url);
            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }
        }
    }
}
