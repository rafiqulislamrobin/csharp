using System;
using System.Collections;

class GFG
{

    
    static bool Smaller(string str1, string str2)
    {
      
        int n1 = str1.Length, n2 = str2.Length;
        if (n1 < n2)
            return true;
        if (n2 < n1)
            return false;

        for (int i = 0; i < n1; i++)
            if (str1[i] < str2[i])
                return true;
            else if (str1[i] > str2[i])
                return false;

        return false;
    }
   static string Difference(string str1, string str2)
    {
       
        if (Smaller(str1, str2))
        {
            string t = str1;
            str1 = str2;
            str2 = t;
        }

       
        string result = "";

        
        int n1 = str1.Length, n2 = str2.Length;

       
        char[] char1 = str1.ToCharArray();
        Array.Reverse(char1);
        str1 = new string(char1);
        char[] char2 = str2.ToCharArray();
        Array.Reverse(char2);
        str2 = new string(char2);

        int carry = 0;

        for (int i = 0; i < n2; i++)
        {
      
            int sub = ((int)(str1[i] - '0')
                       - (int)(str2[i] - '0') - carry);

          
            if (sub < 0)
            {
                sub = sub + 10;
                carry = 1;
            }
            else
                carry = 0;

            result += (char)(sub + '0');
        }

        for (int i = n2; i < n1; i++)
        {
            int sub = ((int)(str1[i] - '0') - carry);

            if (sub < 0)
            {
                sub = sub + 10;
                carry = 1;
            }
            else
                carry = 0;

            result += (char)(sub + '0');
        }

        char[] char3 = result.ToCharArray();
        Array.Reverse(char3);
        return new string(char3);
    }

    public static void Main()
    {


        string number1 = Console.ReadLine();
        string number2 = Console.ReadLine();

        Console.WriteLine(Difference(number1,number2));
    }
}