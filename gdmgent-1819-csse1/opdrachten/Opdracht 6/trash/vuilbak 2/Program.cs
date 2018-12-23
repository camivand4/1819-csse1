using System;
 
namespace DoFactory.GangOfFour.Abstract.Structural
{
  /// <summary>

  /// MainApp startup class for Structural

  /// Abstract Factory Design Pattern.

  /// </summary>

  class MainApp

  {
    /// <summary>

    /// Entry point into console application.

    /// </summary>

    public static void Main()
    {
      // Abstract factory #1

      AbstractFactory cirkel = new ConcreteCirkel();
      Client client1 = new Client(cirkel);
      client1.Run();
 
      // Abstract factory #2

      AbstractFactory vierkant = new ConcreteVierkant();
      Client client2 = new Client(vierkant);
      client2.Run();
 
      // Wait for user input

      Console.ReadKey();
    }
  }
 
  /// <summary>

  /// The 'AbstractFactory' abstract class

  /// </summary>

  abstract class AbstractFactory

  {
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
  }
 
 
  /// <summary>

  /// The 'ConcreteCirkel' class

  /// </summary>

  class ConcreteCirkel : AbstractFactory

  {
    public override AbstractProductA CreateProductA()
    {
      return new ProductA1();
    }
    public override AbstractProductB CreateProductB()
    {
      return new ProductB1();
    }
  }
 
  /// <summary>

  /// The 'ConcreteVierkant' class

  /// </summary>

  class ConcreteVierkant : AbstractFactory

  {
    public override AbstractProductA CreateProductA()
    {
      return new ProductA2();
    }
    public override AbstractProductB CreateProductB()
    {
      return new ProductB2();
    }
  }
 
  /// <summary>

  /// The 'AbstractProductA' abstract class

  /// </summary>

  abstract class AbstractProductA

  {
  }
 
  /// <summary>

  /// The 'AbstractProductB' abstract class

  /// </summary>

  abstract class AbstractProductB

  {
    public abstract void Interact(AbstractProductA a);
  }
 
 
  /// <summary>

  /// The 'ProductA1' class

  /// </summary>

  class ProductA1 : AbstractProductA

  {
  }
 
  /// <summary>

  /// The 'ProductB1' class

  /// </summary>

  class ProductB1 : AbstractProductB

  {
    public override void Interact(AbstractProductA a)
    {
      Console.WriteLine(this.GetType().Name +
        " interacts with " + a.GetType().Name);
    }
  }
 
  /// <summary>

  /// The 'ProductA2' class

  /// </summary>

  class ProductA2 : AbstractProductA

  {
  }
 
  /// <summary>

  /// The 'ProductB2' class

  /// </summary>

  class ProductB2 : AbstractProductB

  {
    public override void Interact(AbstractProductA a)
    {
      Console.WriteLine(this.GetType().Name +
        " interacts with " + a.GetType().Name);
    }
  }
 
  /// <summary>

  /// The 'Client' class. Interaction environment for the products.

  /// </summary>

  class Client

  {
    private AbstractProductA _abstractProductA;
    private AbstractProductB _abstractProductB;
 
    // Constructor

    public Client(AbstractFactory factory)
    {
      _abstractProductB = factory.CreateProductB();
      _abstractProductA = factory.CreateProductA();
    }
 
    public void Run()
    {
      _abstractProductB.Interact(_abstractProductA);
    }
  }
}
 
 
          