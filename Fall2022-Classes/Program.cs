using Fall2022_Classes;

Car ashleysCar = new Car();
Console.WriteLine("Ashley has a " + ashleysCar.Make);

ashleysCar.IsPaidFor = true;
Console.WriteLine("This car is paid for? : " + ashleysCar.IsPaidFor);

Car gavinsCar = new Car("Infiniti", "G37x", "Black", 2009);
Console.WriteLine("Gavin has a " + gavinsCar.Make);


// making a list of objects from our new class

var garage = new List<Car>(); // creates a new list 

garage.Add(ashleysCar);
garage.Add(gavinsCar);

Console.WriteLine(garage[0].Model);// will print Ashley's car cause she is indexed at 0

// see the effects of the Accelerate method
Console.WriteLine(gavinsCar.Speed); // -> will print 0 for the current speed
gavinsCar.Accelerate();
Console.WriteLine(gavinsCar.Speed); // -> will print 5 due to the Accelerate Method we created in the car class
gavinsCar.Accelerate();
Console.WriteLine(gavinsCar.Speed); // up to 10 from 5
// use of our overload Accelerate method
gavinsCar.Accelerate(7);
Console.WriteLine(gavinsCar.Speed); // up to 17 from 10

Console.WriteLine(gavinsCar.TimeToTravelDistance(500));
Console.WriteLine(ashleysCar.TimeToTravelDistance(100)); 




// Static Method -> Dont need a object
// calling our static method from Cars.cs
// Note this only works by calling the class (Cars), not an instance (Object)
Car.Honk();
