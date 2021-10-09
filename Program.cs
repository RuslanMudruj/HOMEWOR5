using System;

namespace homewrok5
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inn = "#Чи можна #отримати# iнший результат, якщо #вiдмiнити# умову про вкладенiсть#";
            string[] inn = { "#Чи можна #отримати# iнший результат", "якщо #вiдмiнити# умову про вкладенiсть#" };
            Some_text obj = new Some_text(inn.Length, inn );
            obj.change_value();
           // Console.WriteLine(obj1.many_strings[0]);

            
            
               
        }



       

    }
}
