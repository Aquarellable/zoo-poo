using System;
using System.Collections.Generic;

namespace ZooApp
{
    public class AnimalGender
    {
        public string Food { get; set; }
        public double FoodPerDayKg { get; set; }
        public int DaysBeforeHunger { get; set; }
        public int SexualMaturityYears { get; set; }
        public int ReproductionEndYears { get; set; }
        public int LifeExpectancyYears { get; set; }

        // Pour les femelles
        public int? OffspringPerBirth { get; set; }
        public int? MaxBirthIntervalMonths { get; set; }
        public int? GestationMonths { get; set; }
        public double? InfantMortalityRate { get; set; }
        public int? SexualMaturityMonths { get; set; }
        public int? IncubationWeeks { get; set; }
        public int? EggsPerYear { get; set; }
        public string LayingMonth { get; set; }
        public int? GestationDays { get; set; }
        public string Notes { get; set; }
    }

    public class Animals
    {
        public Dictionary<string, AnimalGender> Male { get; set; }
        public Dictionary<string, AnimalGender> Female { get; set; }
    }

    public class Food
    {
        public double PricePerKg { get; set; }
    }

    public class AnimalPricesAge
    {
        public double Buy { get; set; }
        public double Sell { get; set; }
    }

    public class Habitat
    {
        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }
        public int Capacity { get; set; }
        public int OverpopulationLossPerMonth { get; set; }
        public double DiseaseProbability { get; set; }
    }

    public class DiseaseAnimal
    {
        public double ProbabilityPerYear { get; set; }
        public int DurationDays { get; set; }
    }

    public class Disease
    {
        public double MortalityRate { get; set; }
        public double DurationVariation { get; set; }
        public Dictionary<string, DiseaseAnimal> Animals { get; set; }
    }

    public class Visitors
    {
        public Dictionary<string, Dictionary<string, double>> PerSpecimenPerMonth { get; set; }
        public double Variation { get; set; }
        public List<string> HighSeasonMonths { get; set; }
        public Dictionary<string, double> TicketPrices { get; set; }
        public Dictionary<string, int> VisitorGroup { get; set; }
    }

    public class Economy
    {
        public double InitialBudget { get; set; }
        public Dictionary<string, double> SubsidiesPerYear { get; set; }
    }

    public class Rules
    {
        public bool AnimalsDoNotReproduceWhenHungry { get; set; }
        public bool PregnantFemalesLoseFetusIfHungry { get; set; }
        public double PregnantFemalesFoodMultiplier { get; set; }
        public bool PregnantFemalesNotExposedToPublic { get; set; }
        public bool AnimalsDoNotReproduceFirstMonthAfterArrival { get; set; }
        public bool ReproductionRequiresAvailableSpace { get; set; }
    }

    public class ExceptionalEvent
    {
        public double MonthlyProbability { get; set; }
        public string Effect { get; set; }
    }

    public class ZooDatabase
    {
        public Dictionary<string, Animals> Animals { get; set; }
        public Dictionary<string, Food> Food { get; set; }
        public Dictionary<string, Dictionary<string, AnimalPricesAge>> AnimalPrices { get; set; }
        public Dictionary<string, Habitat> Habitats { get; set; }
        public Disease Diseases { get; set; }
        public Visitors Visitors { get; set; }
        public Economy Economy { get; set; }
        public Rules Rules { get; set; }
        public List<string> Actions { get; set; }
        public List<string> Events { get; set; }
        public Dictionary<string, ExceptionalEvent> ExceptionalEvents { get; set; }
    }
}