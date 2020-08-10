using System.Collections.Immutable;

namespace AnimalToHumanYearsCalculator
{
    public class Animals
    {
        public string Name { get; set; } = string.Empty;
        public string MediaPath { get; set; } = string.Empty;
        public IImmutableDictionary<double, double> HumansToAnimalAgeMap { get; set; }
    }
}
