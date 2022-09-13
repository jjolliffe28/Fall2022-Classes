using Fall2022_Classes;

Car ashleysCar = new Car();
Console.WriteLine("Ashley has a " + ashleysCar.Make);

ashleysCar.IsPaidFor = true;
Console.WriteLine("This car is paid for? : " + ashleysCar.IsPaidFor);

Car gavinsCar = new Car("Infiniti", "G37x", "Black", 2009);
Console.WriteLine("Gavin has a " + gavinsCar.Make);


// making a list of objects from our new class

var garage = new List<Car>();

garage.Add(ashleysCar);
garage.Add(gavinsCar);

Console.WriteLine(garage[0].Model);