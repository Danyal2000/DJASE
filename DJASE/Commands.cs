using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJASE
{
    public class Commands
    {
        public static string[] Inputarr(string input)
        {
            string str = input.ToLower().Trim();

            string[] ar = str.Split('\n');
            return ar;
        }
    }
}

