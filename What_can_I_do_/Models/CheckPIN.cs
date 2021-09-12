using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace What_can_I_do_.Models
{
    public class CheckPIN 
    {


        public static string ValidatePin(string _CheckPIN )
        {

            if (_CheckPIN != null)
            {
                if (_CheckPIN.Length == 4 || _CheckPIN.Length == 6)
                {
                    if (_CheckPIN.All(c => c >= '0' && c <= '9'))
                    {
                        return "pin code is correct";
                    }
                    else
                        return "PIN is incorrect";
                }
                else
                    return "PIN is incorrect";
            }
            else
                return "PIN is incorrect";
        }


    }
}
