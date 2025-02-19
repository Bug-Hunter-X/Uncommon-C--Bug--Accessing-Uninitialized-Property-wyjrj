public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int initialValue)
    {
        MyProperty = initialValue; // Initialize in the constructor
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now safe to access
    }
}