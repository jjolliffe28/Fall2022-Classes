using System;
namespace Fall2022_Classes
{
    public class Car
    {
	    // Properties

    public string Make { get; set; }    

	public string Model { get; set; }

	public string Color { get; set; }
    
    public int Year { get; set; }

    public int Speed { get; set; }

    public bool IsPaidFor { get; set; }

        // Shortcut to create these is prop TAB TAB

        // access modifiers: public, private, internal
        // different ways we can access classes, properties, methods, etc in our application
        // If these properties were private we could not access "make" for example in our Programs.cs file
        // We use public here because it allows us to directly access our properties 
        // the Get allows us to use the dot operator and set allows us to change the value




        // Constructors

        public Car()
        {
            Make = "Lexus";
	        Model = "RX 350";
            Color = "White";
            Year = 2018;
            Speed = 0;
            IsPaidFor = false;
        }
	   
        public Car(string make, string model, string color, int year) 
	    {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
	    }

        // Methods
        // basic setup:
        // acessModifier returnType name () { code to run; }

        public void Accelerate()  // void means it returns nothing - just modifying speed
        {
            Speed += 5; 
	    }      

        public void Accelerate(int speed) // Method overload
        {
            Speed += speed;
	    }

        // Static method example

        public static void Honk()
        {
            Console.WriteLine("Honk!");

	    }

        public float TimeToTravelDistance(int distance)
        {
            if (Speed == 0)
            {
                return 0;
	        }

            return distance / (float)Speed;
	    }

    }
}

