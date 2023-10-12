using StringBuilder.Entities;
using System;
using System.Globalization;

namespace StringBuilderProject
{
    public class Program
    {
        static void Main()
        {
            var post1 = new Post();
            post1.Moment = DateTime.ParseExact("21/06/2018 13:05:58", 
                                               "dd/MM/yyyy HH:mm:ss",
                                               CultureInfo.InvariantCulture);

            post1.Title = "Traveling to New Zealand";
            post1.Content = "I'm going to visit this wonderful country";
            post1.Likes = 12;
            
            post1.AddComment(new Comment("Have a nice trip"));
            post1.AddComment(new Comment("Wow that's awesome!"));

            Console.WriteLine(post1.ToString());
            Console.WriteLine("Comments:");

            foreach (var comment in post1.Comments)
            {
                Console.WriteLine(comment.ToString());
            }
            
            Console.WriteLine();

            var post2 = new Post();
            post2.Moment = DateTime.ParseExact("28/07/2018 13:05:58", 
                                               "dd/MM/yyyy HH:mm:ss",
                                               CultureInfo.InvariantCulture);

            post2.Title = "Good night guys";
            post2.Content = "See you tomorrow!";
            post2.Likes = 5;

            post2.AddComment(new Comment("Good night"));
            post2.AddComment(new Comment("May the force be with you"));

            Console.WriteLine(post2.ToString());
            Console.WriteLine("Comments:");

            foreach (var comment in post2.Comments)
            {
                Console.WriteLine(comment.ToString());
            }
        }
    }
}
