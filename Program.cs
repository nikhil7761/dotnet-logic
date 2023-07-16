namespace grow{

class flower{

public static void Main(string[]args){

Console.WriteLine("Enter the number");

int number=Convert.ToInt32(Console.ReadLine());
int Reverse=0;

while(number!=0)
{
    Reverse=Reverse*10;
    Reverse=Reverse+number%10;
    number=number/10;
}

Console.WriteLine("reverse no is:"+Reverse);

}


}




















}