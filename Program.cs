using System;

namespace StackOverFlowPostMimic
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("C#", "Xamarin");
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            post.DownVote();
            Console.WriteLine("The post title is {0}, the post description is {1}, the post publishing date " +
                              "and time are {2} and the post votes are {3}", post.Title, post.Description, post.PostDate, post.Votes);
        }
    }
}