using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class FlavorTest : IDisposable
  {

    public void Dispose()
    {
      Flavor.ClearAll();
    }

    [TestMethod]
    public void FlavorConstructor_CreatesInstanceOfFlavor_Flavor()
    {
      Flavor newFlavor = new Flavor("test flavor");
      Assert.AreEqual(typeof(Flavor), newFlavor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Flavor";
      Flavor newFlavor = new Flavor(name);

      //Act
      string result = newFlavor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsFlavorId_Int()
    {
      //Arrange
      string name = "Test Flavor";
      Flavor newFlavor = new Flavor(name);

      //Act
      int result = newFlavor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllFlavorObjects_FlavorList()
    {
      //Arrange
      string name01 = "Work";
      string name02 = "School";
      Flavor newFlavor1 = new Flavor(name01);
      Flavor newFlavor2 = new Flavor(name02);
      List<Flavor> newList = new List<Flavor> { newFlavor1, newFlavor2 };

      //Act
      List<Flavor> result = Flavor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectFlavor_Flavor()
    {
      //Arrange
      string name01 = "Work";
      string name02 = "School";
      Flavor newFlavor1 = new Flavor(name01);
      Flavor newFlavor2 = new Flavor(name02);

      //Act
      Flavor result = Flavor.Find(2);

      //Assert
      Assert.AreEqual(newFlavor2, result);
    }

    [TestMethod]
    public void AddTreat_AssociatesTreatWithFlavor_TreatList()
    {
      //Arrange
      string description = "Walk the dog.";
      Treat newTreat = new Treat(description);
      List<Treat> newList = new List<Treat> { newTreat };
      string name = "Work";
      Flavor newFlavor = new Flavor(name);
      newFlavor.AddTreat(newTreat);

      //Act
      List<Treat> result = newFlavor.Treats;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

  }
}