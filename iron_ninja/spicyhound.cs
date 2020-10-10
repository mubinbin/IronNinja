using System;
using System.Collections.Generic;

namespace iron_ninja
{
    class SpicyHound : Ninja
    {
        public override bool IsFull
        {
            get 
            {
                if (calorieIntake >= 1500){
                    Console.WriteLine("SpicyHound is full and cannot eat anymore!");
                    Console.WriteLine(" ");
                    return true;
                }
                return false;
            }
        }

        public override void Consume (IConsumable item){
            calorieIntake += item.Calories;
            if (item.IsSpicy){
                calorieIntake -= 10;
            }
            ConsumptionHistory.Add(item);
            Console.WriteLine(item.GetInfo());
            Console.WriteLine(" ");
        }
    }
}