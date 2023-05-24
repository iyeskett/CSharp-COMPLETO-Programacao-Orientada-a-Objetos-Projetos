using ExercicioResolvido2.Entities;
using System;

namespace ExercicioResolvido2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comment = new Comment("Heva a nice trip!");
            Comment comment1 = new Comment("Wow that´s awesome!");
            Post post = new Post(
                DateTime.Parse("21/06/2018 13:05:45"), 
                "Traveled to New Zealand", 
                "I´m going to visit this wonderful country!", 
                12
                );
            post.AddComment(comment);
            post.AddComment(comment1);

            Comment comment2 = new Comment("Good night");
            Comment comment3 = new Comment("may the force be with you");
            Post post1 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );
            post1.AddComment(comment2);
            post1.AddComment(comment3);

            Console.WriteLine(post);
            Console.WriteLine(post1);
        }
    }
}
