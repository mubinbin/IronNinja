using System;
using System.Collections.Generic;

namespace iron_ninja
{


    class Buffet
    {
        public List<IConsumable> Menu;
        //constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("full-loaded cheese burger", 1000, false, false),
                new Drink("coffee", 0, false, false),
                new Food("burito", 500, true, false),
                new Food("Tomatos", 50, false, true),
                new Food("Big Mac meal", 600, false, false),
                new Drink("Sprite", 120, false, true),
                new Food("whole pepperoni pizza", 1500, true, false)
            };
        }
         
        public IConsumable Serve()
        {
            Random rand = new Random();
            int index = rand.Next(0, Menu.Count);
            // Console.WriteLine(index);
            IConsumable selected = Menu[index];
            return selected;
        }
    }

    abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> ConsumptionHistory;
         
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }

        // add a public "getter" property called "IsFull"
        public abstract bool IsFull{get;}
        
        public abstract void Consume(IConsumable item);
    }
}
