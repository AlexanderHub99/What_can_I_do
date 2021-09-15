using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
using Microsoft.EntityFrameworkCore;

namespace What_can_I_do_.Models
{
    public class CheckPIN 
    {
        


        public static string ValidatePin(string _CheckPIN )
        {
            
            string result = null;
            if (_CheckPIN == null)
            {
                result = "";
                return result;
            }

            if (_CheckPIN != null)
            {
                if (_CheckPIN.Length == 4 || _CheckPIN.Length == 6)
                {
                    if (_CheckPIN.All(c => c >= '0' && c <= '9'))
                    {

                        result = "pin code is correct";
                        return result;
                    }
                    else
                        result = "PIN is incorrect";
                    return result;
                }
                else
                    result = "PIN is incorrect";
                return result;
            }
            else
                result = "PIN is incorrect";
            return result;
        }

        public class MovieDBContext : DbContext
        {
            public DbSet<CheckPIN> Movies { get; set; }
        }


    }
}
