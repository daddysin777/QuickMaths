using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickMaths
{
    public class Quiz
    {
        public int a, b;
        public int AddQuiz(int ans)
        {
            Random r = new Random();
            a = r.Next(0, 10);
            b = r.Next(0, 10);

            if (ans == a + b)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
