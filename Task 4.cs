using System;

class MyClass
{
    
    public const int MyConst = 10;

    
    public readonly int MyReadOnly;

    public MyClass(int value)
    {
        
        MyReadOnly = value;
    }

    public void Display()
    {
        Console.WriteLine("Const Value: " + MyConst);
        Console.WriteLine("Readonly Value: " + MyReadOnly);
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass(20);
        obj.Display();
    }
}

