
/* Написать программу которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 симаола.
Первоначальный массисв можно ввести с клавиатуры, дибо задать на старте выполнения 
алгоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись иисключительно массивами. */

Console.WriteLine("Это программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна M символов");
Console.WriteLine("Введите длинну строки M");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длинну массива n");
int b = int.Parse(Console.ReadLine());

string[] array1 = new string[b];
int count = 0;
for (int i = 0; i < b  ; i++)
{
    Console.WriteLine("Введите  строку: ");
    array1[i] = Console.ReadLine();
    if (array1[i].Length <= a){
        count ++ ;
    }
}
int count2 = 0;
string[] result_array = new string[count];
for (int i = 0; i < array1.Length; i++){
    if(array1[i].Length <= a){
        result_array[count2] = array1[i];
        count2 ++ ;
    }
}

Console.WriteLine($"[{string.Join(", ", result_array)}]");