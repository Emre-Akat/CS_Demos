using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP_Concepts_With_CSharp
{
    public class ZooManager
    {
        private readonly List<IAnimal> animals;
        private readonly ILogger logger;

        public ZooManager(List<IAnimal> animals, ILogger logger)
        {
            this.animals = animals;
            this.logger = logger;
        }
        public void ShowAnimals()
        {
            foreach (var animal in animals)
            {
                animal.MakeSound();
                animal.Eat();
                logger.Log($"{animal.GetType().Name} ses çıkardı ve yemek yedi.");
            }
        }
    }
}
