using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class singlePlayerGame
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

            int position = 0;
            int positionStatus = 0;
            Boolean gameStatus = true;
            while (gameStatus)
            {


                position = position + roll;
                decidingtheStatus();

                if (position == 100)
                {
                    gameStatus = false;
                }
               
            }
        }
        public int decidingtheStatus()
        {

            Random r = new Random();
            int status = r.Next(0, 3);
            int change = 0;
            if (status == 0){
                return change;
            }
            else if (status == 1)
            {
                return snakeLength();
            }
            else
            {
                return ladderLength();
            }

           
        }

        public int snakeLength()
        {
            Random r = new Random();
            return r.Next(0, 12);

        }

        public int ladderLength()
        {
            Random r = new Random();
            return r.Next(0, 13);
        }


    }
}
