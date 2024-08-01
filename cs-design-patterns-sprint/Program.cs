
using System;
using cs_design_patterns_sprint;

var config = new ConfigManager("https://example.com/db/url", 1000, 2000);

// PART ONE
Person person = new("Juniper", "Doolittle", 30, "12 High Street", "07234567890", "juniper@example.com");
Console.WriteLine(person);
config.IncrementDataCount(); // ignore this for now

// PART TWO
//List<Food> foods = new ([
//    new Food("Orange", 60),
//    new Food("Beef",  400),
//    new Food ("A stick", 3 ),
//    new Food("Pasta", 200)
//]);

//foreach (var food in foods)
//{
//    NutritionalCalculator nutritionalCalculator = new TODO(food); // TODO

//    double protein = nutritionalCalculator.CalculateProtein();
//    Vitamins vitamins = nutritionalCalculator.CalculateVitamins();

//    Console.WriteLine("Protein in " + food.Name + ": " + protein + " grams");
//    Console.WriteLine("Vitamins in " + food.Name + ": Vitamin A=" + vitamins.VitaminA);
//}
config.IncrementDataCount(); // ignore this for now

// PART THREE
// ImaginaryDatabase.FlushDataQueue();

// PART FOUR
// ITransport basicTransport = new BasicTransport("Basic");
// basicTransport.Display();