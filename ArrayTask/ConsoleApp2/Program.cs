 
#region en boyuk cut eded
//int[] numbers = { 1, 2, 3, 4, 6,8 };
//int maxNum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > maxNum  && numbers[i]%2 ==0 )
//    {
//        maxNum = numbers[i] ;
//    }
//}
//if (maxNum == 0)
//{
//    Console.WriteLine("arrayda cut edede rast gelinmedi");
//}
//else
//{
//Console.WriteLine("en boywk cut eded "+ maxNum);
//}

#endregion


#region en kicik tek eded
//int[] numbers = [ 2, 3, 4, 5, 6, 7 ];
//int minNum = 0;

//foreach (int num in numbers)
//{
//    if (num %2 != 0)
//    {
//        minNum = num;
//        break;
//    }
//}
//if (minNum == 0)
//{
//    Console.WriteLine("arrayda tek eded yoxdur");
//}
//else
//{
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (minNum > numbers[i] && numbers[i] % 2 == 1)
//        {
//            minNum = numbers[i];
//        }
//    }
//    Console.WriteLine(minNum);
//}
#endregion



#region reverse
//int[] numbers = [2, 9, 4, 5, 6];
//int[] numbersReverse = new int[numbers.Length];
//int indexReverse = default;

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbersReverse[i] = numbers[(numbers.Length - 1) - i];

//}
//foreach (int item in numbers)
//{
//    Console.WriteLine(item + " ");

//}
//Console.WriteLine("----------------------");
//foreach (int item in numbersReverse)
//{
//    Console.WriteLine(item + " ");

//}


#endregion 


#region Arrayda verilmis ededin sayi
//int[] numbers = [1, 4, 3, 4, 5,4];
//int num = 4;
//int counter = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] == num)
//    {
//        counter++;
//    }
//}
//if (counter == 0)
//{
//    Console.WriteLine("Verilmis eded arrayda yoxdur");
//}
//else
//{

//Console.WriteLine("Arrayda verilmis ededin sayi: "+ counter);
//}

#endregion

#region Verilmiş array-ın elementlərinin sayının tapılması.
//int[] numbers = [1,2,3,4,5,6,7,4];
//int counter = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    counter = counter + 1;
//}
//Console.WriteLine(counter);
#endregion

#region arrayda elementin yer alib-almamasi
int[] numbers = [1, 2, 3, 4, 5, 5, 6, 7];
int num = 5;
int counter = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == num)
    {
        counter = counter + 1;
    }

}
if (counter != 0)
{
    Console.WriteLine("eded arrayda " + counter + " defe yer alib");
}
else
{   
    Console.WriteLine("eded arrayda yer almayib");
}
#endregion