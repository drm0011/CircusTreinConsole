using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinConsole
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //create a list with animals 
            //create a list with wagons that are full of animals
            List<Animal> animals = new List<Animal>();
            List<Wagon> wagons = new List<Wagon>();

            #region add animals
            Animal bear = new Animal(enums.Types.Carnivore, "Bear", enums.Sizes.Large);
            animals.Add(bear);

            Animal deer = new Animal(enums.Types.Herbivore, "Deer", enums.Sizes.Medium);
            animals.Add(deer);

            Animal dog = new Animal(enums.Types.Carnivore, "Dog", enums.Sizes.Small);
            animals.Add(dog);

            Animal giraffe = new Animal(enums.Types.Herbivore, "Giraffe", enums.Sizes.Large);
            animals.Add(giraffe);

            Animal goat = new Animal(enums.Types.Herbivore, "Goat", enums.Sizes.Small);
            animals.Add(goat);

            Animal sheep = new Animal(enums.Types.Herbivore, "Sheep", enums.Sizes.Small);
            animals.Add(sheep);

            Animal tiger = new Animal(enums.Types.Carnivore, "Tiger", enums.Sizes.Medium);
            animals.Add(tiger);

            Animal elephant = new Animal(enums.Types.Herbivore, "Elephant", enums.Sizes.Large);
            animals.Add(elephant);

            Animal lion = new Animal(enums.Types.Carnivore, "Lion", enums.Sizes.Medium);
            animals.Add(lion);

            Animal moose = new Animal(enums.Types.Herbivore, "Moose", enums.Sizes.Large);
            animals.Add(moose);

            Animal koala = new Animal(enums.Types.Herbivore, "Koala", enums.Sizes.Small);
            animals.Add(koala);

            Animal crocodile = new Animal(enums.Types.Carnivore, "Crocodile", enums.Sizes.Medium);
            animals.Add(crocodile);

            Animal kangaroo = new Animal(enums.Types.Herbivore, "Kangaroo", enums.Sizes.Medium);
            animals.Add(kangaroo);

            Animal sloth = new Animal(enums.Types.Herbivore, "Sloth", enums.Sizes.Small);
            animals.Add(sloth);

            Animal weasel = new Animal(enums.Types.Herbivore, "Weasel", enums.Sizes.Small);
            animals.Add(weasel);

            Animal desertMouse = new Animal(enums.Types.Herbivore, "Desert mouse", enums.Sizes.Small);
            animals.Add(desertMouse);
            #endregion

            //for each animal in the list of animals
            foreach (Animal animal in animals)
            {
                //animal has not yet been added to a wagon so added=false
                bool added = false; //this bool functions as a way to keep track of each animal and if they have already been added to a wagon
                foreach(Wagon wagon in wagons) //check for each wagon in the list of wagons
                {
                    //if true
                    if (wagon.AddAnimal(animal))
                    {
                        //animal is added, so added=true
                        added = true;
                        break;
                    }
                }

                //if animal hasnt been added / if added==false
                //once a wagon is full to the point where adding another animal will exceed the maximum size of ten points, AddAnimal will return false for the previous wagon, therefore this animal still has the bool set to false, therefore create a NewWagon to add the animal to
                if (!added)
                {
                    //create a wagon
                    Wagon newWagon = new Wagon();
                    //add animal to wagon
                    newWagon.AddAnimal(animal);
                    //add new wagon to list of wagons
                    wagons.Add(newWagon);
                }
            } //end first foreach

            foreach (Wagon wagon in wagons)
            {
                Console.WriteLine(wagon); //ToString method from wagon object
            }
            Console.ReadLine();
        }
    }
}
