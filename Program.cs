﻿// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Models;

Console.WriteLine("Hello, World!");

var person = new Person { Id = 1, Name = "Mario Rossi", Age = 35 };
var person2 = new Person { Id = 1, Name = "Luigi Bianchi", Age = 45 };

Console.WriteLine($"Ciao, {person.Name}");
Console.WriteLine($"Ciao, {person2.Name}");

