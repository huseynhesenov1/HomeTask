namespace SplitReplaceLastIndexOf;

internal class Program
{
    static void Main(string[] args)
    {
        #region replace
        //string name = "leeeeeltac hesen amin";
        //char old = 'e';
        //char neww = 'E';
        //string replaceName = "";
        //int counter = 1;
        //foreach (var item in name)
        //{
        //    if (item != old)
        //    {
        //        replaceName += item;
        //    }
        //    if (item == old && counter <= 0)
        //    {
        //        replaceName += old;
        //    }
        //    if (item == old && counter > 0)
        //    {
        //        replaceName += neww;
        //        counter -= 1;
        //    }
        //}
        //Console.WriteLine(replaceName);
        #endregion


        #region  LastIndexof

        //string text = "hello world";
        //char searchChar = 'o';

        //int lastIndex=default;

        //for (int i = text.Length - 1; i >= 0; i--)
        //{
        //    if (text[i] == searchChar)
        //    {
        //        lastIndex = i;
        //        break;
        //    }
        //}

        //Console.WriteLine( lastIndex);
        #endregion




        #region SplitMethod

        string text = "acer,hp,asus,lenova";
        char separator = ',';
        int countPart = 1;

        foreach (char item in text)
        {
            if (item == separator)
            {
                countPart++;
            }
        }


        string[] result = new string[countPart];
        string part = "";
        int index = 0;

        foreach (char item in text)
        {
            if (item == separator)
            {
                result[index] = part;
                index++;
                part = "";
            }
            
            else
            {
                part += item;
            }
        }


        result[index] = part;


        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
#endregion