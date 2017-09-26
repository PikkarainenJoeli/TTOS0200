using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    public class Teht1
    {
        public void CheckNumberMain()
        {
          
            
            Console.WriteLine("Give a number: ");
            string input = Console.ReadLine();

            Console.WriteLine("1 = is number   2 = is date");
            int selector = int.Parse(Console.ReadLine());
            bool result;
           

            switch(selector)
            {
                case 1:
                    result = CheckInput.IsNumber(input);
                    Console.WriteLine(result + " " + input);
                    break;

                case 2:
                    result = CheckInput.IsDate(input);
                    Console.WriteLine(result + " " + input);
                    break;

                


            }
            
        }
        
    }

    public class CheckInput
    {

           public static bool IsNumber(string input)
            {
                    bool boolIsNumber;
                    double b = 0;
                    boolIsNumber = double.TryParse(input, out b);
                    char[] charArray= input.ToCharArray(0,input.Length);

                    int separator = 0;
                    for(int i = 0;i < charArray.Length; i++)
                    {
                        if (charArray[i] == ','|| charArray[i] == '.')
                        {
                            separator++;
                        }
                    }
                    if(separator > 1)
                    {
                        boolIsNumber = false;
                    }
            
                    return boolIsNumber;
            }

        public static bool IsDate(string input)
        {
            bool boolIsDate = true;
            string[] FormatDate = input.Split('.');

            char[] charArray = input.ToCharArray(0, input.Length);
            int separator = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '.')
                {
                    separator++;
                }
            }
                if (separator != 2)
                {
                    boolIsDate = false;
                }
                    else
                    {
                        int day = int.Parse(FormatDate[0]);
                        int month = int.Parse(FormatDate[1]);
                        int year = int.Parse(FormatDate[2]);
                        int[] daysInMonth = new int[12]{31,28,31,30,31,30,31,31,30,31,30 ,31};
                        
                            for(int i = 0; i < daysInMonth.Length; i++)
                                    {
                                        if(day > daysInMonth[i] || day < 0)
                                            {
                                                boolIsDate = false;
                                            }
                                    }

                                        if(month > 12 || month < 0)
                                                {
                                                boolIsDate = false;
                                                }
                    }

            return boolIsDate;
        }
    }

}
