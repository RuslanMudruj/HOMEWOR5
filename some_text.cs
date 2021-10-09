using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text;

namespace homewrok5
{
    class Some_text
    {
       
        public string[] many_strings = new string[0];


        Some_text()
        {
            Console.WriteLine(1);


            string[] many_strings = new string[0];


        }
       public Some_text(int in_count, string[] in_many_strings)
        {
            try
            {
                
               many_strings = new string[in_count];
                
                this.many_strings = in_many_strings;
                ;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public Some_text add_strings(string[] in_many_strings)
        {


            Some_text obj1 = new Some_text(in_many_strings.Length, in_many_strings);
            return obj1;


        }

        public void  change_value()
        {
            char[] tmp = new char[1000];
            int n = 0;
            Console.WriteLine(many_strings.Length);
            for (int i = 0; i < many_strings.Length; i++)
            {

                many_strings[i].ToCharArray().CopyTo(tmp, n);
                n += many_strings[i].ToCharArray().Length;
                tmp[n] = ' ';
                n += 1;
                
            }


            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == '#')
                {
                    tmp[i] = '<';
                    for (int j = tmp.Length - 1; i < j; j--)
                    {

                        if (tmp[j] == '#')
                        {
                            tmp[j] = '>';
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(tmp);


        }
    }
}
