Console.Clear();
string[] array = ReadStringArray();
string[] result = FindElements(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");
System.Console.WriteLine();

string[] ReadStringArray()                                        //метод ввода значений массива через запятую 
    {
        Console.Write("Введите значения массива через запятую: ");
        return Console.ReadLine().Split(",");
    }

int CountElements(string[] array, int n)                          //метод подсчета элементов массива удовлетворяющих условие
    {
        int count = 0;

        for(int i = 0; i < array.Length; i++) 
            {
                if(array[i].Length <= n) 
                    {
                        count++;
                    }
            }
        return count;
    }

string[] FindElements(string[] array, int n)                      //метод поиска элементов массива удовлетворяющих условие и добавления их в новый массив
    {
        string[] newArray = new string[CountElements(array, n)];

        for(int i = 0, j = 0; i < array.Length; i++) 
            {
                if(array[i].Length <= n) 
                    {
                        newArray[j] = array[i];
                        j++;
                    }
            }
        return newArray;
    }
