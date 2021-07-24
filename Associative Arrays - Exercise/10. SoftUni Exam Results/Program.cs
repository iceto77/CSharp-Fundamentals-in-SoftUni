using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();
            Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "exam finished")
            {
                // "{username}-{language}-{points}
                string[] inputInfo = input.Split("-").ToArray();
                string curentUser = inputInfo[0];
                if (inputInfo.Length < 3 )
                {
                    if (users.ContainsKey(curentUser) && inputInfo[1] == "banned")
                    {
                        users.Remove(curentUser);
                    }
                }
                else
                {
                    string language = inputInfo[1];
                    int points = int.Parse(inputInfo[2]);
                    if (!users.ContainsKey(curentUser))
                    {
                        users.Add(curentUser, 0);
                    }
                    if (users[curentUser] < points)
                    {
                        users[curentUser] = points;
                    }
                    if (!languageSubmissions.ContainsKey(language))
                    {
                        languageSubmissions.Add(language, 0);
                    }
                    languageSubmissions[language]++;
                }
                    input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var item in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in languageSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
