using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp1
{
    public class Characters
    {
        public string Name { get; set; }
        public int CharacterAPI { get; set; }
        public int Points { get; set; }       

        public static IList<Characters> All { get; set; }

        public Characters()
        {

        }

        public Characters(string name, int characterAPI, int points)
        {
            Name = name;            
            CharacterAPI = characterAPI;
            Points = points;
        }

        static Characters()
        {
            List<Characters> all = new List<Characters>
            {
                new Characters("SpiderMan", 1009610, 1),
                new Characters("Iron Man", 1009368, 1),
                new Characters("Mysterio", 1009464, 1),
                new Characters("Star-Lord", 1010733, 1)
            };

            All = all;
        }
    }
}
