﻿// This is a comment to my code

//rakendus küsib kasutajal sisesteda tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");
//string - sõne
string userName;

userName = Console.ReadLine();

Console.WriteLine("Hello" + ", " + userName + "!");
// string interpolation

Console.WriteLine($"Hello, {userName} !");
