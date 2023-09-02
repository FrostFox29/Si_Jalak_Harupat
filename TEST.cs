using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      
      int[] bebas = {-10,0,100,-1,3};
      
      for (int index = 0; index < bebas.Length; index++){
      
      if(bebas[index] < 0){
      		Console.WriteLine("Beku");
      }
      if(bebas[index] == 0){
      		Console.WriteLine("Normal");
      }
      if(bebas[index] > 0){
      		Console.WriteLine("Panas");
      }
     
     }
        
      
    }
  }
}