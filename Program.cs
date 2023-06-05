// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int mes(string message){
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] InputArr(int Length){
    int[] array = new int[Length];
    for(int i =0; i<array.Length; i++){
        array[i]=mes($"Введите {i+1}-й элемент");
    }
    return array;
}
void PrintArr(int[] array){
    for(int i =0; i<array.Length; i++){
        Console.WriteLine($"a[{i}]={array[i]}");
    }
}
int CountPosNum(int[] array){
    int count = 0;
    for(int i = 0; i< array.Length; i++){
        if(array[i]>0){
            count+=1;
        }
    }
    return count;
}
int Length = mes("Введите количество элементов");
int[] array;
array = InputArr(Length);
PrintArr(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPosNum(array)}");