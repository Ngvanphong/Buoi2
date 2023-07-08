using Buoi2;


NumberCalculation numberCalculation =
    new NumberCalculation();
numberCalculation.Name = "Calculation";
//int result = numberCalculation.Add(40);
//Console.WriteLine(result);
//numberCalculation.DisplayName();

Cat cat1= new Cat("Black",100,100);
//Console.WriteLine(cat1.Weight);
//cat1.DisplayInfo();
string colorCat1 = cat1.Color;

Cat cat2 = new Cat();
//cat2.DisplayInfo();
string color = cat2.Color;

Cat cat3= new Cat("Red", 40, 40);

//Dog dog1 = new Dog("Dog");
////dog1.DisplayName();
//Dog dog3 = new Dog();

//Dog.DisplayNameDog("Dog");



//Test test1 = new Test();
//test1.Name = "Test1";
//test1.Age = 20;
////test1.DisplayInfo();

//Test test2 = new Test("Test2");
////test2.DisplayInfo();

//Test test3 = new Test("test3", 21);

//Test.DisplayInfo2();


//Test test= new Test("Test",20,2,50);
//test.Name= "Test3";
//Console.WriteLine(test.Name);

Mango mango = new Mango("Mango", "Yellow", 1.5, "acid");
Console.WriteLine(mango.Name);
Console.WriteLine(mango.Color);
Console.WriteLine(mango.Flavor);


Apple apple = new Apple("Apple", "Red", 3, "Circle");
Console.WriteLine($"{apple.Color} ti titi {apple.Name} nmama {apple.Shape}");
Console.WriteLine(apple.Color);
Console.WriteLine(apple.Shape);



