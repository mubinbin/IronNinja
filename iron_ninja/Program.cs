using System;
using System.Collections.Generic;
using System.Linq;

namespace iron_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Food steak = new Food("steak", 1000, true, false);
            Drink pepsi = new Drink("PEPSI", 120, false, true);
            Buffet buffet = new Buffet();
            buffet.Menu.Add(steak);
            buffet.Menu.Add(pepsi);

            SpicyHound ninjaHot = new SpicyHound();
            SweetTooth ninjaSweet = new SweetTooth();

            while (!ninjaHot.IsFull){
                ninjaHot.Consume(buffet.Serve());
            }
            while (!ninjaSweet.IsFull){
                ninjaSweet.Consume(buffet.Serve());
            }

            int total = ninjaHot.ConsumptionHistory.Count + ninjaSweet.ConsumptionHistory.Count;

            // most consumed items of each ninja
            string mostItemSpicyHound = mostConsume(ninjaHot.ConsumptionHistory);
            Console.WriteLine($"NinjaHot consumed {mostItemSpicyHound} most!");
            Console.WriteLine(" ");
            string mostItemSweetTooth = mostConsume(ninjaSweet.ConsumptionHistory);
            Console.WriteLine($"NinjaSweet consumed {mostItemSweetTooth} most!");
            Console.WriteLine(" ");

            
        }
    
        public static string mostConsume(IEnumerable<IConsumable> ConsumptionHistory)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var item in ConsumptionHistory){
                if (!dict.ContainsKey(item.Name)){
                    dict.Add(item.Name, 1);
                }else{
                    dict[item.Name]++;
                }
            }
            dict = dict.OrderByDescending(i => i.Value).ToDictionary(i => i.Key, i => i.Value);
            return dict.ElementAt(0).Key;
        }
    }
}
