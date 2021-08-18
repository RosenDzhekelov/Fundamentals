using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>();
                        
            while (command!="end")
            {
                string[] input = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int serialNumber = int.Parse(input[0]);
                string itemName = input[1];
                int itemQuantity = int.Parse(input[2]);
                decimal itemPrice = decimal.Parse(input[3]);
                decimal boxPrice = itemPrice * itemQuantity;
               
                Box box = new Box();
                Item item = new Item();
                item.Name = itemName;
                box.Item = item;

                
                
                box.SerialNumber = serialNumber;
                box.Quantity = itemQuantity;
                box.BoxPrice = boxPrice;
                boxes.Add(box);

                if (boxes.Count > 1)
                {
                    for (int i = boxes.Count-1; i >=0; i--)
                    {
                        for (int j =i-1; j >= 0; j--)
                        {
                            if(boxes[i].BoxPrice>boxes[j].BoxPrice)
                            {
                                boxes.Insert(j, boxes[i]);
                                boxes.RemoveAt(i+1);   
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    
                }
                
                command = Console.ReadLine();
            }

            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.Write($"-- {box.Item.Name} - ${box.BoxPrice/box.Quantity:F2}: {box.Quantity}\n");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }
            
           
        }



    }
   public class Item
    {
        public string Name { get; set; }
    }

    class Box
    {
        public  Box()
        {
            Item = new Item();
        }

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal BoxPrice { get; set; }
    }
}
