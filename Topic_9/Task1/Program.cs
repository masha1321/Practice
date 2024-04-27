namespace Task1
{ 
}
interface Ix
{
    void IxF0(int параметр);
    void IxF1();
}

interface Iy
{
    void F0(int параметр);
    void F1();
}

interface Iz
{
    void F0(int параметр);
    void F1();
}

class TestClass : Ix, Iy, Iz
{
    int w = 15;

    public void IxF0(int параметр)
    {
        Console.WriteLine($"IxF0: {параметр * w}");
    }

    public void IxF1()
    {
        Console.WriteLine("IxF1");
    }


    public void F0(int параметр)
    {
        Console.WriteLine($"Iy.F0: {параметр * w}");
    }

    public void F1()
    {
        Console.WriteLine("Iy.F1");
    }

    void Iz.F0(int параметр)
    {
        Console.WriteLine($"Iz.F0: {параметр * (2 * w - 3)}");
    }

    void Iz.F1()
    {
        Console.WriteLine("Iz.F1");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TestClass test = new TestClass();

        
        test.IxF0(10);
        test.IxF1();

        test.F0(10);
        test.F1(); 

        ((Ix)test).IxF0(10);
        ((Ix)test).IxF1();

        ((Iy)test).F0(10);
        ((Iy)test).F1();

        ((Iz)test).F0(10);
        ((Iz)test).F1();
    }
}
