using System;
namespace csharptutorial
{
    public class Dog : Animal
    {
        public string favFood { get; set; }

        // : base() initializes the properties/behaviors of Animal to Dog
        public Dog() : base() {
            this.favFood = "No Favorite Food";
        }

        public Dog(double height, double weight, string name, string sound, string favFood) : base(
            height, weight, name, sound) {
            this.favFood = favFood;
        }

        // new overrides Animal toString
        new public string toString()
        {
            return String.Format("{0} is {1} inches tall, weights {2} lbs and likes to say {3} and food {4}",
                                name, height, weight, sound, favFood);
        }
    }
}
