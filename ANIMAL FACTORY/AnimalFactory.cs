using NebulaChall;

namespace animFact {
    class AnimalFactory
    {
        public static Animal getAnimal(AnimalType type = AnimalType.GENERIC)
        {
            switch (type)
            {
                case (AnimalType.HORSE):
                    return new Horse();
                case (AnimalType.SHEEP):
                    return new Sheep();
                case (AnimalType.GENERIC):
                    return new Animal();
            }
            //Any animal not in the animal type enum
            return new Animal();
        }
    }
}

