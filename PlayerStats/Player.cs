using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;



namespace PlayerStats
{

    class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;
        public string Name;

        public Player(string Name)
        {
            this.Name = Name;
        }

        public float HighScore
        {
            get => highScore;
            set {if (value > highScore) highScore = value;}
        }
    

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
        public void PlayGame(bool win)
        {
            playedGames++;
            if (win == true)
            {
                wonGames++;
            }
        }

    }
}
