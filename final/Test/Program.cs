//Задача: Написать программу, которая из имеющегося массива строк формирует
//новый массив из строк, длина которых меньше,
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 

string [] array_1 = new string[4]{"hello"  , "2" ,"world", "yess"};
string [] array_2 = new string [array_1.Length];
void Creating (string[] array_1, string[] array_2)
{
    int count = 0;
    for (int i = 0; i < array_1.Length; i++)
    {
        if (array_1[i].Length<=3)
        {
            array_2[i]=array_1[i];
            count++;
        }
    }
}