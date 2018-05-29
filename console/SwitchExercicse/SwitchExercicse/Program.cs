using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExercicse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sachin,Ricky,Jacques,Michael,Gilchrist,Sangakara and Imran \n are nominated in the ICC player of the year."
                +"Who do you think should win?");
            string nominees = Console.ReadLine();
            string reason = "";

            switch(nominees)
            {
                case "Sachin":
                    reason = "One of the complete batsman,scored hundreds 100.";
                break;

                case "Ricky":
                    reason = "Greatest captain,won world cup and team remain in number one spot during his captaincy ";
                    break;

                case "Jacques":
                    reason = "Complete all rounder, with lots of runs and wickets";
                    break;

                case "Michael":
                    reason = "Won the Ashes.";
                    break;

                case "Sangakara":
                case "Gilchrist":
                    reason = "Complete wicket keeper batsman";
                    break;

                case "Imran":
                    reason = "Invented the art of reverse swing and won the world cup.";
                    break;

                default:
                    reason = "Players are not in the list of nomination";
                    break;
            }

            Console.WriteLine(reason);

        }
    }
}
