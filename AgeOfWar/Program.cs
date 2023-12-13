// See https://aka.ms/new-console-template for more information
using AgeOfWar.Personaggi;

Console.WriteLine("Hello, World!");


Cavaliere CavalirereRosso = new Cavaliere(1000);

Cavaliere[] squadraRossa = new Cavaliere[100];

for (int i = 0; i < 100; i++)
{
    squadraRossa[i] = new Cavaliere(1000);
    squadraRossa[i].Squadra = "Squadra Rossa";
}