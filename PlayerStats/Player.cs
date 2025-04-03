using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;



namespace PlayerStats
{

    class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;

        public float HighScore
        {
            get => highScore;
            set {if (value > highScore) highScore = value;}
        }
    
       
    }
}
