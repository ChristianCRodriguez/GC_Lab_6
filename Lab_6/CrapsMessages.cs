using System;

namespace Lab_6
{
    class CrapsMessages
    {
        public static void getSpecialMessage(int firstDie, int secondDie)
        {
            if (firstDie == secondDie)
            {
                switch (firstDie)
                {
                    case 1:
                        Console.WriteLine("Snake Eyes");
                        break;
                    case 2:
                        Console.WriteLine("Hard Four");
                        break;
                    case 3:
                        Console.WriteLine("Hard Six");
                        break;
                    case 4:
                        Console.WriteLine("Hard Eight");
                        break;
                    case 5:
                        Console.WriteLine("Hard Ten");
                        break;
                    case 6:
                        Console.WriteLine("Box Cars");
                        break;
                }
            }
            //TODO: Add Variants of sums
            else if (firstDie != secondDie)
            {
                int total = firstDie + secondDie;
                switch (total)
                {
                    case 3:
                        Console.WriteLine("Ace Deuce");
                        break;
                    case 4:
                        Console.WriteLine("Easy Four");
                        break;
                    case 5:
                        Console.WriteLine("Five (Fever Five)");
                        break;
                    case 6:
                        Console.WriteLine("Easy Six");
                        break;
                    case 7:
                        Console.WriteLine("Natural or Seven Out");
                        break;
                    case 8:
                        Console.WriteLine("Easy Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine (Nina)");
                        break;
                    case 10:
                        Console.WriteLine("Easy Ten");
                        break;
                    case 11:
                        Console.WriteLine("Yo (Yo-leven)");
                        break;
                }
            }
        }
    }
}
