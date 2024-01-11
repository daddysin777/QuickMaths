using System;
using System.Collections.Generic;
using System.Text;

namespace QuickMathsLib
{
    public class Quiz
    {
        public int a, b;

        public void AddQuizGenerate()
        {
            Random r = new Random();
            a = r.Next(10, 20);
            b = r.Next(0, 10);
        }

        public void SubQuizGenerate()
        {
            Random r = new Random();
            a = r.Next(10, 20);
            b = r.Next(10, a);
        }

        public void MulQuizGenerate()
        {
            Random r = new Random();
            a = r.Next(1, 10);
            b = r.Next(1, 10);
        }

        public void DivQuizGenerate()
        {
            Random r = new Random();
            a = r.Next(1, 10);
            b = r.Next(1, a);
        }

        public int AddQuizCheck(int ans)
        {
            if(ans == a+b)
            {
                Console.WriteLine("Correct");
                return 1;
            }
            else
            {
                Console.WriteLine("Incorrect");
                return -1;
            }
        }

        public int SubQuizCheck(int ans)
        {
            if(ans == a-b)
            {
                Console.WriteLine("Correct");
                return 1;
            }
            else
            {
                Console.WriteLine("Incorrect");
                return -1;
            }
        }

        public int MulQuizCheck(int ans)
        {
            if (ans == a * b)
            {
                Console.WriteLine("Correct");
                return 1;
            }
            else
            {
                Console.WriteLine("Incorrect");
                return -1;
            }
        }

        public int DivQuizCheck(int ans)
        {
            if (ans == a / b)
            {
                Console.WriteLine("Correct");
                return 1;
            }
            else
            {
                Console.WriteLine("Incorrect");
                return -1;
            }
        }
    }
}
