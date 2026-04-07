using System;
using System.Collections.Generic;
using System.Text;

namespace MODUL6_103022400008
{
    public class SayaMusicTrack
    {
        private int id;
        public string title;
        private int playCount;

        public SayaMusicTrack(String title)
        {
            Random rand = new Random();
            int rand_num = rand.Next(10000, 100000);
            this.id = rand_num;

            this.title = title;
            this.playCount = 0;
        }

        public void increasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void printTrackDetails()
        {
            Console.Write(this.title);
        }

        public int getPlayCount() { 
            return this.playCount;
        }
    }
}
