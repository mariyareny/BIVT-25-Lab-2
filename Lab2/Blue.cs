using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;
            double d = 1;
            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / d;
                d *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            double ch = 1;
            double f = 1;
            // code here
            for(int i =1; i <= n; i++)
            {
                ch *= -5;
                f *= i;
                answer += ch / f;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            if (n <= 0) return 0;
            long answer = 0;
            int k = 0;
            int a = 0;
            int b = 1;
            if (n >= 1) answer += a;
            if (n >= 2) answer += b;
            for(int  j = 3; j <= n; j++)
            {
                k = a + b;
                a = b;
                b = k;
                answer += k;
            }

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            int s = 0;
            int k = 0;
            // code here
            for (int i = 0; s <= L; i++)
            {
                s += a + h * i;
                k += 1;
            }
            // end
            answer = k-1;
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;

            // code here
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;
            int time = 0;
            // code here
            do
            {
                S *= 2;
                time += h;
            } while (S <= L);
            // end
            answer = time;
            return answer;
        }

        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;
            int days = 0;

            double r = 1.0 + I / 100.0;

            double current = S;
            for (int i = 0; i < 7; i++)
            {
                a += current;
                current *= r;
            }

            current = S;
            double total = 0.0;
            days = 0;
            int maxDays = 100000; 
            while (days < maxDays)
            {
                days++;
                total += current;
                if (total >= 100.0)
                {
                    b = days;
                    break;
                }
                current *= r;
            }
    
            current = S;
            days = 0;
            while (days < maxDays)
            {
                if (current > 42.0)
                {
                    c = days;
                    break;
                }
                current *= r;
                days++;
            }


            return (a, b, c);
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double eps = 0.0001;

            for (double x = a; x <= b + 1e-12; x += h)
            {
                double s = 0;
                double term = 1;
                int i = 0;

                while (true)
                {
                    double current = (2 * i + 1) * term;
                    s += current;

                    if (Math.Abs(current) < eps)
                        break;

                    i++;
                    term *= (x * x) / i; 
                }

                double y = (1 + 2 * x * x) * Math.Exp(x * x);

                SS += s;
                SY += y;
            }

            return (SS, SY);
        }


    }
}