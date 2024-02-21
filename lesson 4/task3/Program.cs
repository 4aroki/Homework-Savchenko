//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)


 int[] array =  {1, 2, 3, 4, 5};
 int middle = array.Length / 2;
 for(int i = 0; i < middle; i++)
 {
    int swap = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = array [i];
    array[i] = swap;
 }

 for( int i = 0; i < array.Length; i++)
 {
    System.Console.Write(array[i] + " ");
 }
 