

#region Ədədin rəqəmlərinin cəmi
//int a = int.Parse(Console.ReadLine());
//int sum = (a / 100) + ((a / 10) % 10) + (a % 10);
//if ((sum%2)==0)
//{
//    Console.WriteLine("Ədədin rəqəmlərinin cəmi cütdür");

//}
//else
//{
//    Console.WriteLine("Ədədin rəqəmlərinin cəmi təkdir");
//}
#endregion


#region ededi_orta_4_reqemli
//int a = int.Parse(Console.ReadLine());
//double sum = (a / 1000) + ((a / 100) % 10) + ((a % 100)/10) + (a%10);
//double averageA = sum / 4;
//Console.WriteLine(averageA);
#endregion


#region 3 rəqəmli ədədin rəqəmləri cəminin 3-ə və 5-ə bölünüb-bölünmədiyinin tapılması
//int a = int.Parse(Console.ReadLine());
//int sum = (a / 100) + ((a / 10) % 10) + (a % 10);
//if (((sum % 3) == 0) && ((sum % 5) == 0))
//{
//    Console.WriteLine("Ədədin rəqəmlərinin cəmi 5-e ve 3-e bolunur");
//}
//else
//{
//    Console.WriteLine("Ədədin rəqəmlərinin cəmi 5-e ve 3-e bolunmur");
//}
#endregion



#region telebe_qiymeti_if_else

//int gpu = int.Parse(Console.ReadLine());
//if (gpu>100)
//{
//    Console.WriteLine("Neticeni duzgun daxil edin");
//}
//else if(gpu>90 && gpu<=100)
//{
//    Console.WriteLine("Siz A almisiz");
//}else if (gpu>80 && gpu <= 90)
//{
//    Console.WriteLine("Siz B almisiz");
//}
//else if (gpu > 70 && gpu <= 80)
//{
//    Console.WriteLine("Siz C almisiz");
//}
//else if (gpu > 60 && gpu <= 70)
//{
//    Console.WriteLine("Siz D almisiz");
//}
//else if (gpu > 50 && gpu <= 60)
//{
//    Console.WriteLine("Siz E almisiz");
//}
//else
//{
//    Console.WriteLine("Siz kesilmisiz");
//}

#endregion



#region telebenin_qiymeti_swich_case
//int gpu = int.Parse(Console.ReadLine());
//switch (gpu)
//{
//    case > 100 :
//        Console.WriteLine("Neticeni duzgun daxil edin");
//        break;

//    case >= 91 and < 100:
//        Console.WriteLine("A");
//        break;

//    case >= 81 and < 90:
//        Console.WriteLine("B");
//        break;

//    case >= 71 and < 80:
//        Console.WriteLine("C");
//        break;

//    case >= 61 and < 70:
//        Console.WriteLine("D");
//        break;

//    case >= 51 and < 60:
//        Console.WriteLine("E");
//        break;
//    default:
//        Console.WriteLine("siz kesilmisiz");
//        break;
//}
#endregion

#region 2 ədədin yoxlanışı.
//Console.WriteLine("Birinci ededi yazin");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Ikinci ededi yazin");

//int num2 = int.Parse(Console.ReadLine());
//int sum;
//int ferq;

//if ((num1 % 2 == 0) && (num2 % 2 == 0))
//{
//    sum = num1 + num2;
//    Console.WriteLine(sum);
//}
//else
//{
//    ferq = num1 - num2;
//    Console.WriteLine(ferq);

//}
#endregion


Console.WriteLine("Maasinizi daxil edin");
int salary = int.Parse(Console.ReadLine());
Console.WriteLine("Goturmek istediyiniz meblegi daxil edin");
int credit = int.Parse(Console.ReadLine());
int yearSalary = 12 * salary;
if (yearSalary*0.6>credit)
{
    Console.WriteLine("Siz kredit goture bilersiz");
}
else
{
    Console.WriteLine("Siz bu qeder kredit goture bilmessiz");
}