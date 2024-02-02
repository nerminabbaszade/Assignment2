using System.ComponentModel;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary:");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your marital status married,single or widow:(M/S/W)");
            char maritalStatus=char.Parse(Console.ReadLine());
            int numberChildren;
            if (maritalStatus == 'S' || maritalStatus == 's')
            {
                numberChildren = 0;
            }
            else
            {
                Console.WriteLine("Enter the number of children:");
                numberChildren = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Being disabled or not(Y/N):");
            char abilityStatus=char.Parse(Console.ReadLine());

            //Extra money for marital status
            int maritalMoney=0;
            if(maritalStatus=='m' || maritalStatus == 'M')
            {
                maritalMoney=50;
            }

            //Extra money for the number of children
            int childrenMoney=0;
            if (numberChildren==1)
            {
                childrenMoney = 30;
            }
            else if(numberChildren==2) {
                childrenMoney = 55;
            }
            else if( numberChildren==3)
            {
                childrenMoney = 75;
            }
            else if( numberChildren>3)
            {
                childrenMoney = 75 + (numberChildren - 3) * 15;
            }
            //Calculating final salary
            float taxPercent, taxAmount;
            int grossSalary = salary + maritalMoney + childrenMoney;

            if(grossSalary <= 1000) {
                if ( abilityStatus=='y' || abilityStatus =='Y' ) {
                    taxPercent = 0.075f;
                    taxAmount =grossSalary*taxPercent;
                }
                else
                {
                    taxPercent = 0.15f;
                    taxAmount = grossSalary *taxPercent;
                }
            }
            else if( grossSalary <= 2000 ) {
                if (abilityStatus == 'y' || abilityStatus == 'Y')
                {
                    taxPercent = 0.1f;
                    taxAmount = grossSalary * taxPercent;
                }
                else
                {
                    taxPercent = 0.2f;
                    taxAmount = grossSalary * taxPercent;
                }
            }
            else if (grossSalary <= 3000)
            {
                if (abilityStatus == 'y' || abilityStatus == 'Y')
                {
                    taxPercent = 0.125f;
                    taxAmount = grossSalary * taxPercent;
                }
                else
                {
                    taxPercent = 0.25f;
                    taxAmount = grossSalary * taxPercent;
                }
            }
            else
            {
                if (abilityStatus == 'y' || abilityStatus == 'Y')
                {
                    taxPercent = 0.15f;
                    taxAmount = grossSalary * taxPercent;
                }
                else
                {
                    taxPercent = 0.3f;
                    taxAmount = grossSalary * taxPercent;
                }
            }

            float finalSalary= salary- taxAmount;
            //Final results
            Console.WriteLine($"Marital Money: {maritalMoney}");
            Console.WriteLine($"Money for children: {childrenMoney}");
            Console.WriteLine($"Tax percent: {Math.Round(taxPercent*100, 3)}%");
            Console.WriteLine($"Tax amount: {Math.Round(taxAmount,3)}");
            Console.WriteLine($"Gross salary: {grossSalary}");
            Console.WriteLine($"Final salary: {Math.Round(finalSalary, 3)}");

            int payment = (int)Math.Round(finalSalary);
            int money200 = payment / 200;
            int money100 = payment % 200 / 100;
            int money50 = payment % 100 / 50;
            int money20 = payment % 50 / 20;
            int money10 = payment % 50% 20 / 10;
            int money5 = payment % 10 / 5;
            int money1 = payment % 5 ;

            Console.WriteLine("The number of banknotes for payment:");
            Console.WriteLine("200: "+money200);
            Console.WriteLine("100: " + money100);
            Console.WriteLine("50: " + money50);
            Console.WriteLine("20: " + money20);
            Console.WriteLine("10: " + money10);
            Console.WriteLine("5: " + money5);
            Console.WriteLine("1: " + money1);
        }
    }
}
