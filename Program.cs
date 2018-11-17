using System;
using System.Collections.Generic;

namespace Projectcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText(@"test.txt");

            char[] chss = input.ToCharArray();

          //  List<char> output = new List<char>();
            //output.Add(char.Parse(chss[0].ToString().ToUpper()));
            String test = chss[0].ToString().ToUpper();
                






            for (int i = 1; i < chss.Length;i++){


                if (Char.IsPunctuation(chss[i])) {
                    if(chss[i].Equals('.')){
                       // output.Add(chss[i]);
                        if (chss[i+1].Equals('.'))
                        {
                            test += chss[i];
                            test += '\n';
                            test += chss[i + 2].ToString().ToUpper();
                            i+=2;
                          //  output.Add('\n');
                           // output.Insert(output.Count,'\n');
                          //  output.Remove(output.Find(x => x.Equals(chss[i + 1])));



                        }
                        else{
                            //  output.Remove(output.Find(x=> x.Equals(chss[i+1])));
                            //  output.Insert(i + 1, char.Parse(chss[i+1].ToString().ToUpper()));
                            test += chss[i];
                            test += ' '; 
                            test += chss[i+1].ToString().ToUpper();

                            i++;
                            //  output.Add(char.Parse(chss[i + 1].ToString().ToUpper()));
                        }


                    }
                  if(
                       chss[i].Equals(',')||
                       chss[i].Equals(':')||
                       chss[i].Equals(';')||
                      chss[i].Equals('!')||
                      chss[i].Equals('?'))
                    {
                        test += chss[i];
                        test += ' ';
                    
                    }
                
                }

                else if(char.IsWhiteSpace(chss[i])){
                    if (char.IsWhiteSpace(chss[i+1]))
                    {
                        i++;
                    }
                    else{
                        test += ' ';
                    }
                }

                else{
                    test += chss[i];
                  //  output.Add(chss[i]);
                } 



            }
            if (chss[chss.Length-1].Equals('.') == false)
            {
                test += '.';
             //   output.Insert(output.Count, '.');
            }





            Console.WriteLine(test);




        }
    }
}
