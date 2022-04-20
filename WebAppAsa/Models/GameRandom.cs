using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAsa.Models
{
    public class GameRandom
    {
        [HttpGet]
        public static string MatchGuess(int guess, int rnd)
        {
            if (guess < rnd)
            {
                return "Higher!";
            }
            else if (guess > rnd)
            {
                return "Lower!";
            }
            else
            {
                return "Yes!! You won!";
            }
        }
        public static int GetRandom(int max)
        {
            Random rnd = new Random();
            return rnd.Next(1, max);
        }
    }
}


