using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List <Song> FavoriteSongs { get; set; }

        public Person(string first,string last,int age,Genre favoriteMusic)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            FavoriteMusicType = favoriteMusic;
        }
        
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void GetFavSongs()
        {
            if (FavoriteSongs.Count > 0)
            {
                Console.WriteLine($"{GetFullName()} likes these songs:");

                foreach (var song in FavoriteSongs)
                {
                    Console.WriteLine($"{song.Title}");
                }
            }
            else
            {
                Console.WriteLine($"{GetFullName()} does not have favorite songs");
            }
            
        }
    }
}
