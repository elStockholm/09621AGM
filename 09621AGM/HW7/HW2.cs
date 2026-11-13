using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW7
{
    //Список песен. В методе Main создать список из четырех песен. В цикле вывести информацию о каждой песне. Сравнить между собой первую и вторую
    //песню в списке.Песня представляет собой класс с методами для заполнения каждого из полей, методом вывода данных о песне на печать, методом, который сравнивает между собой два объекта:

    class Song
        {
            string name;
            string author;
            Song prev;

            public void SetName(string name)
            {
                this.name = name;
            }

            public void SetAuthor(string author)
            {
                this.author = author;
            }

            public void SetPrev(Song prev)
            {
                this.prev = prev;
            }

            public string Title()
            {
                return $"{name} — {author}";
            }

            public void PrintInfo()
            {
                Console.WriteLine(Title());
            }

            public override bool Equals(object d)
            {
                Song other = d as Song;
                if (other == null)
                {
                    return false;
                }

                return this.name == other.name && this.author == other.author;
            }
            public override int GetHashCode()
            {
                return (name + author).GetHashCode();
            }
        }
        internal class HW2
        {
            static void Main2(string[] args)
            {
                List<Song> songs = new List<Song>();

                Song song1 = new Song();
                song1.SetName("Sonne");
                song1.SetAuthor("Rammstein");
                song1.SetPrev(null);
                songs.Add(song1);

                Song song2 = new Song();
                song2.SetName("Судно");
                song2.SetAuthor("Молчат дома");
                song2.SetPrev(song1);
                songs.Add(song2);

                Song song3 = new Song();
                song3.SetName("Группа крови");
                song3.SetAuthor("Кино");
                song3.SetPrev(song2);
                songs.Add(song3);

                Song song4 = new Song();
                song4.SetName("Кукла колдуна");
                song4.SetAuthor("Король и Шут");
                song4.SetPrev(song3);
                songs.Add(song4);

                Console.WriteLine("Список песен:");
                foreach (Song song in songs)
                {
                    song.PrintInfo();
                }

                Console.WriteLine();
                if (songs[0].Equals(songs[1]))
                {
                    Console.WriteLine("Первая и вторая песни одинаковые.");
                }
                else
                {
                    Console.WriteLine("Первая и вторая песни разные.");
                }
            }
        }
}
