namespace Lab1_N3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JustClass<int> justClass = new(1);
            
            JustClass<int> justClass2 = new(2);
            justClass2.AddChildren(new(3));
            justClass2.AddChildren(new(4));
            justClass.AddChildren(justClass2);
            
            JustClass<int> justClass3 = new(5);
            justClass3.AddChildren(new(6));
            justClass3.AddChildren(new(7));
            justClass3.AddChildren(new(8));
            justClass.AddChildren(justClass3);

            justClass.AddChildren(new(9));

            // Call
            justClass.RevealChildValues();
        }
    }
}
