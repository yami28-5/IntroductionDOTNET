using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static string delimiter = "\n-----------------------------\n";
        static void Main(string[] args)
        {
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine(sizeof(bool));
            Console.WriteLine(true.GetType());
            Console.WriteLine(delimiter);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("char");
            Console.ResetColor();
            Console.WriteLine(sizeof(char));//Unicode
            Console.WriteLine(delimiter);

            //byte  sbyte - Signed byte
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("byte");
            Console.ResetColor();
            Console.WriteLine("Size: " + sizeof(byte) + " byte");
            Console.WriteLine($"Range:{byte.MinValue} ... {byte.MaxValue}");
            Console.WriteLine(((byte)0).GetType());
            // sbyte
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("sbyte");
            Console.ResetColor();
            Console.WriteLine($"Size: {sizeof(sbyte)} byte");
            Console.WriteLine($"Range:{sbyte.MinValue} ... {sbyte.MaxValue}");
            Console.WriteLine(((sbyte)0).GetType());
            Console.WriteLine(delimiter);
            // short
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("short");
            Console.ResetColor();
            Console.WriteLine($"Size: {sizeof(short)}");
            Console.WriteLine($"Range:{short.MinValue} ... {short.MaxValue}");
            Console.WriteLine(((short)0).GetType());
            // ushork
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ushort");
            Console.ResetColor();
            Console.WriteLine($"Size: {sizeof(ushort)}");
            Console.WriteLine($"Range:{ushort.MinValue} ... {ushort.MaxValue}");
            Console.WriteLine(((ushort)0).GetType());
            Console.WriteLine(delimiter);

            // int
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("int");
            Console.ResetColor();
            Console.WriteLine($"Size: {sizeof(int)} bytes");
            Console.WriteLine($"Range: {int.MinValue} ... {int.MaxValue}");
            Console.WriteLine(((int)0).GetType());
            Console.WriteLine(delimiter);

            // uint
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("uint");
            Console.ResetColor();
            Console.WriteLine($"Size: {sizeof(uint)} bytes");
            Console.WriteLine($"Range: {uint.MinValue} ... {uint.MaxValue}");
            Console.WriteLine(((uint)0).GetType());
            Console.WriteLine(delimiter);

            // long
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("long");
            Console.ResetColor();
            Console.WriteLine($"Size: {sizeof(long)} bytes");
            Console.WriteLine($"Range: {long.MinValue} ... {long.MaxValue}");
            Console.WriteLine(((long)0).GetType());
            Console.WriteLine(delimiter);

            // ulong
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ulong");
            Console.ResetColor();
            Console.WriteLine($"Size: {sizeof(ulong)} bytes");
            Console.WriteLine($"Range: {ulong.MinValue} ... {ulong.MaxValue}");
            Console.WriteLine(((ulong)0).GetType());
            Console.WriteLine(delimiter);

            // float
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("float");
            Console.ResetColor();
            Console.WriteLine($"Size: {sizeof(float)} bytes");
            Console.WriteLine($"Range: {float.MinValue} ... {float.MaxValue}");
            Console.WriteLine(((float)0).GetType());
            Console.WriteLine(delimiter);

            // double
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("double");
            Console.ResetColor();
            Console.WriteLine($"Size: {sizeof(double)} bytes");
            Console.WriteLine($"Range: {double.MinValue} ... {double.MaxValue}");
            Console.WriteLine(((double)0).GetType());
            Console.WriteLine(delimiter);

            // decimal
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("decimal");
            Console.ResetColor();
            Console.WriteLine($"Size: {sizeof(decimal)} bytes");
            Console.WriteLine($"Range: {decimal.MinValue} ... {decimal.MaxValue}");
            Console.WriteLine(((decimal)0).GetType());
            Console.WriteLine(delimiter);
        }
    }
}