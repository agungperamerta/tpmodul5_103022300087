
using System;
public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

public class Program
{
    static void Main()
    {
        DataGeneric<string> nimData = new DataGeneric<string>("103022300087"); 
        nimData.PrintData();
    }
}
