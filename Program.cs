namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int a = 7; a <= 70; a = a + 7)
            {
                Console.WriteLine("7 * 1 = " + a);
            }

            for (int b = 70; b >= 7; b = b - 7)
            {
                Console.WriteLine("7 * 1 = " + b);
            }

            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine("7 x " + i + " = "+(7*i));
            }
                Console.WriteLine("\n");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine("7 x " + i + " = " + (7 * i));
            }*/

            /*Console.WriteLine("Enter number for table");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Kahan se start ho");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter kab tak chale");
            int n3 = int.Parse(Console.ReadLine());

            if(n2 < n3)
            {
                for (int i = n2; i <= n3; i++)
                {
                    Console.WriteLine(n1 + " x " + i + " = " + (n1 * i));
                }
            }
            if (n2 > n3)
            {
                for (int i = n2; i >= n3; i--)
                {
                    Console.WriteLine(n1 + " x " + i + " = " + (n1 * i));
                }
            }*/

            /*Console.WriteLine("Enter any number for table, also enter starting and ending value!");
            int t, s, e;
            t = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            for (int i = s; i <= e; i++)
            {
                Console.WriteLine(t + " x " + i + " = " + (t * i));
            }
            for (int i = s; i >= e; i--)
            {
                Console.WriteLine(t + " x " + i + " = " + (t * i));
            }*/

            /*int a = 5;
            while (a <= 20)
            {
                Console.WriteLine(a);
                a++;
            }

            int b = 20;
            while (b >= 1)
            {
                Console.WriteLine(b);
                b--;
            }*/

            /*Console.WriteLine("Enter any number for table, also enter starting and ending value!");
            int n1, n2, n3;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            int i = n2;
            while (i <= n3)
            {
                Console.WriteLine(n1 + " x " + i + " = " + (n1 * i));
                i++;
            }
        
            int a = n2;
            while (a >= n3)
            {
                Console.WriteLine(n1 + " x " + a + " = " + (n1 * a));
                a--;
            }*/

            /*Console.WriteLine("Enter any number for table, also enter starting and ending value!");
            int n1, n2, n3;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            if (n2 < n3)
            {
                int x = n2;
                do
                {
                    Console.WriteLine(n1 + " x " + x + " = " + (n1 * x));
                    x++;
                }
                while (x <= n3);
            }
            else
            {
                int y = n2;
                do
                {
                    Console.WriteLine(n1 + " x " + y + " = " + (n1 * y));
                    y--;
                }
                while (y >= n3);
            }

            int abc = 10;
            do
            {
                Console.WriteLine(abc);
                abc++;
            } while (abc <= 15);*/

            /*int abc = 10;
            do
            {
                Console.WriteLine(abc);
                abc++;
            }
            while (false);*/

            /*int total = 0;
            string userInput = "";
            int enteredValue = 0;
            
            do
            {
                Console.WriteLine("Enter Item Price: ");
                userInput = Console.ReadLine();
                enteredValue = int.Parse(Console.ReadLine());

                if (enteredValue < 1)
                {
                    break;
                }
                enteredValue++;
            }
            while (true);

            Console.WriteLine("Total is "+(total + userInput))*/

            /*Class1 a = new Class1();
            a.abc();
            Console.WriteLine(a.number());
            Console.WriteLine(a.abcd());
            Console.WriteLine(a.num1());
            Console.WriteLine(a.num2());

            a.data("Saad");
            a.data("Raza");
            a.data("Saif");
            Console.WriteLine(a.data1("Suhaib"));
            Console.WriteLine(a.data1("Ahmed"));
            Console.WriteLine(a.data1("Zaid"));*/

            /*Class1 b = new Class1();

            Console.WriteLine(b.a);
            Console.WriteLine(Class1.b);
            b.ab();
            Class1.ba();

            Console.WriteLine(b.xyz("Saad"));
            Console.WriteLine(b.xyz(b.x));
            Console.WriteLine(b.x);

            Console.WriteLine(b.a123);

            Class2 b2 = new Class2();
            Console.WriteLine(b2.x);

            Class3 b3 = new Class3();
            Console.WriteLine(b3.a123); */

            /*Class3.data(0312456789);
            Class3.data("Saad", 31);
            Class3.data();
            Class3.data("Saad", "Ziauddin");
            Class3.data("Saad");

            Class4.data("Saad", 923052586);
            Class4.data("Saad");
            Class4.data("Saad", "Ziauddin");

            Class3 abc = new Class3();
            abc.plus(12,12);
            abc.plus(12, 12.05);

            abc.xyz(10,10.89);
            abc.xyz(25, 0.258);
            abc.xyz(25.78, 89.95);

            abc.abcd("Saad!");

            Class4 abc2= new Class4();
            abc2.abcd("Saad!");

            abc2.plus(10, 10.2);
            abc2.plus(20, 15);*/

            /*Class3 ab = new Class3();
            Class4 ba = new Class4();*/

            //ab.xyz(20);
            //ba.xyz("Saad!");
            //ba.xyz(0323456789);

            // ab.v_table();
            // ba.v_table();

            // Class3.A1("Dear customer, your number is ", 20);
            // Class3.A1(10,20.25f);
            // Class3.A1(10,11);

            // ab.A2();
            // ba.A2();
            // ba.form();

            Class3 c = new Class3();
            /*c.name = "Saad";
            Console.WriteLine(c.name);
            c.age = 21;
            Console.WriteLine(c.age);
            Console.WriteLine("Welcome " + c.name + " you're "+ c.age + " years old!");
            Console.Write("Ali", c.name1);
            Console.WriteLine(" Sethi", c.name1);*/

            /*c.n = ;
            c.fn = "Ziauddin";
            c.age = 21;
            c.address = "Defence view phase 1, Karachi.";
            Console.WriteLine("Name: " + c.n + "\nFather Name: " + c.fn + "\nAge: " + c.age + "\nAddress: " + c.address);*/

            Console.WriteLine("Enter your name, father name, age and address: ");
            c.n = Console.ReadLine();
            c.fn = Console.ReadLine();
            c.age = int.Parse(Console.ReadLine());
            c.address = Console.ReadLine();

            Console.WriteLine("Name: " + c.n + "\nFather Name: " + c.fn + "\nAge: " + c.age + "\nAddress: " + c.address);

            //Console.WriteLine("Employement Form: \n");

            //Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter your email: ");
            //string email = Console.ReadLine();

            //Console.WriteLine("Enter your mobile no.: ");
            //int phone = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Create your password: ");
            //string pass = Console.ReadLine();

            //Console.WriteLine("Repeat your password: ");
            //string rpass = Console.ReadLine();

            //if (pass == rpass)
            //{
            //    Console.WriteLine("Please confirm data you entered is correct or not. (True or False)");
            //    bool confirm = bool.Parse(Console.ReadLine());
            //    if (confirm == true)
            //    {
            //        Console.WriteLine("Account created successfully!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Data not saved fill again!");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Password and Repeat Password not matched!");
            //}
        }
    }
}