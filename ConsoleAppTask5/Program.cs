namespace ConsoleAppTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region T1
            //int sum = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //if (sum % 7 == 0)
            //{
            //    Console.WriteLine("1-den 1000-e qeder butun ededlerin cemi 7-ye bolunur");
            //}
            #endregion
            #region T2
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 7 == 0 && i % 8 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region T3
            //for (int i = 1; i <= 1000; i++)
            //{
            //    int sum = 0;
            //    int demo = i;
            //    while (demo != 0)
            //    {
            //        sum += demo % 10;
            //        demo /= 10;
            //    }
            //    if (sum % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region T4
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 10 != 3)
            //    {
            //        int sum = 0;
            //        int demo = i;
            //        while (demo != 0)
            //        {
            //            sum += demo % 10;
            //            demo /= 10;
            //        }
            //        if (sum % 3 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion
            #region T5
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        int sum = 0;
            //        int demo = i;
            //        while (demo != 0)
            //        {
            //            sum += demo % 10;
            //            demo /= 10;
            //        }
            //        if (sum % 5 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion
            #region T6
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        int sum = 0;
            //        int demo = i;
            //        while (demo != 0)
            //        {
            //            sum += demo % 10;
            //            demo /= 10;
            //        }
            //        if (sum % 2 != 0)
            //        {
            //            int demo1 = i;
            //            while (demo1 >= 10)
            //            {
            //                demo1 /= 10;
            //            }
            //            if (demo1 % 2 != 0)
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }
            //    }
            //}
            #endregion
            #region T7
            //for (int i = 1; i <= 1000; i++)
            //{
            //    bool cont = false;
            //    int num = i;
            //    while (num > 0)
            //    {
            //        int digit = num % 10;
            //        if (digit == 3)
            //        {
            //            cont = true;
            //            break;
            //        }
            //        num /= 10;
            //    }
            //    if (!cont)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region T8
            //int max = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    int sum = 0;
            //    int demo = i;
            //    while (demo != 0)
            //    {
            //        sum += demo % 10;
            //        demo /= 10;
            //    }
            //    if (sum == 3)
            //    {
            //        bool cont = false;
            //        int num = i;
            //        while (num > 0)
            //        {
            //            int digit = num % 10;
            //            if (digit == 3)
            //            {
            //                cont = true;
            //                break;
            //            }
            //            num /= 10;
            //        }
            //        if (!cont)
            //        {
            //            if (i > max)
            //            {
            //                max= i;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(max);
            #endregion
            #region T9
            //int counter = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 11 == 0)
            //    {
            //        int sum = 0;
            //        int demo = i;
            //        while (demo != 0)
            //        {
            //            sum += demo % 10;
            //            demo /= 10;
            //        }
            //        if (sum > 11)
            //        {
            //            counter++;
            //            if (counter == 11)
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }
            //    }
            //}
            #endregion
            #region T10
            //int max = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        int sum = 0;
            //        int demo = i;
            //        while (demo != 0)
            //        {
            //            sum += demo % 10;
            //            demo /= 10;
            //        }
            //        if (sum >= 5 && sum <=7)
            //        {
            //            if (i > max)
            //            {
            //                max = i;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(max);
            #endregion
            #region T11
            //for (int i = 1; i <= 1000; i++)
            //{
            //    bool cont = false;
            //    int num = i;
            //    while (num > 0)
            //    {
            //        int digit = num % 10;
            //        if (digit == 3)
            //        {
            //            cont = true;
            //            break;
            //        }
            //        num /= 10;
            //    }
            //    if (!cont)
            //    {
            //        int sum = 0;
            //        int demo = i;
            //        while (demo != 0)
            //        {
            //            sum += demo % 10;
            //            demo /= 10;
            //        }
            //        if (sum > 11)
            //        {
            //            bool cont1 = false;
            //            int demo1 = i;
            //            string strNum = demo1.ToString();
            //            int left = 0;
            //            int right = strNum.Length - 1;
            //            while (left < right)
            //            {
            //                if (strNum[left] != strNum[right])
            //                {
            //                    cont1= true;
            //                    break;
            //                }
            //                left++;
            //                right--;
            //            }
            //            if (!cont1) 
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }
            //    }
            //}
            #endregion
            #region T12
            //for (int i = 1; i <= 1000; i++)
            //{
            //    int sum = 0;
            //    int demo = i;
            //    while (demo != 0)
            //    {
            //        sum += demo % 10;
            //        demo /= 10;
            //    }
            //    if (sum > 5)
            //    {
            //        bool cont = false;
            //        int num = i;
            //        while (num > 0)
            //        {
            //            int digit = num % 10;
            //            if (digit == 5)
            //            {
            //                cont = true;
            //                break;
            //            }
            //            num /= 10;
            //        }
            //        if (!cont && i > 9)
            //        {
            //            bool cont1 = false;
            //            int num1 = i;
            //            int digit = num1 % 10;
            //            while (num1 > 0)
            //            {
            //                if (num1 % 10 != digit)
            //                {
            //                    cont1 = true;
            //                    break;
            //                }
            //                num1 /= 10;
            //            }
            //            if (!cont1)
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }
            //    }
            //}
            #endregion
            #region T13
            //for (int i = 1; i <= 1000; i++)
            //{
            //    bool cont = false;
            //    int num = i;
            //    while (num > 0)
            //    {
            //        int digit = num % 10;
            //        if (digit == 5 && digit % 2 != 0)
            //        {
            //            cont = true;
            //            break;
            //        }
            //        num /= 10;
            //    }
            //    if (cont)
            //    {
            //        bool cont1 = false;
            //        int demo1 = i;
            //        string strNum = demo1.ToString();
            //        int left = 0;
            //        int right = strNum.Length - 1;
            //        while (left < right)
            //        {
            //            if (strNum[left] != strNum[right])
            //            {
            //                cont1 = true;
            //                break;
            //            }
            //            left++;
            //            right--;
            //        }
            //        if (!cont1)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion
            #region T14
            //int number1, qaliq, count1, count2, sum, number2;
            //for (int i = 100; i <100001 ; i++)
            //{
            //    count1 = 0;
            //    count2 = 0;
            //    qaliq = i % 10;
            //    number1 = i;
            //    while(number1 > 0)
            //    {
            //        if (number1 % 10 == 6)
            //        {
            //            break;
            //        }
            //        if(number1 % 100 == 11)
            //        {
            //            count2 = 2;
            //        }
            //        if (number1 % 10 == 5)
            //        {
            //            count1++;
            //        }
            //        number1/=10;
            //    }
            //    if (count2 == 2 && count1 == 2)
            //    {
            //        number2 = i;
            //        sum = 0;
            //        while (number2 > 0)
            //        {
            //            sum += number2 % 10;
            //            number2 /= 10;
            //        }
            //        if (sum > 7 && sum < 15)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion
            #region T15
            //for (int i = 1; i <= 1000; i++)
            //{
            //    int sum = 0;
            //    int demo = i;
            //    while (demo != 0)
            //    {
            //        sum += demo % 10;
            //        demo /= 10;
            //    }
            //    bool cont = false;
            //    int num = sum;
            //    while (num > 0)
            //    {
            //        int digit = num % 10;
            //        if (digit == 2)
            //        {
            //            cont = true;
            //            break;
            //        }
            //        num /= 10;
            //    }
            //    if (!cont)
            //    {
            //        bool cont1 = false;
            //        int num1 = i;
            //        while (num1 > 0)
            //        {
            //            int digit = num1 % 10;
            //            if (digit == 0 || digit == 1 || digit == 5 || digit == 7 || digit == 9)
            //            {
            //                cont1 = true;
            //                break;
            //            }
            //            num1 /= 10;
            //        }
            //        if (!cont1)
            //        {
            //            bool cont2 = false;
            //            int number = i;
            //            int half = number / 2;
            //            for (int j = 2; j <= half; j += 2)
            //            {
            //                if (number % j == 0)
            //                {
            //                    cont2 = true;
            //                    break;
            //                }
            //            }
            //            if (!cont2)
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }
            //    }
            //}
            #endregion
        }
    }
}