using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

class Program
{
    static void Main()
    {
        List<int >userdefinedVal = new List<int>();
        int totalLength = 0;
        System.Console.Write("Standart Kesim boyutları kaç adet?:");
        int standartCuts = int.Parse(Console.ReadLine());
        int[] standartCutsVal = new int[standartCuts];
        int profil = 6500;
        for(int i = 0; i <= standartCuts; i++)
        {
            Console.Write($"{i+1}.uzunluğu girin (mm): ");
            totalLength = int.Parse(Console.ReadLine());
            userdefinedVal.Add(totalLength);
        }
        Console.Write("Yapmak istediğiniz kesim adedini giriniz: ");
        int numCuts = int.Parse(Console.ReadLine());
        int[] userPieces = new int[numCuts];

        for (int i = 0; i < numCuts; i++)
        {
            Console.Write($"Kesim uzunluğu {i + 1} (mm): ");
            userPieces[i] = int.Parse(Console.ReadLine());
        }
        int carry = 0;
       for(int i = 0; i<= numCuts-1; i++)
        {
            carry += userPieces[i];
        }
        Console.WriteLine(carry);
    }
}
