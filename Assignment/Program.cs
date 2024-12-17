namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Functions 

            #region 1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example
            //// 1- Passing by Value:
            ////copy of the argument's value is passed to the method. The method works with this copy,
            ////and any changes made to the parameter inside the method do not affect the original
            ////variable outside the method
            //int num = 10;
            //update(num);
            //Console.WriteLine(num);  //Not Changes (num = 5)

            //// 2- Passing by Reference:
            ////the memory address of the original variable is passed to the method.
            ////This means that any changes made to the parameter inside the method will
            ////affect the original variable outside the method.

            //updatere(ref num);
            //Console.WriteLine(num); // output(num = 20)

            #endregion

            #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example
            ////1- Passing Reference Type by Value
            //// a copy of the reference (i.e., memory address) is passed to the method.
            //// However, the method still works with the same object in memory.

            ////any changes made to the object's fields/properties inside the method will
            ////affect the original object. However, reassigning the reference to a new object
            ////inside the method does not affect the original reference outside the method
            ////EX:
            //Person person = new Person { Name = "John" };
            //update(person); // Passing by value
            //Console.WriteLine("Person's Name after method call: " + person.Name);

            ////2- Passing Reference Type by Reference:
            //// the method receives the memory address of the original object.
            //// This means the method can modify the original reference itself,
            //// not just the object it points to.
            //// and will affect the original variable in the calling method
            //Person person00 = new Person { Name = "John" };
            //updatere(ref person00); // Passing by reference using 'ref'
            //Console.WriteLine("Person's Name after method call: " + person.Name); // Output: "Mohamed"

            #endregion

            #region 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //Console.Write("Enter The 1st Number: ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //Console.Write("Enter The 2nd Number: ");
            //int.TryParse(Console.ReadLine(), out int num2);
            //calculator(num1, num2, out int sum, out int sub);
            //Console.WriteLine($"{num1} + {num2} = {sum}\n{num1} - {num2} = {sub}");
            #endregion

            #region 4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given numbe
            //Console.Write("Enter A Number: ");
            //int.TryParse(Console.ReadLine(), out int sum);
            //Console.WriteLine($"The Sum Of The Digits Of The Number {sum}: {sumDigits(sum)}");
            #endregion

            #region 5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Enter A Number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine(IsPrime(num));
            #endregion

            #region 6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size < 2)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1}: ");
            //        while (!(int.TryParse(Console.ReadLine(), out arr[i])))
            //            Console.WriteLine("Please Enter An Integer");
            //    }
            //    MinMaxArray(arr, out int max, out int min);
            //    Console.WriteLine($"The Maximum Number: {max}\nThe Minimum Number: {min}");
            //}
            #endregion

            #region 7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //bool flag;
            //int num;
            //do
            //{
            //    Console.Write("Enter The Number: ");
            //    flag = int.TryParse(Console.ReadLine(), out  num);
            //} while (!flag || num == 0);
            //Console.WriteLine($"Factorial of {num} is: { Factorial(num)}");
            #endregion

            #region 8- Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //Console.Write("Enter The Text: ");
            //string str = Console.ReadLine();
            //Console.Write("Enter The Position: ");
            //int.TryParse(Console.ReadLine(), out int pos);
            //Console.Write("Enter The New Char: ");
            //char.TryParse(Console.ReadLine(), out char c);

            //string newStr = ChangeChar(str, pos, c);
            //Console.WriteLine($"Original string: {str}");
            //Console.WriteLine($"Modified string: {newStr}");
            #endregion

            #endregion
        }
        #region (Function) Q1: example(Passing by Value, Passing by Reference)
        //// 1- Passing by Value
        //static void update(int x)
        //{
        //    x = 20;
        //}
        //// 1- Passing by Referenc
        //static void updatere(ref int x)
        //{
        //    x = 20; // Modifies the original variable directly
        //}
        #endregion

        #region (Function) Q2: example(Passing by Value, Passing by Reference)
        ////1- Passing by Value
        //static void update(Person p)
        //{
        //    p.Name = "Saad"; //Modifying the object
        //    p = new Person { Name = "Mohamed" }; // not affect the original reference
        //}
        //// 1- Passing by Referenc
        //static void updatere(ref Person p)
        //{
        //    p.Name = "Saad"; // Modifying the object
        //    p = new Person { Name = "Mohamed" };  // Reassigning the reference to a new object
        //}
        #endregion

        #region (Function) Q3: 
        //static void calculator(int num1, int num2, out int sum, out int sub)
        //{
        //    sum = num1 + num2;
        //    sub = num1 - num2;
        //}
        #endregion

        #region (Function) Q4:
        //static int sumDigits(int n)
        //{
        //    int sum = 0;
        //    while (n != 0)
        //    {
        //        sum += n % 10; // sum = 0 + 25 % 10 --> (sum = 5)first digit  , sum = 5 + 2 % 10 = 5 + 2 = 7
        //        n /= 10;       // n = 2      ,  n = 2 / 10 = 0.2  (n = 0)
        //    }
        //    return sum;
        //}
        #endregion

        #region (Function) Q5:
        //static bool IsPrime(int num)
        //{
        //    if (num <= 1)
        //        return false;

        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % i == 0)
        //            return false; 
        //    }

        //    return true;
        //}
        #endregion

        #region (Function) Q6:
        //static void MinMaxArray(int[]arr, out int max, out int min)
        //{
        //    max = arr.Max();
        //    min = arr.Min();
        //}
        #endregion

        #region (Function) Q7:
        //static long Factorial(int num)
        //{
        //    int result = 1; 
        //    for (int i = 1; i < num; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}
        #endregion

        #region (Function) Q8:
        //static string ChangeChar(string input, int position, char newChar)
        //{
        //    if (position < 0 || position >= input.Length)
        //    {
        //        throw new ArgumentOutOfRangeException(nameof(position), "Position must be within the string's bounds.");
        //    }

        //    // Replace character at specified position
        //    char[] charArray = input.ToCharArray();
        //    charArray[position] = newChar;

        //    return new string(charArray);
        //}
        #endregion
    }
}
