using QuizApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp1.Data
{
    public class QuizDataManager
    {
        IRestService restService;
        public QuizDataManager(IRestService service)
        {
            restService = service;
        }

        public Task<QuizData> GetTasksAsync(int id)
        {
            return restService.RefreshDataAsync(id);
        }
    }
}
