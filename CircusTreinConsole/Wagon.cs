using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinConsole
{
    public class Wagon
    {
        public int usedSize;
        public List<Animal> animals; //every wagon has a list of animals

        public Wagon()
        {
            usedSize = 0;
            animals = new List<Animal>();
        }

        public bool CanAnimalBeAdded(Animal animal)
        {
            //wagon cannot exceed 10
            //check the amount of space that has already been taken up, add the point value of the animal u are going to add
            if (usedSize + animal.GetPoints() <= 10)
            {
                foreach (Animal existingAnimal in animals) //foreach loop to compare the existingAnimal in the animals list to the animal that u give with the parameter of this method
                {
                    //carnivores may not be added to wagons that have smaller or equally sized animals in them
                    if (animal.type == enums.Types.Carnivore && animal.size >= existingAnimal.size || existingAnimal.type == enums.Types.Carnivore)
                    {
                        return false;
                    }
                }
                return true;
            }
            //false if wagon exceeds 10
            return false;
        }

        public bool AddAnimal(Animal animal)
        {
            //if the animal can be added
            if (CanAnimalBeAdded(animal)){
                animals.Add(animal); //add animal
                usedSize += animal.GetPoints(); //increase usedSize variable with the point value of the animal
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string result = "Wagon:\n";
            foreach (Animal animal in animals)
            {
                result += " - " + animal.name + ": " + animal.size + ", " + animal.type + "\n";
            }
            return result;
        }

    }
}
