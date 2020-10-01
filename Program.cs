﻿using EmptySeeker;
using Newtonsoft.Json;
using System;
using System.IO;

namespace EmptySeeker {
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = 0;
            string[] directories = Directory.GetDirectories(Path.Combine(Directory.GetCurrentDirectory(), "../"));
            foreach (string dir in directories) {
                string loc = Path.Combine(dir, "modInfo.json");
                if (File.Exists(loc))
                    if (JsonConvert.DeserializeObject<ModInfo>(File.ReadAllText(loc)) == null)
                        Console.WriteLine("An error has occurred at " + loc + ".");
                else if (Directory.GetDirectories(dir).Length == 0 && Directory.GetFiles(dir).Length == 0)
                    Console.WriteLine(dir + " is empty.");
                count++;
            }
            Console.WriteLine("Iterated through " + count + " folders.");
            Console.WriteLine("Press enter to exit.");
            Console.Read();
        }
    }
}