using System;
using System.Collections.Generic;
using PostAndComment.Entities;

namespace PostAndComment
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awsome !");
            Post p1 = new Post(
                DateTime.Now,
                "Traveling to New ",
                "I'm going to visiti this wonderful contry !",
                12              
                );
            p1.AddComment(c1);
            p1.AddComment(c2);


            Console.WriteLine();

            Console.WriteLine(p1);

        }
    }
}
