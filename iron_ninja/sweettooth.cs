using System;
using System.Collections.Generic;

namespace iron_ninja
{
    class SweetTooth : Ninja
    {
        public override bool IsFull
        {
            get 
            {
                if (calorieIntake >= 1500){
                    Console.WriteLine("SweetTooth is full and cannot eat anymore!");
                    Console.WriteLine(" ");
                    return true;
                }
                return false;
            }
        }

        public override void Consume (IConsumable item){
            calorieIntake += item.Calories;
            if (item.IsSweet){
                calorieIntake += 10;
            }
            ConsumptionHistory.Add(item);
            Console.WriteLine(item.GetInfo());
            Console.WriteLine(" ");
        }
    }
}