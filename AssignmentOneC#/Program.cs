using System;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 

            /*
              Student Age Checker (Using Relational Patterns with Switch)
              Let the user enter a student's age.
              Use switch with relational pattern to check:

              If age > 25 : print "Older Student"
              If age between 18–25 : print "University Student"     
              If age < 18 : print "School Student"

              Use switch expression / relational pattern / when keyword             */


            /*  Console.WriteLine("Please enter a number ");
              int.TryParse(Console.ReadLine(), out int age);

              if (age <= 18)

                  age = 1;

              else if (age >= 18 && age <= 25)

                  age = 2;

              else if ( age >= 25)

                  age = 3;

              else

                  age = 0;


              switch (age)
              {
                  case 1:
                      Console.WriteLine("School Student");
                      break;
                  case 2:
                      Console.WriteLine("University Student");
                      break;
                  case 3:
                      Console.WriteLine("Older Student");
                      break;
                  default:
                      Console.WriteLine("Invalid age");
                      break;
              }
            */

            #endregion

            #region 1-	Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            /*
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 4 == 0)

                Console.WriteLine("Yes");

            else

                Console.WriteLine("No");
            */


            #endregion

            #region 2-	Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            /*
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Positive");

            */

            #endregion

            #region 3 -  Write a program that takes 3 integers from the user then prints the max element and the min element.

            /* Console.Write("Enter first number: ");
             int num1 = int.Parse(Console.ReadLine());

             Console.Write("Enter second number: ");
             int num2 = int.Parse(Console.ReadLine());

             Console.Write("Enter third number: ");
             int num3 = int.Parse(Console.ReadLine());
             int Max = num1 ;

             if (  num1 > num2 && num1 > num3)
                 Console.WriteLine("Max");
             else
                 Console.WriteLine("Min");*/




            #endregion

            #region 4-	Write a program that allows the user to insert an integer number then check If a number is even or odd.
            /*
            Console.Write("Enter Your number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            */

            #endregion

            #region 5-  Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).  
            /*
            Console.Write("Enter a character: ");
            char ch = char.Parse(Console.ReadLine());

            char lowerCh = char.ToLower(ch);

            if (lowerCh == 'a' || lowerCh == 'e' || lowerCh == 'i' || lowerCh == 'o' || lowerCh == 'u')

                Console.WriteLine("vowel");

            else

                Console.WriteLine("consonant");

            */

            #endregion

            #region 6-	 Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            /*
            Console.Write("Enter Your number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)

                Console.WriteLine(i);

            */

            #endregion

            #region 7-	Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            /*
            Console.Write("Enter Your number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++) {
                int result = num * i;
                Console.WriteLine($"{num} x {i} = {result}");

            }
            */

            #endregion

            #region 8-	Write a program that allows to user to insert number then print all even numbers between 1 to this number
            /*
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Even numbers between 1 and " + num + ":");

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/


            #endregion

            #region 9-	Write a program that takes two integers then prints the power.
            /*
            Console.Write("Enter a number1: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter a number2: ");
            int Ace = int.Parse(Console.ReadLine());
            double result = Math.Pow(num, Ace);

            Console.WriteLine($"{num} ^ {Ace} = {result}");

            */
            #endregion

            #region 10-	 Write a program to enter marks of five subjects and calculate total, average and percentage.
            /*

            int[] marks = new int[5];
            int total = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter marks of subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
                total += marks[i];
            }


            double average = total / 5.0;


            double percentage = (total / 500.0) * 100;

            Console.WriteLine($"Total Marks = {total}");
            Console.WriteLine($"Average Marks = {average}");
            Console.WriteLine($"Percentage = {percentage}%");
            */

            #endregion

            #region 11-	 Write a program to input the month number and print the number of days in that month.

            /*
        Console.Write("Enter month number (1-12): ");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("January has 31 days.");
                    break;
                case 2:
                    Console.WriteLine("February has 28 days.");
                    break;
                case 3:
                    Console.WriteLine("March has 31 days.");
                    break;
                case 4:
                    Console.WriteLine("April has 30 days.");
                    break;
                case 5:
                    Console.WriteLine("May has 31 days.");
                    break;
                case 6:
                    Console.WriteLine("June has 30 days.");
                    break;
                case 7:
                    Console.WriteLine("July has 31 days.");
                    break;
                case 8:
                    Console.WriteLine("August has 31 days.");
                    break;
                case 9:
                    Console.WriteLine("September has 30 days.");
                    break;
                case 10:
                    Console.WriteLine("October has 31 days.");
                    break;
                case 11:
                    Console.WriteLine("November has 30 days.");
                    break;
                case 12:
                    Console.WriteLine("December has 31 days.");
                    break;
                default:
                    Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
                    break;
            }
           */
            #endregion

            #region Write a program to create a Simple Calculator
            /*
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result = " + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result = " + result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result = " + result);
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result = " + result);
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }*/

            #endregion

            #region 13- Write a program to allow the user to enter a string and print the REVERSE of it.
            /*
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            char[] charOfString = input.ToCharArray();
            Array.Reverse(charOfString);
            string reversed = new string(charOfString);

            Console.WriteLine("Reversed string: " + reversed);
            */
            #endregion

            #region 14-	Write a program to allow the user to enter int and print the REVERSED of it.
            /*
            Console.Write("Enter an integer: ");
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            int sign = num < 0 ? -1 : 1;
            num = Math.Abs(num);
            int reversed = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num = num / 10;
            }
            reversed *= sign;

            Console.WriteLine("Reversed number: " + reversed);
            */
            #endregion

            #region 15-	 Write a program in C# Sharp to find prime numbers within a range of numbers.
            /*
            Console.Write("Enter the starting number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending number: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Prime numbers between {start} and {end}:");

            for (int num = start; num <= end; num++)
            {
                bool isPrime = true;

                if (num <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(num);
                }
            }
            */


            #endregion

            #region 16-	. Write a program in C# Sharp to convert a decimal number into binary without using an array.
            /*
            Console.Write("Enter a decimal number: ");
            int num = int.Parse(Console.ReadLine());

            string binary = "";

            if (num == 0)
            {
                binary = "0";
            }
            else
            {
                while (num > 0)
                {
                    int remainder = num % 2;
                    binary = remainder + binary;
                    num = num / 2;
                }
            }
            Console.WriteLine("Binary representation: " + binary);
        */


            #endregion

            #region 17-	Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line. And mention what will happen 
            /*
            Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("Enter x3: ");
            double x3 = double.Parse(Console.ReadLine());

            Console.Write("Enter y3: ");
            double y3 = double.Parse(Console.ReadLine());

            double left = (y2 - y1) * (x3 - x2);
            double right = (y3 - y2) * (x2 - x1);

            if (left == right)
            {
                Console.WriteLine("The points lie on the same straight line.");
            }
            else
            {
                Console.WriteLine("The points do NOT lie on the same straight line.");
            }
            */
            #endregion

            #region 18 -    Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            //-If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //- If the worker takes more than 5 hours, they are required to leave the company.
            //  To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            /*
            Console.Write("Enter time taken to complete the task (in hours): ");
            double hours = double.Parse(Console.ReadLine());

            if (hours >= 2 && hours <= 3)

                Console.WriteLine("The worker is highly efficient.");

            else if (hours > 3 && hours <= 4)

                Console.WriteLine("The worker should increase their speed.");

            else if (hours > 4 && hours <= 5)

                Console.WriteLine("The worker needs training to improve speed.");

            else if (hours > 5)

                Console.WriteLine("The worker should leave the company.");

            else

                Console.WriteLine("Invalid input. Time should be 2 hours or more.");


            */

            #endregion

            #region 19-	. Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            /*
            Console.Write("Enter the size of the identity matrix: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Identity matrix of size {n} x {n}:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region 20-      Write a program in C# Sharp to find the sum of all elements of the array.
            /*
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }

            Console.WriteLine("The sum of all elements is: " + sum);

            */
            #endregion

            #region 21-	 Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order
            /*
            Console.Write("Enter the size of the arrays: ");
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];
            int[] mergedArray = new int[2 * n];

            Console.WriteLine("Enter elements of the first array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements of the second array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                mergedArray[i] = array1[i];
                mergedArray[n + i] = array2[i];
            }

            Array.Sort(mergedArray);

            Console.WriteLine("Merged and sorted array:");
            foreach (int item in mergedArray)
            {
                Console.Write(item + " ");
            }
            */


            #endregion

            #region 22-	 Write a program in C# Sharp to count the frequency of each element of an array.
            /*
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            Console.WriteLine("\nFrequency of each element:");
            foreach (var pair in freq)
            {
                Console.WriteLine($"Element {pair.Key} occurs {pair.Value} time(s)");
            }
            */
            #endregion

            #region 23-	 Write a program in C# Sharp to find maximum and minimum element in an array
            /*
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine($"Maximum element: {max}");
            Console.WriteLine($"Minimum element: {min}");
            */
            #endregion

            #region 24-	 Write a program in C# Sharp to find the second largest element in an array
            /*
            int[] arr = { 1, 2, 3, 5, 10, 17, 12 };

            if (arr.Length < 2)
            {
                Console.WriteLine("Array must contain at least two elements.");
                return;
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }

            if (secondLargest == int.MinValue)
            {
                Console.WriteLine("There is no distinct second largest element.");
            }
            else
            {
                Console.WriteLine("The second largest element is: " + secondLargest);
            }
        */


            #endregion

            #region 25-	Consider an Array of Integer values with size N, having values as  in this Example

            /*

    write a program find the longest distance between Two equal cells. In this example. The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3).

    In the example above, the longest distance is between the first 7 and the
    10th 7, with a distance of 8 cells, i.e. the number of cells between the 1st
    And the 10th 7s.

    Note:
    - Array values will be taken from the user
    - If you have input like 1111111 then the distance is the number of
    Cells between the first and the last cell.

             */
            /*

            Console.Write("Enter the size of the array (N): ");
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];
            Console.WriteLine($"Enter {N} integer values:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Element {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, int> firstIndex = new Dictionary<int, int>();
            int maxDistance = -1;
            int valueWithMaxDistance = -1;

            for (int i = 0; i < N; i++)
            {
                int val = arr[i];

                if (!firstIndex.ContainsKey(val))
                {
                    firstIndex[val] = i;
                }
                else
                {
                    int distance = i - firstIndex[val] - 1;
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        valueWithMaxDistance = val;
                    }
                }
            }

            if (maxDistance >= 0)
            {
                Console.WriteLine($"The longest distance is {maxDistance} cells between first and last occurrence of value {valueWithMaxDistance}.");
            }
            else
            {
                Console.WriteLine("No repeated elements found in the array.");
            }
        */




            #endregion

            #region 26-	 Given a list of space separated words, reverse the order of the words.
            /*
            Input: this is a test       Output: test a is this
            Input: all your base        Output: base your all
            Input: Word Output: Word
            */


            /*
            Console.WriteLine("Enter a list of space-separated words:");
            string input = Console.ReadLine();

            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);
            string reversed = string.Join(" ", words);

            Console.WriteLine("Reversed words:");
            Console.WriteLine(reversed);
        }
        */

            #endregion

            #region 27-	Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            /*
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] firstArray = new int[rows, cols];
            int[,] secondArray = new int[rows, cols];

            // Input values into the first array
            Console.WriteLine("Enter the elements of the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    firstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Copy elements to the second array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    secondArray[i, j] = firstArray[i, j];
                }
            }

            // Print the second array
            Console.WriteLine("\nSecond array (copy of the first array):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(secondArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        */



            #endregion

            #region 28-	Which of the following is the correct output for the C# code given below?
            /*

            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            // Input values
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element [{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Print in reverse order
            Console.WriteLine("\nArray elements in reverse order:");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        */
            #endregion

            #region 29- Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
            /*
            Console.Write("Enter the temperature in degrees: ");
            double temp = double.Parse(Console.ReadLine());

            string result = (temp < 10) ? "Just Cold"
                          : (temp > 30) ? "Just Hot"
                          : "Just Good";

            Console.WriteLine($"The temperature is: {result}");

            */
            #endregion

            #region 30-	What will be the output of the C# code given below?

            int num = 1, z = 5;


            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);


            // 7 , 7



            #endregion


        }
    }
}