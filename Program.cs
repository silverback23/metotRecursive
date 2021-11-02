using System;

namespace Metotlar_Recursive
{
    class Program
    {
     public int Expo(int sayi,int üs)
     {
         if(üs<2)
          return sayi;
        return Expo(sayi,üs-1)*sayi;
     }        
    }
}
