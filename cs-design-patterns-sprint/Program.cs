﻿
using System;
using System.Runtime.InteropServices.JavaScript;
using cs_design_patterns_sprint;
using cs_design_patterns_sprint.Transport;

var config = ConfigManager.GetInstance("https://example.com/db/url", 1000, 2000);

// PART ONE
//Person person1 = new Person.Builder("Juniper", "Doolittle", 30).WithEmail("juniper@example.com").WithAddress("12 High Street").Build();
//Console.WriteLine(person1);
config.IncrementDataCount(); // ignore this for now

// PART TWO
List<Food> foods = new([
    new Food("Orange", 60),
    new Food("Beef",  400),
    new Food ("A stick", 3 ),
    new Food("Pasta", 200)
]);

foreach (var food in foods)
{
    NutritionalCalculator nutritionalCalculator = new NutritionalCalculator(food); // TODO

    double protein = nutritionalCalculator.CalculateProtein();
    Vitamins vitamins = nutritionalCalculator.CalculateVitamins();

    Console.WriteLine("Protein in " + food.Name + ": " + protein + " grams");
   Console.WriteLine("Vitamins in " + food.Name + ": Vitamin A=" + vitamins.VitaminA);
}
config.IncrementDataCount(); // ignore this for now

// PART THREE
 ImaginaryDatabase.FlushDataQueue();

// PART FOUR
ITransport basicTransport = new BasicTransport("Basic");
basicTransport.Display();

ITransportDecorator gpsTransport = new GPSDecorator(basicTransport);
gpsTransport.Display();

ITransportDecorator wifiTransport = new WifiDecorator(basicTransport);
wifiTransport.Display();

ITransportDecorator bothTransport = new GPSDecorator(wifiTransport);
bothTransport.Display();




//Part 5 OBSERVER
TicketManager ticketManager = new TicketManager();



//ticketManager.AddObserver();
