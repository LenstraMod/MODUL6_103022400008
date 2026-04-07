using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MODUL6_103022400008
{
    public class SayaMusicUser
    {
        private int id;
        public string username;
        private List<SayaMusicTrack> uploadedTracks;

        public SayaMusicUser(string username)
        {
            Random rand = new Random();
            int rand_num = rand.Next(10000, 100000);
            this.id = rand_num;

            this.username = username;
            this.uploadedTracks = new List<SayaMusicTrack>();
        }

        public int GetTotalPlayCount()
        {
            int total = 0;
            foreach (SayaMusicTrack item in uploadedTracks)
            {
                total += item.getPlayCount();
            }

            return total;
        }

        public void AddTrack(SayaMusicTrack item) 
        {
            this.uploadedTracks.Add(item);
        }

        public void PrintAllTracks()
        {
            Console.WriteLine("Name: " + this.username);
            int idx = 1;
            foreach (SayaMusicTrack item in uploadedTracks)
            {
                Console.Write("Track " + (idx) + " judul:  ");
                item.printTrackDetails();
                Console.WriteLine();

                idx++;
            }
        }
    }
}
