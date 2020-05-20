using QuizApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp1.Data
{
    public interface IRestService
    {
        Task<QuizData> RefreshDataAsync(int characterAPI);

        //Task SaveTodoCatFactAsync(QuizData item, bool isNewItem);

        //Task DeleteCatFactAsync(string id);
    }
}
//