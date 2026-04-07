using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
            Debug.Assert(username.Length <= 100, "Karakter username tidak boleh melebihi 100");
            Debug.Assert(username != null, "Username tidak boleh kosong");

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
            Debug.Assert(item != null, "Object lagu tidak boleh kosong");
            Debug.Assert(item.getPlayCount() <= int.MaxValue);
            this.uploadedTracks.Add(item);
        }

        public void PrintAllTracks()
        {
            Console.WriteLine("Name: " + this.username);
            int idx = 1;
            foreach (SayaMusicTrack item in uploadedTracks)
            {
                Contract.Ensures(idx <= 8);
                Console.Write("Track " + (idx) + " judul:  ");
                item.printTrackDetails();
                Console.WriteLine();

                idx++;
            }
        }
    }
}
