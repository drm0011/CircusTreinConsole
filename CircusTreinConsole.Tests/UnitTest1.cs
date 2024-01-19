namespace CircusTreinConsole.Tests
{

    public class UnitTest1
    {
        [Fact]
        public void GetPoints_NeedsToReturnCorrectPoints()
        {
            //create objects to test
            Animal smallCat = new Animal(enums.Types.Carnivore, "cat", enums.Sizes.Small);
            Animal mediumPig = new Animal(enums.Types.Carnivore, "pig", enums.Sizes.Medium);
            Animal largeRhino = new Animal(enums.Types.Herbivore, "rhino", enums.Sizes.Large);

            Assert.Equal(1, smallCat.GetPoints());
            Assert.Equal(3, mediumPig.GetPoints());
            Assert.Equal(5, largeRhino.GetPoints());
        }
    }

    public class UnitTest2
    {
        [Fact]
        public void AddAnimal_AnimalShouldBeAdded()
        {
            //create objects to test
            Wagon wagon = new Wagon();
            Animal cat = new Animal(enums.Types.Carnivore, "cat", enums.Sizes.Small);

            bool wagonResult = wagon.AddAnimal(cat);

            //does wagon contain the cat
            Assert.True(wagonResult);
            Assert.Contains(cat, wagon.animals);
            Assert.Equal(1, wagon.usedSize);

        }
    }
}