using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJASE
{
    public class Parser
    {
        Canvass c;

        

        public Parser(Canvass MyCanvas)
        {
            this.c = MyCanvas;

        }
        public void Parse(string command)
        {


            Commands C1 = new Commands();
            string[] ar = C1.inputarr(command);
            int ln = ar.Length;
            string[] err = new string[ar.Length];





            for (int i = 0; i < ln; i++)
            {

                try
                {



                    String txt = ar[i];
                    string[] s1 = txt.Split(' ');


                    if (s1[0].Equals("pen") == true)
                    {


                        if (s1.Length == 2)
                        {
                            if (int.TryParse(s1[1], out int tmp))
                            {
                                throw new FormatException();
                            }
                            string col = s1[1];
                            if (col.Equals("red") == false && col.Equals("green") == false
                               && col.Equals("blue") == false && col.Equals("black") == false &&
                               col.Equals("purple") == false && col.Equals("yellow") == false &&
                               col.Equals("pink") == false && col.Equals("magenta") == false &&
                               col.Equals("orange") == false && col.Equals("cyan") == false)
                            {
                                throw new IndexOutOfRangeException();
                            }

                            c.ChangeColor(col);

                        }
                        else if (s1.Length < 2)
                        {
                            throw new IndexOutOfRangeException();
                        }
                    }
                }
}
