using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            String name;    
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("###########################################");
            Console.WriteLine("Hi {0}.Welcome to the quiz by Triveni", name);
            Console.WriteLine("###########################################");


            Console.WriteLine("Q1. who is the recent movie of surya  :");
            Console.WriteLine("1.Gajini  2.Singham  3.Aakasam ye ne haddu ra  4.Jai Bheem");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;

            Console.WriteLine("Q2. who is the hero in Leader :");
            Console.WriteLine("1.Charan  2.Rana  3.Ram  4.Prabhas");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;

            Console.WriteLine("Q3. what is the hero character name in Dookudu:");
            Console.WriteLine("1.Ajay 2.Surya 3.Siva  4.Pardhu");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;


            Console.WriteLine("Q4. who played father character of heroine in Nuvve Nuvve movie?");
            Console.WriteLine("1.Prakash Raj  2.Rao Ramesh  3.Jagapathi Babu 4.Surya");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;

            Console.WriteLine("Q5. who is the hero in 118:");
            Console.WriteLine("1.Ram Charan  2.Ravi Teja  3.NTR  4.Kalyan Ram");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;

            
            Console.WriteLine("Congratulations!!! Your quiz is completed. Admin will let you know your score");
            StreamWriter sw = new StreamWriter("D:\\DotnetProjects\\Day15Assignment\\QuizScore.txt",true);
            sw.WriteLine($"Score={score}");
            sw.Close();
            File.WriteAllText("D:\\DotnetProjects\\Day15Assignment\\QuizScore.txt",$"Score={score}");
            Console.ReadLine();


        }
    }
}
