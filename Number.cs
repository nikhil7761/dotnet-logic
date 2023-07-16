using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace primdfg{

class Number{

//#region we are search for prime numbers
public static void Main(string[]args)
{

Console.WriteLine("please enter the max no");

int nmaxnumber=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Prime number between {0} and {1} are:",2,nmaxnumber);

bool isPrimeNumber=true;

//this loop for checking maxnumber
for(int i=2;i<nmaxnumber;i++)
{

  for(int j=2;j<nmaxnumber;j++){

    if(i!=j && i%j==0)
    {
      isPrimeNumber=false;
      break;
    }

    if(isPrimeNumber){
        Console.WriteLine(i);
    }
     
   //  isPrimeNumber=true;

  }
    
}

Console.ReadLine();

}

}

}