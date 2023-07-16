namespace unity{


class Future
{

public virtual int Add(int x, int y)
{
    int q=x+y;
    return q ;
}

public virtual int Add(int x,int y,int z){
    return x+y+z;
}


static void Main(String[]args)
{

Future a=new Future();
int result=a.Add(12,34);

int result2=a.Add(23,12,12);


Console.WriteLine("Addition of 2 number"+result);

Console.WriteLine("addition of 3 number"+result2);


}



}
// class run:Future{
//         public override int Add(int x, int y)
//         {
//             return base.Add(x, y);
//         }

}
