using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace TestToFinishC
{
  internal class Program
  {
    static void Main(string[] args)
    {
         Loop();
         Console.ReadKey();
    }
    static void Loop()
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        int j=0;

        for ( int i =0; i <50 ; i ++,j++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("đm đĩ tin =))");
            Console.WriteLine("IQ của tin sau mỗi một năm:");
            Console.WriteLine("IQ năm {0} :  {1} ",i,50-j);

           
            


        }
        

    }
  }

}
