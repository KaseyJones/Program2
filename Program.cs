using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

//Kasey Jones
//This program was designed to replicate and simulate the race between the tortoise and the hare
namespace ProgramAssignment2
{
    abstract class RaceAnimal
    {
        protected char symbol;
        protected int position;
        protected readonly int trackLength;

        public RaceAnimal(char symbol, int position, int trackLength)
        {
            this.symbol = symbol;
            this.position = position;
            this.trackLength = trackLength;
        }

        public abstract void Move();

        public void UpdatePosition(int move)
        {
            
        }

        public void PrintTrack()
        {
            
        }
    }

    class Tortoise : RaceAnimal
    {
        public Tortoise(char symbol, int position, int trackLength) : base(symbol, position, trackLength)
        {
            {

                Random randomNumbers = new Random();
                int move = randomNumbers.Next(1, 11);

                if (move >= 1 && move <= 5)
                {
                    Tortoise += 3;
                }

                else if (move >= 6 && move <= 8)
                {
                    ++Tortoise;
                }

                else if (move == 9 || move == 10)
                {
                    Tortoise -= 6;
                }

                if (Tortoise < startingGate)
                {
                    Tortoise = startingGate;
                }

                else if (Tortoise > finishline)
                {
                    Tortoise = finishline;
                }
            }
        }




        public override void Move()
        {
           
        }
    }

    class Hare : RaceAnimal
    {
        public Hare(char symbol, int position, int trackLength) : base(symbol, position, trackLength)
        {
            
        }

        public override void Move()
        {
            {
                Random randomNumbers = new Random();
                int move = randomNumbers.Next(1, 11);
                if (move == 1 || move == 2)
                {
                    Hare += 0;

                    big hop;
                }
                else if (move == 3 || move == 4)
                {
                    Hare += 9;
                }

                else if (move == 5)
                {
                    Hare -= 12;
                }

                else if (move >= 5 && move <= 8)
                {
                    ++Hare;
                }

                else if (move == 9 || move == 10)
                {
                    Hare -= 2;
                }

                if (Hare < startingGate)
                {
                    Hare = startingGate;
                }

                else if (Hare > finishline)
                {
                    Hare = finishline;
                }

            }
        }

        class Race
        {
            private Tortoise tortoise;
            private Hare hare;

            public Race()
            {

            }

            public void Simulate()
            {

            }
        }
    }
}
