using InterfaceVsHeranca.Model.Entities;
using InterfaceVsHeranca.Model.Enums;

IShape s1 = new Circle() { Radius = 2.0, Color = Color.Red };
IShape s2 = new Rectangle() { Height = 3.5, Width = 4.2, Color = Color.Green };

Console.WriteLine(s1);
Console.WriteLine(s2);