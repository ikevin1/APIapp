using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp1
{
    public class Constants

    {
        public static string BaseAddress = "https://gateway.marvel.com:443/v1/public/v1/public/characters?id=";
       // public static string QuizCharacter = BaseAddress + "/characters/";
        public static string QuizCharacterKey = "&apikey=be2180fe24ce8aaaeec5c87bb16ca7a814bca28a&ts=315&hash=a1450e77320da5ee80ec54c7d2e7240a";
    }
    public interface IConstService
    {
        string CreateConst(string characterAPI);
    }
}
