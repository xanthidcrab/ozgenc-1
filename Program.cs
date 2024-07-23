using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

List<int> userdefinedVal = new List<int>();
int totalLength = 0;
System.Console.Write("Standart Kesim boyutları kaç adet?:");
int standartCuts = int.Parse(Console.ReadLine());
int profil = 6500;
for (int i = 0; i <= standartCuts-1; i++)
{
    Console.Write($"{i + 1}.uzunluğu girin (mm): ");
    totalLength = int.Parse(Console.ReadLine());
    userdefinedVal.Add(totalLength);
}

if (userdefinedVal[0] < userdefinedVal[1] || userdefinedVal[1] < userdefinedVal[2])
{
    userdefinedVal.Sort();
    userdefinedVal.Reverse();

}
//userdefinedVal.Sort();
Console.Write("Yapmak istediğiniz kesim adedini giriniz: ");
int numCuts = int.Parse(Console.ReadLine());
int[] userPieces = new int[numCuts];

for (int i = 0; i <= numCuts - 1; i++)
{
    Console.Write($"Kesim uzunluğu {i + 1} (mm): ");
    userPieces[i] = int.Parse(Console.ReadLine());
}
int carry = 0;
for (int i = 0; i <= numCuts; i++)
{
    if (i < userPieces.Length)
    {
        carry += userPieces[i];
    }
    else
    {
        break;
    }
}
int newProfile = profil - carry;
int tim = 0;
int cutCounter = 0; 
Console.WriteLine(newProfile<=100);
while (!(newProfile <= 100))
{

    newProfile -= userdefinedVal[tim];
    Console.WriteLine($"{cutCounter+1}. Optimize profil:{userdefinedVal[tim]}");
    cutCounter++;
    if(userdefinedVal[tim]> newProfile)
    {
        
        tim++;
    }

}
