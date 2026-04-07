using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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

            Debug.Assert(title.Length <= 200, "Title melebihi 200 kata");
            Debug.Assert(title != null, "Judul tidak boleh kosong");

            Random rand = new Random();
            int rand_num = rand.Next(10000, 100000);
            this.id = rand_num;

            this.title = title;
            this.playCount = 0;
        }

        public void increasePlayCount(int count)
        {
            Debug.Assert(count <= 25000000, "Count tidak boleh melebihi 25.000.000");
            Debug.Assert(count >= 0, "Tidak boleh angka negatif");
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException e) {
                Console.WriteLine("Memenuhi Batas Maksimal: " + e.ToString);
            }
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
