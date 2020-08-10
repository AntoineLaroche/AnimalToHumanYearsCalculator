using System.Collections.Generic;
using System.Collections.Immutable;

namespace AnimalToHumanYearsCalculator
{
    public class AnimalsService : IAnimalsService
    {
        public List<Animals> GetAll()
        {
            var humanToCatAgeMap = new Dictionary<double, double> { { 0.5, 18 }, { 1, 19 }, { 2, 24 }, { 3, 28 }, { 4, 32 }, { 5, 36 } };

            return new List<Animals>
            {
                CreateAnimals("Cat", string.Empty, humanToCatAgeMap)
            };
        }

        private Animals CreateAnimals(string name, string mediaPath, Dictionary<double, double> humansToAnimalAgeMap)
        {
            return new Animals
            {
                Name = name,
                MediaPath = mediaPath,
                HumansToAnimalAgeMap = humansToAnimalAgeMap.ToImmutableDictionary()
            };
        }
    }
}
