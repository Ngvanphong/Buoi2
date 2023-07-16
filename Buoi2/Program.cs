//using Buoi2;

//NumberCalculation numberCalculation =
//    new NumberCalculation();
//numberCalculation.Name = "Calculation";
////int result = numberCalculation.Add(40);
////Console.WriteLine(result);
////numberCalculation.DisplayName();

//Cat cat1 = new Cat("Black", 100, 100);
////Console.WriteLine(cat1.Weight);
////cat1.DisplayInfo();
//string colorCat1 = cat1.Color;

//Cat cat2 = new Cat();
////cat2.DisplayInfo();
//string color = cat2.Color;

//Cat cat3 = new Cat("Red", 40, 40);

////Dog dog1 = new Dog("Dog");
//////dog1.DisplayName();
////Dog dog3 = new Dog();

////Dog.DisplayNameDog("Dog");

////Test test1 = new Test();
////test1.Name = "Test1";
////test1.Age = 20;
//////test1.DisplayInfo();

////Test test2 = new Test("Test2");
//////test2.DisplayInfo();

////Test test3 = new Test("test3", 21);

////Test.DisplayInfo2();

////Test test= new Test("Test",20,2,50);
////test.Name= "Test3";
////Console.WriteLine(test.Name);

//Mango mango = new Mango("Mango", "Yellow", 1.5, "acid");
//Console.WriteLine(mango.Name);
//Console.WriteLine(mango.Color);
//Console.WriteLine(mango.Flavor);
//mango.PricePerKg = 100;

//double result = mango.TotalPrice();
//Console.WriteLine(result);

////Apple apple = new Apple("Apple", "Red", 3, "Circle");
////Console.WriteLine($"{apple.Color} tititi {apple.Name} nmama {apple.Shape}");
////Console.WriteLine(apple.Color);
////Console.WriteLine(apple.Shape);

/*using Buoi2;

Vehicle vehicle = new Vehicle();
vehicle.DisplayInfo("Motobike");

Oto oto = new Oto();
oto.DisplayInfo("oto");

Building buiding = new Building();*/

using Buoi2;
using System.Diagnostics.CodeAnalysis;

/*Table table = new Table("Table","Black",10);
table.DisplayInfo();
table.DisplayInfo("test string");
table.DisplayInfo(100);

Dog.DisplayNameDog("Dog");*/

/*NumberCalculation numberCalculation = new NumberCalculation();
var add=numberCalculation.Add(1);
numberCalculation.DisplayName();

Apple apple = new Apple();

Apple apple2 = new Apple("Iphone","Yellow",1,"Circle");
apple2.Display();*/

//Building building = new Building();
//building.Name = "A1";
//building.Address = "NDD";
//Console.WriteLine($"{building.Name}, {building.Address}");

//Dog.DisplayNameDog("Dog");

//string text="10GGGG"; //emply
///*int number = int.Parse(text);
//Console.WriteLine(number);*/
//int number = 0;
//bool isNumber = int.TryParse(text, out number);
//if (isNumber)
//{
//    Console.WriteLine(number);
//}


//int inTotal = 10;
//double total = inTotal;

//TestStruct testStruct= new TestStruct();
//testStruct.Name= "Test";
//testStruct.Color = "Green";
//testStruct.Price = 100;
//Console.WriteLine(testStruct.Name);

//TestEnum today = TestEnum.Saturday;
//if (today == TestEnum.Monday)
//{
//    Console.WriteLine(today);
//}
//else if (today == TestEnum.Tuesday)
//{
//    Console.WriteLine(today);
//}



//switch (today)
//{
//    case TestEnum.Monday:
//        {
//            Console.WriteLine(today);
//            break;
//        }
//    case TestEnum.Tuesday:
//        {
//            Console.WriteLine(today);
//            break;
//        }
//}

//for (int i = 0; i < 10; i++)
//{
//    if (i == 3) continue;
//    Console.WriteLine(i);
//}

/*float numberFloat = 10.5f;
double number = 10;
double result = ++number + 10;
Console.WriteLine(result);


TTetsTrstet teset = new TTetsTrstet();
teset.Name= "Test";
teset.Color = "Color";*/


OutRefSample outRefSample= new OutRefSample();
outRefSample.FirstNumber = 20.5;
outRefSample.SecondNumber = 21.5;
outRefSample.Add(out double result);
Console.WriteLine(result);





