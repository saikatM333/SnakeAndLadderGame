using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public  class singlePlayerGame
    {
        public string name;        
        public singlePlayerGame()
        {
            Console.WriteLine("Enter the name\n ");
            string name = Console.ReadLine();
            this.name = name;
            

        
        }

        public void playingTheGame()
        {
            // roll the dice and it will give the value between 1 - 6
            Random r = new Random();
            int roll = r.Next(1, 7);
           
            int count = 0;

           
        }

    }
}
