using System;

namespace Lecture14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            Console.WriteLine("Enter song Name");
            song.songName = Console.ReadLine();
            Console.WriteLine("Enter song Lenght(min)");
            song.songLenght = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter song Author");
            song.songAuthor = Console.ReadLine();
            Console.WriteLine("Enter song Year");
            song.songYear = uint.Parse(Console.ReadLine());
            object obj = GetSongData(song);
        }
        public static object GetSongData(Song song)
        {
            return new { Title= song.songName, Minutes = song.songLenght, AlbumYear = song.songYear };
        }
    }
}
