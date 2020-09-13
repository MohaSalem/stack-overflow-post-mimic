using System;

namespace StackOverFlowPostMimic
{
    public class Post
    {
        public string Title { get; set; } 
        public string Description { get; set; }
        public DateTime PostDate { get; private set; }
        public int Votes { get; private set; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.PostDate = DateTime.Now;
            this.Votes = 0;
        }

        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            Votes--;
        }

    }
}
