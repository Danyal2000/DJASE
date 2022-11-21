using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJASE
{
    public class Syntax
    {
        public string err1 = "";

        public string SynCheck(string command)
        {
            Commands C1 = new();
            string[] ar = Commands.Inputarr(command);
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



                        }
                        else if (s1.Length < 2)
                        {
                            throw new IndexOutOfRangeException();
                        }
                    }

                    else if (s1[0].Equals("rect") == true)
                    {


                        string[] s2 = s1[1].Split(',');
                        if (s1.Length != 2)
                        {
                            throw new IndexOutOfRangeException();
                        }
                        if (s2.Length != 2)
                        {
                            throw new IndexOutOfRangeException();
                        }
                        else
                        {
                            int w = Convert.ToInt32(s2[0]);
                            int h = Convert.ToInt32(s2[1]);


                        }
                    }
                    else if (s1[0].Equals("circle") == true)
                    {


                        if (s1.Length != 2)
                        {
                            throw new IndexOutOfRangeException();
                        }
                        else
                        {
                            int w = Convert.ToInt32(s1[1]);

                        }
                    }
                    else if (s1[0].Equals("tri") == true)
                    {


                        if (s1.Length != 2)
                        {
                            throw new IndexOutOfRangeException();
                        }

                        else
                        {
                            int h = Convert.ToInt32(s1[1]);



                        }
                    }
                    else if (s1[0].Equals("moveto") == true)
                    {
                        if (s1.Length != 2)
                        {
                            throw new IndexOutOfRangeException();
                        }

                        string[] s2 = s1[1].Split(',');
                        if (s2.Length != 2)
                        {
                            throw new IndexOutOfRangeException();
                        }
                        else
                        {
                            int x = Convert.ToInt32(s2[0]);
                            int y = Convert.ToInt32(s2[1]);

                        }
                    }
                    else if (s1[0].Equals("drawto") == true)
                    {
                        if (s1.Length != 2)
                        {
                            throw new IndexOutOfRangeException();
                        }

                        string[] s2 = s1[1].Split(',');
                        if (s2.Length != 2)
                        {
                            throw new IndexOutOfRangeException();
                        }
                        else
                        {
                            int x = Convert.ToInt32(s2[0]);
                            int y = Convert.ToInt32(s2[1]);

                        }
                    }
                    else if (s1[0].Equals("clear") == true)
                    {
                        if (s1.Length != 1)
                        {
                            throw new InvalidOperationException();
                        }
                        else
                        {

                        }
                    }
                    else if (s1[0].Equals("run") == true)
                    {
                        if (s1.Length != 1)
                        {
                            throw new InvalidOperationException();
                        }

                    }
                    else if (s1[0].Equals("reset") == true)
                    {
                        if (s1.Length != 1)
                        {
                            throw new InvalidOperationException();
                        }
                        else
                        {

                        }

                    }
                    else if (s1[0].Equals("fill") == true)
                    {
                        if (s1.Length != 2)
                        {
                            throw new IndexOutOfRangeException();
                        }
                        else
                        {
                            if (int.TryParse(s1[1], out int tmp))
                            {
                                throw new FormatException();
                            }
                            else if (s1[1].Equals("on") == false
                                && s1[1].Equals("off") == false)
                            {
                                throw new InvalidOperationException();
                            }
                            else
                            {

                            }
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }


                    if (ln == 0)
                    {
                        throw new InvalidOperationException();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    err[i] = "command missing/excessive <width> or <height> or <color> on line" + " " + (i + 1);
                }
                catch (FormatException)
                {
                    err[i] = "command <width>,<height> or <color> incorrect format on line" + " " + (i + 1);
                }
                catch (InvalidOperationException)
                {
                    err[i] = "Unknown command on line" + " " + (i + 1);
                }
               
            }
           
            if (err != null && err.All(s => string.IsNullOrEmpty(s)))
            {
                err1 = "Syntax check completed succesfully";
                return err1;

            }
            else if(err!=null) 
            {
                err1 = string.Join("\n", err);
                return err1;

            }
            else
            {
                return err1;
            }

        }

    }
}
