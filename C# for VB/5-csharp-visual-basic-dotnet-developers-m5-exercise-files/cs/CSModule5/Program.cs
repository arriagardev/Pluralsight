using System;

namespace CSModule5
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong memory = My.Instance.Computer.Info.TotalPhysicalMemory;
            Console.WriteLine(memory);

            
            Console.ReadLine();
        }
    }
}
