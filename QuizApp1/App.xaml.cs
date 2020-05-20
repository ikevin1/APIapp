using QuizApp1.Data;
using QuizApp1.Models;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuizApp1
{
    public partial class App : Application
    {
        public static QuizDataManager QM { get; set; }
        public App()
        {
            var constService = DependencyService.Get<IConstService>();
            InitializeComponent();
            QM = new QuizDataManager(new RestService(constService));

            MainPage = new MainPage();
            //InitializeComponent();
            //QM = new QuizDataManager();
            //MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        //Task<QuizData> GetTasksAsync(string characterAPI)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
