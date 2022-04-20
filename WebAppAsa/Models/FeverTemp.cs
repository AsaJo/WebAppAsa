using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAsa.Models
{
    public class FeverTemp
    {
        public static string TestForFever(float temperature)
        {
            //double dubbleTemp = new double();
            
            return (temperature > 37) ? "Doctor Vader says you have fever...have a cookie" : "Doctor Vader says you don't have any fever...so no cookie";
        }
    }

}
