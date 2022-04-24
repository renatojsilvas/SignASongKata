using SignASongKata.Core;
using System;
using System.Collections.Generic;
using System.IO;

namespace song
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<string>() { "fly", "spider", "bird", "cat", "dog", "cow", "horse" };
            var songGenerator = new SongGenerator(animals);
            Console.WriteLine(songGenerator.GenerateSong());
        }
    }
}