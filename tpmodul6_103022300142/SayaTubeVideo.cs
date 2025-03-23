using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300142
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 100, "Title must not be null and should have a maximum length of 100 characters.");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count > 0 && count <= 10000000, "Play count increment should be between 1 and 10,000,000.");

            checked
            {
                try
                {
                    this.playCount += count;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Play count overflow!");
                }
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
