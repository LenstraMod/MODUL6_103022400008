
using MODUL6_103022400008;

string[] songTitle = {"Ripples of The Reverie", "The Journey", "Jazz", "Satu-Satunya Pengharapanku","Good Day", "Lagu Alphabet", "Yesus kekasih jiwaku", "White Night", "Lagu AAAAA", "ROCK BANGET"};

SayaMusicUser abe = new SayaMusicUser("Abe");

try
{
    for (int i = 0; i < songTitle.Length; i++)
    {
        string complete = "Review Lagu " + songTitle[i] + " oleh " + abe.username;
        SayaMusicTrack music = new SayaMusicTrack(complete);
        abe.AddTrack(music);
    }

    abe.PrintAllTracks();


    //Simulasi Error

    //abe.AddTrack(new SayaMusicTrack("SawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepanSawitItuMasaDepan"));

    //SayaMusicTrack newMusic = new SayaMusicTrack("Test Song");
    //newMusic.increasePlayCount(30000000);
    //newMusic.increasePlayCount(-2);

    //SayaMusicUser newUser = new SayaMusicUser("RatapanYeruSoloRatapanYeruSoloRatapanYeruSoloRatapanYeruSoloRatapanYeruSoloRatapanYeruSoloRatapanYeruSoloRatapanYeruSoloRatapanYeruSoloRatapanYeruSoloRatapanYeruSoloRatapanYeruSolo");

    //SayaMusicTrack newMusic = new SayaMusicTrack("Test Song");
    //for (int i = 0; i < 100; i++) {
    //    newMusic.increasePlayCount(15000000);
    //}
}
catch(Exception e) {
    Console.WriteLine("Error : " + e.ToString);
}