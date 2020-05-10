using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class Player
    {
        private string name;
        private int secretDigits;
        private bool isActive;
        private bool isNumberGuessed;
        private List<int> myPlayedDigits = new List<int>();

        //This will prevent the name to be changed after initialization by the constructor
        public string Name
        {
            get { return this.name; }
        }

        public List<int> PlayedDigits
        {
            get { return this.myPlayedDigits; }
        }

        public int SecretDigits
        {
            get { return this.secretDigits; }
        }

        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }

        public bool IsGuessed
        {
            get { return this.isNumberGuessed; }
            set { this.isNumberGuessed = value; }
        }

        //Empty Constructor
        public Player() { }

        //Constructor to initialize the name and secret digits which are afterwards unchangeable
        public Player(string name, int secretDigits)
        {
            this.name = name;
            this.secretDigits = secretDigits;
        }

        static bool Compare(int firstNumber, int secondNumber)
        {
            int deadCounter = 0, injuredCounter = 0;
            string first = firstNumber.ToString();
            string second = secondNumber.ToString();

            for (int i = 0; i < first.Length; ++i)
            {
                for (int j = 0; j < second.Length; ++j)
                {
                    //To avoid multiple countings of 'dead' digits
                    if (first[i] == second[j])
                    {
                        if (first[i] == second[i])
                        {
                            deadCounter++;
                        }
                        else
                        {
                            injuredCounter++;
                        }
                    }
                }
            }

            if (deadCounter == 0 && injuredCounter == 0)
            {
                Console.WriteLine("That ain't the number");
            }
            else
            {
                if (deadCounter == first.Length)
                {
                    Console.WriteLine("All dead", ConsoleColor.Green);
                    Console.WriteLine("Game Over!!!", ConsoleColor.Green);
                    return true;
                }
                else
                {
                    Console.WriteLine($"{deadCounter} dead, {injuredCounter} injured", ConsoleColor.Yellow);
                }
            }
            return false;
        }
    }

}
