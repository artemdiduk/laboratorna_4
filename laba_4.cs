using System;

namespace laba_4_task1
{ 
  class ArrayExample
  {
    static void Main()
    {
        char[] letters = { 'a', 'r', 't', 'e', 'm',  ' ', 'd', 'i', 'd', 'y', 'k',};
        string name = "";
        int[] a = new int[19];
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
  }
