using System;

namespace App{
     class App{
          public static int a;
          public static int b;

          public static int c;

          public static int options;
          public static void Main(string[] args)
          {
               Console.WriteLine("Please select an option");
               Console.WriteLine(
                    "1. +\n"+
                    "2. -\n"+
                    "3. *\n"+
                    "4. /"
               );
               options = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Please Enter the first numebr");
               a = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Please Enter the Second Number");
               b = Convert.ToInt32(Console.ReadLine());
               
               Add();
               Minus();
               Multiply();
               Division();
               
          }

          public static  void Add(){
               if (options == 1)
               {
                    c=a+b;
                    Console.WriteLine("The Answer is" +" "+c);
               }
          }
          public static  void Minus(){
               if (options == 1)
               {
                    c=a+b;
                    Console.WriteLine("The Answer is" +" "+c);
               }
          }
          public static  void Multiply(){
               if (options == 1)
               {
                    c=a+b;
                    Console.WriteLine("The Answer is" +" "+c);
               }
          }
          public static  void Division(){
               if (options == 1)
               {
                    c=a+b;
                    Console.WriteLine("The Answer is" +" "+c);
               }
          }
     }
}
