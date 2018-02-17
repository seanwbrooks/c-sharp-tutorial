using System;
namespace csharptutorial
{
    public class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }
        public string name { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal() {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(double height, double weight, string name, string sound) {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;

        public static int getNumOfAnimals() {
            return numOfAnimals;
        }

        public string toString() {
            return String.Format("{0} is {1} inches tall, weights {2} lbs and likes to say {3}",
                                 name, height, weight, sound);
        }

        public double getSum(double num1 = 1, double num2 = 1) {
            return num1 + num2;
        }
    }
}
