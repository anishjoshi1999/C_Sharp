using System;
class A
{
    public virtual void Print()
    {
        Console.WriteLine("A Implementation");
    }
}
class B: A
{
    public override void Print()
    {
        Console.WriteLine("B Implementation");
    }
}
class C : A
{
    public override void Print()
    {
        Console.WriteLine("C Implementation");
    }
}

class D : B,C
{
   
}
