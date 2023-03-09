// See https://aka.ms/new-console-template for more information
Console.Clear();

string [] array = new string [3];
AddString(array);
System.Console.WriteLine("Значения из массива меньше или равны 3 символам:");
ShowResults(Results(array));

void AddString (string [] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.WriteLine("Введите значение массива №" + (i+1));
        arr[i] = Console.ReadLine();
    }
}

string [] Results (string [] arr){
    int tempInt = 0;
    int tempI = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i].Length < 4){
            tempInt++;
        }
    }
    string [] tempArray = new string [tempInt];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i].Length < 4){
            tempArray[tempI] = arr[i];
            tempI++;
        }
    }
    return tempArray;
}

void ShowResults (string [] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}
