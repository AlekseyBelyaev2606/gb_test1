// See https://aka.ms/new-console-template for more information
Console.Clear();

string [] array = new string [3];
AddString(array);
System.Console.WriteLine("Значения из массива меньше или равны 3 символам:");
ShowResults(array);

void AddString (string [] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.WriteLine("Введите значение массива №" + (i+1));
        arr[i] = Console.ReadLine();
    }
}

void ShowResults (string [] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i].Length < 4){
            System.Console.WriteLine(arr[i]);
        }
    }
}