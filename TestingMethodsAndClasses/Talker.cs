using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingMethodsAndClasses
{
    class Talker
        //Simple class, with static method BlaBlaBla, with string and int parameter.

        
    {
        public static int BlaBlaBla (string thingsToSay, int numberOfTimes) // 
        {
            string finalString = ""; //Creating empty string variable
            int decreaser = 0; //My variable used to cancel the "\ n" effect. So finalString.Lenght gives properly value which not include enter as character
            for (int count = 1; count <= numberOfTimes; count ++) // Loop which repeat words as many times as user wants (max value 10)
            {
                finalString = finalString + thingsToSay + "\n"; 
                decreaser++;
            }
            MessageBox.Show(finalString);
            return finalString.Length - decreaser;

         
        }
    }
}
