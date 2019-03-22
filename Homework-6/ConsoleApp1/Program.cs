using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Fans = new List<Person>();

            Person Jerry = new Person("Jerry", "Geler", 36, Genre.Rock);
            Person Maria = new Person("Maria", "Peterson", 25, Genre.Techno);
            Person Jane = new Person("Jane", "Macarey", 22, Genre.Hip_Hop);
            Person Stefan = new Person("Stefan", "Simeski", 41, Genre.Classical);

            Fans.Add(Jerry);
            Fans.Add(Stefan);
            Fans.Add(Maria);
            Fans.Add(Jane);

            Song song1 = new Song("Beautiful", 253, Genre.Hip_Hop);
            Song song2 = new Song("The Four Seasons", 2520, Genre.Classical);
            Song song3 = new Song("Everlong", 250, Genre.Rock);
            Song song4 = new Song("Hypnotize", 170, Genre.Hip_Hop);
            Song song5 = new Song("Beautiful world", 179, Genre.Rock);
            Song song6 = new Song("Vision", 693, Genre.Techno);
            Song song7 = new Song("Requiem for a dream", 2520, Genre.Classical);
            Song song8 = new Song("Beatiful Day", 267, Genre.Rock);
            Song song9 = new Song("Birds", 390, Genre.Rock);
            Song song10 = new Song("Changes", 300, Genre.Hip_Hop);

            List<Song> Songs = new List<Song>()
            { song1, song2, song3, song4, song5, song6, song7, song8, song9, song10 };


            Jerry.FavoriteSongs = Songs.Where(x => x.Title.StartsWith("B")).ToList();
            Jerry.GetFavSongs();
            Console.WriteLine();


            Maria.FavoriteSongs = Songs.Where(song => song.Length >= 360).ToList();
            Maria.GetFavSongs();

            Console.WriteLine();
            Jane.FavoriteSongs = Songs.Where(song => song.Genre == Genre.Rock).ToList();
            Jane.GetFavSongs();

            Console.WriteLine();
            Stefan.FavoriteSongs = (Songs.Where(song => song.Length < 180 && song.Genre == Genre.Hip_Hop)).ToList();
            Stefan.GetFavSongs();

            Console.WriteLine();
            var peopleWithFourOrMoreSongs = Fans.Where(fan => fan.FavoriteSongs.Count >= 4).ToList();
            Console.WriteLine("People that have 4 or more favorite songs are:");
            foreach (Person person in peopleWithFourOrMoreSongs)
            {
                Console.WriteLine(person.GetFullName());
            }














        }
    }
}
