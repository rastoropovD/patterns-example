// See https://aka.ms/new-console-template for more information

using PatternsExample.Base;
using PatternsExample.Builder.VehicleBuilderExample;
using PatternsExample.BusinessLogic.Documents;
using PatternsExample.ChainOfResponsibility.ApprovalExample;
using PatternsExample.ChainOfResponsibility.BasicExample;
using PatternsExample.Mediator;

Console.WriteLine("Hello, World!");

#region Factory and Template method

// Document[] documents = new Document[2];
//
// documents[0] = new CvDocument();
// documents[1] = new ReportDocument();
//
// foreach (Document doc in documents)
// {
//   //  doc.RenderDocument();
//     ((IPrintable)doc).Print();
//     //IPrintable printable = doc;
//     //printable.Print();
// }

#endregion


#region Builder

// Director director = new Director();
//
// Builder productABuilder = new ProductA();
// Builder productBBuilder = new ProductB();
//
// director.Construct(productABuilder);
// Product productA = productABuilder.GetResult();
//
// director.Construct(productBBuilder);
// Product productB = productBBuilder.GetResult();
//
// Console.WriteLine("ProductA parts: ");
// productA.Show();
//
// Console.WriteLine("\nProductB parts: ");
// productB.Show();

// ICarShop shop = new CarShop();
//
// Dictionary<string, string> cars = new Dictionary<string, string>();
//
// CarBuilder builder = new MotorCycleBuilder();
// shop.Construct(builder);
// cars.Add(builder.Car.CarType, builder.Car.Show());
//
// builder = new ScooterBuilder();
// shop.Construct(builder);
// cars.Add(builder.Car.CarType, builder.Car.Show());
//
// builder = new JeepBuilder();
// shop.Construct(builder);
// cars.Add(builder.Car.CarType, builder.Car.Show());
//
// foreach (KeyValuePair<string,string> keyValuePair in cars)
// {
//     Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
// }

#endregion


#region ChainOfResponsibility

// Handler h1 = new HandlerA();
// Handler h2 = new HandlerB();
// Handler h3 = new HandlerC();
//
// h1.SetSuccessor(h2);
// h2.SetSuccessor(h3);
//
// int[] requests = {2, 5, 14, 22, 18, 3, 28, 20};
//
// foreach (int request in requests)
// {
//     h1.HandleRequest(request);
// }

// Approver bob = new Director();
// Approver sam = new VicePresident();
// Approver tom = new President();
//
// bob.SetSuccessor(sam);
// sam.SetSuccessor(tom);
//
// // bob => sam => tom
//
// PurchaseDto[] purchases =
// {
//     new PurchaseDto(1, 350, "Supplies"),
//     new PurchaseDto(1, 12000, "Project X"),
//     new PurchaseDto(1, 65000, "Project Y"),
//     new PurchaseDto(1, 150000, "Project error")
// };
//
// foreach (PurchaseDto purchase in purchases)
// {
//     string result = bob.ProcessPurchase(purchase);
//     Console.WriteLine(result);
// }


#endregion

#region Randomizer
//
// int[] studentNumbers = {};
//
// Random rnd = new Random(Guid.NewGuid().ToString().GetHashCode());
//
// int index = rnd.Next(0, studentNumbers.Length);
// int studentNumber = studentNumbers[index];
//
// Console.WriteLine($"studentNumber = {studentNumber}");

#endregion


#region Mediator

Participant Mike = new Participant("Mike");
Participant Bob = new Participant("Bob");
Participant Alex = new Participant("Alex");

IChatMediator mediator = new ChatMediator();

mediator.Register(Mike);
mediator.Register(Bob);
mediator.Register(Alex);

mediator.Send("Bob", "Mike", "some message");
mediator.Send("Mike", "Alex", "Hello!");


#endregion

Console.Read();
