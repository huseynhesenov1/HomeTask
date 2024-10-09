#region
//Console.Write("Bir ədəd daxil edin: ");
//string a = Console.ReadLine();

//char[] numbers = new char[a.Length];

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = a[i];

//}
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}
//for (int i = 0; i < numbers.Length - 1; i++)
//{
//    for (int j = 0; j < numbers.Length - i - 1; j++)
//    {
//        if (numbers[j] < numbers[j + 1])
//        {
//            char temp = numbers[j];
//            numbers[j] = numbers[j + 1];
//            numbers[j + 1] = temp;
//        }
//    }
//}
//string max = "";
//for (int i = 0; i < numbers.Length; i++)
//{
//    max += numbers[i];
//}

//// Nəticəni çıxarmaq
//Console.WriteLine("Yaranan ən böyük ədəd: " + max);
#endregion


#region n reqemli ededin rewemlerinden duzelmis en boyuk eded
//int a = 742148;
//int b = a;
//int k = 0;
//while (b>0)
//{
//    b = (b - b % 10) / 10;
//    k += 1;
//}

//int[] nums = new int[k];

//for (int i = 0; i < nums.Length; i++)
//{
//    nums[i]= a % 10 ;
//    a = (a - a % 10) / 10;
//}


//for (int i = 0; i < nums.Length-1; i++)
//{
//    for (int j = 0; j < nums.Length-i-1; j++)
//    {
//        if (nums[j] < nums[j+1])
//        {
//            int temp = nums[j];
//            nums[j] = nums[j+1];
//            nums[j+1] = temp;

//        }
//    }
//}

//int result = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    result = (result * 10) + nums[i];
//}
//Console.WriteLine(result);
#endregion


