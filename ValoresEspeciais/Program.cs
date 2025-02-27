using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Create variables with the Min and Max value of all types 
            sbyte sbMax = sbyte.MaxValue;
            sbyte sbMin = sbyte.MinValue;

            double dbMax = double.MaxValue;
            double dbMin = double.MinValue;

            ulong ulMax = ulong.MaxValue;
            ulong ulMin = ulong.MinValue;

            long lMax = long.MaxValue;
            long lMin = long.MinValue;

            float fMax = float.MaxValue;
            float fMin = float.MinValue;

            int iMax = int.MaxValue;
            int iMin = int.MinValue;

            short sMax = short.MaxValue;
            short sMin = short.MinValue;

            decimal decMax = decimal.MaxValue;
            decimal decMin = decimal.MinValue;

            byte bMax = byte.MaxValue;
            byte bMin = byte.MinValue;

            ushort usMax = ushort.MaxValue;
            ushort usMin = ushort.MinValue;

            uint uiMax = uint.MaxValue;
            uint uiMin = uint.MaxValue;

            char chMax = char.MaxValue;
            char chMin = char.MinValue;

            // Print variables with the Min and Max value of all types
            Console.WriteLine($"{sbMax} {sbMin}");
            Console.WriteLine($"{dbMax} {dbMin}");
            Console.WriteLine($"{ulMax} {ulMin}");
            Console.WriteLine($"{lMax} {lMin}");
            Console.WriteLine($"{fMax} {fMin}");
            Console.WriteLine($"{iMax} {iMin}");
            Console.WriteLine($"{sMax} {sMin}");
            Console.WriteLine($"{decMax} {decMin}");
            Console.WriteLine($"{bMax} {bMin}");
            Console.WriteLine($"{usMax} {usMin}");
            Console.WriteLine($"{uiMax} {uiMin}");
            Console.WriteLine($"{chMax} {chMin}");



            // Print double Positive Infinity
            double x = double. PositiveInfinity;
            Console.WriteLine(x);
            // Print double NAN
            x = double. PositiveInfinity / double. PositiveInfinity ; 
            Console.WriteLine(x);

            // Print double Negative Infinity
            float f = float. NegativeInfinity;
            Console.WriteLine(f);
            // Print float NAN
            f = float .NaN;
            Console.WriteLine(f);

            // Uint Overflow
            ulong i = uint.MaxValue; 
            Console.WriteLine((uint)(i + 1));
            



            // Floats Overflows
            float w = float.MaxValue + 1;
            Console.WriteLine(w);

            float h = 2 * float.MaxValue;
            Console.WriteLine(h);


        }
    }
}
