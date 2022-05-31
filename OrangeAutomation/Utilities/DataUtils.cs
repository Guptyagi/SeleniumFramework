using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.OrangeAutomation.Utilities
{
    public class DataUtils
    {
        /// <summary>
        /// Provide daTa to Invlid Credetial Tes
        /// </summary>
        /// <returns></returns>

        
        public static object[] InvalidTestData()
        {
            object[] temp1 = new object[3];
            temp1[0] = "John";
            temp1[1] = "John123";
            temp1[2] = "Invalid credentials";
            object[] temp2 = new object[3];
            temp2[0] = "Wick";
            temp2[1] = "Wick123";
            temp2[2] = "Invalid credentials";
            object[] temp3 = new object[3];
            temp3[0] = "Sara";
            temp3[1] = "Sara123";
            temp3[2] = "Invalid credentials";
            object[] temp4 = new object[3];
            temp4[0] = "Jene";
            temp4[1] = "Jene123";
            temp4[2] = "Invalid credentials";
            object[] main = new object[4];
            main[0] = temp1;
            main[1] = temp2;
            main[2] = temp3;
            main[3] = temp4;



            return main;
        }


    }
}
