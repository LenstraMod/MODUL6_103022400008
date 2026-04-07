
using MODUL6_103022400008;

string[] songTitle = {"Ripples of The Reverie", "The Journey", "Jazz", "Satu-Satunya Pengharapanku","Good Day", "Lagu Alphabet", "Yesus kekasih jiwaku", "White Night", "Lagu AAAAA"};

SayaMusicUser abe = new SayaMusicUser("Abe");

for (int i = 0; i < songTitle.Length; i++)
{
    string complete = "Review Lagu " + songTitle[i] + " oleh " + abe.username;
    SayaMusicTrack music = new SayaMusicTrack(complete);
    abe.AddTrack(music);
}

abe.PrintAllTracks();