// See https://aka.ms/new-console-template for more information

using System.Numerics;

public class Penjumlahan<T>
{
    public T JumlahTigaAngka<T>(T a, T b, T c) where T : IAdditionOperators<T, T, T>

    {
        return a + b + c;
    }

}
