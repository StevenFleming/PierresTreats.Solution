using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;
using MySql.Data.MySqlClient;

namespace Bakery.Tests
{
  [TestClass]
  public class TreatTests : IDisposable
  {

    public void Dispose()
    {
      Treat.ClearAll();
    }

    public TreatTests()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=to_do_list_test;";
    }

    // [TestMethod]
    // public void TreatConstructor_CreatesInstanceOfTreat_Treat()
    // {
    //   Treat newTreat = new Treat("test"); //We pass in "test" as an argument here.
    //   Assert.AreEqual(typeof(Treat), newTreat.GetType());
    // }

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   string description = "Walk the dog.";
    //   Treat newTreat = new Treat(description);
    //   string result = newTreat.Description;
    //   Assert.AreEqual(description, result);
    // }

    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Treat newTreat = new Treat(description);

    //   //Act
    //   string updatedDescription = "Do the dishes";
    //   newTreat.Description = updatedDescription;
    //   string result = newTreat.Description;

    //   //Assert
    //   Assert.AreEqual(updatedDescription, result);
    // }

    [TestMethod]
    public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Treat()
    {
      // Arrange, Act
      Treat firstTreat = new Treat("Mow the lawn");
      Treat secondTreat = new Treat("Mow the lawn");

      // Assert
      Assert.AreEqual(firstTreat, secondTreat);
    }

    [TestMethod]
    public void Save_SavesToDatabase_TreatList()
    {
      //Arrange
      Treat testTreat = new Treat("Mow the lawn");

      //Act
      testTreat.Save();
      List<Treat> result = Treat.GetAll();
      List<Treat> testList = new List<Treat> { testTreat };

      //Assert
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyListFromDatabase_TreatList()
    {
      // Arrange
      List<Treat> newList = new List<Treat> { };

      // Act
      List<Treat> result = Treat.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsTreats_TreatList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Treat newTreat1 = new Treat(description01);
      newTreat1.Save();
      Treat newTreat2 = new Treat(description02);
      newTreat2.Save();
      List<Treat> newList = new List<Treat> { newTreat1, newTreat2 };

      //Act
      List<Treat> result = Treat.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    // [TestMethod]
    // public void GetId_TreatsInstantiateWithAnIdAndGetterReturns_Int()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Treat newTreat = new Treat(description);

    //   //Act
    //   int result = newTreat.Id;

    //   //Assert
    //   Assert.AreEqual(1, result);
    // }

    [TestMethod]
    public void Find_ReturnsCorrectTreatFromDatabase_Treat()
    {
      //Arrange 
      Treat newTreat = new Treat("Mow the lawn");
      newTreat.Save();
      Treat newTreat2 = new Treat("Wash dishes");
      newTreat2.Save();

      //Act
      Treat foundTreat = Treat.Find(newTreat.Id);
      //Assert
      Assert.AreEqual(newTreat, foundTreat);
    }

  }
}