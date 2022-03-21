using System;

namespace task4ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 56, 67, 89 };
            int number = 6;
            Add(ref arr, number);

            string name = "Hikmet Abbasov";
            WithoutSpace(ref name);


            sting numberstr = Console.ReadLine();
            int number = Convert.ToInt32(numberstr);
            SquareRoot(ref number);
        }
        static void Add(ref int[] arr, int number)
        {
            int[] newArr = new int[arr.Length + 1];
            newArr[arr.Length] = number;
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];

            }
            arr = newArr;

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
        static void WithoutSpace(ref string name)
        {
            string newName = " ";
            foreach (var item in name)
            {
                if (item != ' ')
                    newName += item;
            }
            name = newName;
            Console.WriteLine(name);

        }
        static void SquareRoot(ref int number)
        {
            if (number >= 0)
            {
                for (int i = 0; i <= number; i++)
                {
                    if (i * i == number)
                        number = i;
                    else if (i * i > number)
                        number = i - 1;

                }
            }
            Console.WriteLine(number);
        }
    }
}

