using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankTest3
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Please, enter a value! ");
        
            int userInputNumber =Convert.ToInt32( Console.ReadLine());
        
            if (userInputNumber % 2 == 0)  //If it is an even number then...
            {
                if( 2 <= userInputNumber &&  userInputNumber <= 5)
                {
                    Console.WriteLine("It's an even number and it is Not Weird! ");
                }
          
                if( 6 <= userInputNumber &&  userInputNumber <= 20)
                {
                    Console.WriteLine("It's an even number and it is WEIRD! ");
                }
                
                if( 20 <= userInputNumber)
                {
                    Console.WriteLine("It's an even number and it is Not Weird! ");
                }  
         
            }   
        
            else  //else, if it is an odd number then...
            {
                Console.WriteLine("It's an odd number, and it is WEIRD! ");
            
            }

            Console.ReadKey();
        }

        
    }
}
