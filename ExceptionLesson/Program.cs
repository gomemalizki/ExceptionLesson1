namespace ExceptionLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Fraction f1 = new Fraction(6, 3);
			Console.WriteLine("Enter nominator");
           
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    //comment קליטת מספרים
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Denominator");
                    num2 = int.Parse(Console.ReadLine());
               //     int num3 = int.Parse(str);
                    f1 = new Fraction(num1, num2);
                    validInput = true;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Null argument enter new numbers");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("only numbers");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("number too big");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

			Console.WriteLine(f1);
            Console.WriteLine($"{f1}={f1.Result()}");
        }
    }
}
