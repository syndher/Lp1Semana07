using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
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
    
        public string Name { get; }

        public float WinRate
        {
            get
            {
                if (playedGames == 0)
                    return 0;
                else
                    return (float)wonGames / playedGames;
            }
        }


    }
}
