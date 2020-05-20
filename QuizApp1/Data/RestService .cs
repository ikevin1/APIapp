using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuizApp1.Models;

namespace QuizApp1.Data
{
    public class RestService : IRestService
    {
        HttpClient _client;
        private IConstService _constService;

        public string QuizID { get; }
        public QuizData quizData { get; set; }

        //const string _API_PRIVATE_KEY = "be2180fe24ce8aaaeec5c87bb16ca7a814bca28a";

        //const string _API_PUBLIC_KEY  = "a1450e77320da5ee80ec54c7d2e7240a";

        //public RestService(int QuizData.ID)
        public RestService(IConstService constService)
        {
            _client = new HttpClient();
            _constService = constService;
            //QuizID = quizID;
        }

        public async Task<QuizData> RefreshDataAsync(int characterAPI)
        {
            quizData = new QuizData();

            var ts = Guid.NewGuid().ToString();
            Debug.WriteLine(ts);
            IConstService tempHash = _constService;

            //var consta = _constService.CreateConst(ts + _API_PRIVATE_KEY + _API_PUBLIC_KEY);

            var uri = new Uri(string.Format(Constants.BaseAddress + QuizID + Constants.QuizCharacterKey, string.Empty));
            
          
            try
            {
                //for (int i = 0; i < 30; i++)
                {
                    var response = await _client.GetAsync(uri);
                    //Debug.WriteLine("XXXX: " + response.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        // Debug.WriteLine(content);
                        QuizData quizData = JsonConvert.DeserializeObject<QuizData>(content);
                        //Debug.WriteLine(quizData);
                        //Character.Add(quizData);
                    }
                   
                }
              
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return quizData;
        }

        //public Task SaveTodoCatFactAsync(QuizData item, bool isNewItem)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task DeleteCatFactAsync(string id)
        //{
        //    throw new NotImplementedException();
        //}




        //      Task<List<CatFact>> IRestService.RefreshDataAsync()
        //      {
        //          throw new NotImplementedException();
        //      }

    }
}
