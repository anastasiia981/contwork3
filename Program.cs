// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.


using System;



class Program

{
    static void Main()


    {

        int[] array = { 1, 2, 3, 4, 5 };
        
        PrintArrayReversely(array, array.Length - 1);

    }
    static void PrintArrayReversely(int[] array, int currentIndex)

    {

        if (currentIndex < 0)

        {
    
            return;

        }

        Console.WriteLine(array[currentIndex]);

        PrintArrayReversely(array, currentIndex - 1);

    }

}



        





        

        





        
