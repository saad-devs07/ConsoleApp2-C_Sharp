using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class3
    {
        /*public static void data()
        {
            Console.WriteLine("Welcome!");
        }

        public static void data(string n)
        {
            Console.WriteLine("Welcome " + n);
        }

        public static void data(string n, string f_n)
        {
            Console.WriteLine("Welcome " + n + " S/o " + f_n);
        }

        public static void data(string n, int age)
        {
            Console.WriteLine("Welcome " + n + " your age is " + age);
        }

        public static void data(int ph)
        {
            Console.WriteLine("Your Phone number is " + ph);
        }

        public virtual void plus(int n1, int n2)
        {
            Console.WriteLine("Result after addition is " + (n1 + n2));
        }

        public virtual void plus(double n1, double n2)
        {
            Console.WriteLine("Result after addition is " + (n1 + n2));
        }

        public void xyz(int a, float b)
        {
            Console.WriteLine(a + b);
        }

        public void xyz(int a, double b)
        {
            Console.WriteLine(a + b);
        }
        public void xyz(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public void xyz(short a, double b)
        {
            Console.WriteLine(a + b);
        }

        public virtual void abcd(String a)
        {
            Console.WriteLine("Welcome " + a);
        }

        public virtual void xyz(string a)
        {
            Console.WriteLine("Welcome " + a);
        }
        public virtual void xyz(int b)
        {
            Console.WriteLine("Your age is " + b);
        }

        public virtual void v_table()
        {
            Console.WriteLine("Enter number whose table you want, also enter starting and ending value:");
            int t, s, e;
            t = int.Parse(Console.ReadLine());
            s = Convert.ToInt32(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            int a = s;
            while (a <= e)
            {
                Console.WriteLine(t + " x " + a + " = " + (t * a));
                a++;
            }
        }*/

        /*public static void A1(string num1)
        {
            Console.WriteLine("Welcome "+num1);
        }
        public static void A1(string num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void A1(int num1, float num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void A1(string num1, decimal num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public virtual void A2()
        {
            Console.WriteLine("Class3");
        }*/

        /*public string name
        {
            set;get;
        }

        public int age
        {
            get;
            set;
        }

        public string name1 
        {
            get;
            set;
        }*/

        string name, f_name, Add;
        int age2;

        public string n
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string fn
        {
            get
            {
                return f_name;
            }
            set
            {
                f_name = value;
            }
        }
        public int age
        {
            get
            {
                return age2;
            }
            set
            {
                age2 = value;
            }
        }
        public string address
        {
            get
            {
                return Add;
            }
            set
            {
                Add = value;
            }
        }




    }
}
