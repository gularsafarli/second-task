using System;

namespace Second_Task_in_academy
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        #region Method1 Verilmiş M dəyərindən verilmiş N dəyərinədək 21-ə bölünən ədədlərin ədədi ortasını tapan metod
        //static string anyth(int number1, int number2)
        //{
        //    int sum = 0;
        //    int count = 0;

        //    for (int i = number1; i < number2; i++)
        //    {
        //        if (i % 21 == 0)
        //        {
        //            sum += i;
        //            count++;
        //        }
        //    }
        //    if (count == 0)
        //    {
        //        return "21=e bolunen eded yoxdur";
        //    }
        //    else
        //    {

        //        return sum / count

        //    }
        // Note:Burada sum/count error verdiyi ucun saxladim.
        //}
        #endregion

        #region Method2 Verilmiş N tam ədədinin rəqəmləri cəmini tapan metod

        //static int findsumpfnumbers(int number)
        //{
        //    int sum = 0;
        //    while (number > 0)
        //    {
        //        var LastDigit = number % 10;
        //        sum += LastDigit;
        //        number = (number - LastDigit % 10) / 10;
        //    }
        //    return sum;

        //}

        #endregion

        #region Method3 Verilmis yazıda a herfi olub olmadigini tapan metod
        //static bool hasaletter(string word)
        //{
        //    bool hasaletter = false;

        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i]=='a')
        //        {
        //            hasaletter = true;
        //            break;
        //        }
                
        //    }
        //    if (hasaletter==true)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        #endregion
    }
}