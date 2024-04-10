Console.WriteLine($"Тип: {typeof(bool)}, Пример:{bool.FalseString}, Размер в байтах:{sizeof(bool)}");
        Console.WriteLine($"Тип: {typeof(byte)}, Пример:{byte.MaxValue}, Размер в байтах:{sizeof(byte)}");
        Console.WriteLine($"Тип: {typeof(byte)}, Пример:{sbyte.MaxValue}, Размер в байтах:{sizeof(byte)}");
        Console.WriteLine($"Тип: {typeof(short)}, Пример:{short.MaxValue}, Размер в байтах:{sizeof(short)}");
        Console.WriteLine($"Тип: {typeof(ushort)}, Пример:{ushort.MaxValue}, Размер в байтах:{sizeof(ushort)}");
        Console.WriteLine($"Тип: {typeof(int)}, Пример:{int.MaxValue}, Размер в байтах:{sizeof(int)}");
        Console.WriteLine($"Тип: {typeof(long)}, Пример:{long.MaxValue}, Размер в байтах:{sizeof(long)}");
        Console.WriteLine($"Тип: {typeof(uint)}, Пример:{uint.MaxValue}, Размер в байтах:{sizeof(uint)}");
        Console.WriteLine($"Тип: {typeof(ulong)}, Пример:{ulong.MaxValue}, Размер в байтах:{sizeof(ulong)}");
        Console.WriteLine($"Тип: {typeof(float)}, Пример:{float.MaxValue}, Размер в байтах:{sizeof(float)}");
        Console.WriteLine($"Тип: {typeof(double)}, Пример:{double.MaxValue}, Размер в байтах:{sizeof(double)}");
        Console.WriteLine($"Тип: {typeof(char)}, Пример:{char.MaxValue}, Размер в байтах:{sizeof(char)}");
        Console.WriteLine($"Тип: {typeof(decimal)}, Пример:{decimal.MaxValue}, Размер в байтах:{sizeof(decimal)}");
        unsafe 
        {
            Console.WriteLine($"Тип: {typeof(string)}, Пример:{"*/-String type?=+1"}, Размер в байтах:{sizeof(string)}");
        }