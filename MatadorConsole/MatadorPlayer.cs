using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatadorConsole
{
    public class MatadorPlayer
    {

        public MatadorPlayer()
        {
            currentPos = 0;
            numberOfPositions = 39; // 40 spaces in total
            _result = new List<int>();
            for (int i = 0; i <= numberOfPositions; i++)
            {
                _result.Add(0);
            }
        }

        public MatadorPlayer(int startingPosition, int totalNumberOfPositions)
        {
            currentPos = startingPosition;
            numberOfPositions = totalNumberOfPositions;
            _result = new List<int>();

            for (int i = 0; i <= totalNumberOfPositions; i++)
            {
                _result.Add(0);
            }
        }

        private int currentPos;
        private int numberOfPositions;
        private List<int> _result;
        private Random rand = new Random();

        public List<int> GetResult()
        {
            return _result;
        }
        public void TakeTurn()
        {
            MoveToNextPos(RollDie());

            _result[currentPos] += 1;
            Console.WriteLine("currentposition: " + currentPos.ToString() + " set to " + _result[currentPos].ToString());
        }

        private int RollDie()
        {

            int die1 = rand.Next(1, 6);
            int die2 = rand.Next(1, 6);

            Console.WriteLine("currentposition: " + currentPos.ToString());
            Console.WriteLine("rolled " + die1 + " " + die2);

            return die1 + die2;
        }

        private void MoveToNextPos(int spacesToMove)
        {
            if (currentPos + spacesToMove > numberOfPositions)
            {
                currentPos = currentPos + spacesToMove - numberOfPositions-1;
            }
            else
            {
                currentPos += spacesToMove;
            }
            CheckIfOnSpecialField();
        }

        //return true if special field allows you to move twice in case of a pair die roll 
        private bool CheckIfOnSpecialField()
        {

            switch (currentPos)
            {
                //try your luck fields
                case 3:
                    return TryYourLuckCard();

                case 8:
                    return TryYourLuckCard();

                case 18:
                    return TryYourLuckCard();

                case 23:
                    return TryYourLuckCard();

                case 34:
                    return TryYourLuckCard();

                case 37:
                    return TryYourLuckCard();


                //go to jail
                case 31:
                    currentPos = 11;
                    return false;
            }

            return true;
        }

        private bool TryYourLuckCard()
        {

            return true;
        }

    }
}