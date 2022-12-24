int[] myArray = Auto();
int count = 0;

for (int i = 0; i < myArray.Length; i++)
    {

        if (myArray[i] > 0)
        {
            count ++;
        }
    }
int[] Auto()
{
    int[] myArray;
    myArray = new int[5];
    for (int i = 0; i < myArray.Length; i++)
    {

        System.Console.WriteLine($"Введите значение элемента массива индекса {i}");
        myArray[i] = Convert.ToInt32(Console.ReadLine());

    }
    return myArray;
}
System.Console.WriteLine("Наш массив: [" + string.Join(", ", myArray) + "]");
System.Console.WriteLine($"Пользователь ввел {count} положительных чисел");

