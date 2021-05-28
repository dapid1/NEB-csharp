namespace animFact
{
    class Sheep : Animal
    {
        internal Sheep()
        {

        }

        public override string Eat()
        {
            return "Yummy";
        }

        public override string MakeNoise()
        {
            return "Baaah";
        }
    }
}