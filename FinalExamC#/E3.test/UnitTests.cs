using Microsoft.VisualStudio.TestTools.UnitTesting;
using E3;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;
using System.Threading;

namespace E3.Tests;

[TestClass]
public class ExamUnitTests
{
        [TestMethod]
        public void Q0_Inheritance_ShouldOverrideSound()
        {
            // Assert.Inconclusive();
            // Arrange
            Animal genericAnimal = new Animal();
            Animal dog = new Dog(); // Polymorphism

            // Act
            string genericSound = genericAnimal.MakeSound();
            string dogSound = dog.MakeSound();

            // Assert
            Assert.AreEqual("Some generic animal sound", genericSound, "Base class method was not called correctly.");
            Assert.AreEqual("Woof", dogSound, "Derived class did not override the method correctly.");
            Assert.IsInstanceOfType(dog, typeof(Animal), "Dog should be an instance of Animal.");
        }

        public static class ValueAndReference
        {
            public static void ChangeType1(MyPointType1 p) { p.X = 100; p.Y = 200; }
            public static void ChangeType2(MyPointType2 p) { p.X = 100; p.Y = 200; }
        }        

        [TestMethod]
        public void Q1_ValueVsReferenceType()
        {
            // Assert.Inconclusive();
            // Arrange
            var myType1 = new MyPointType1 { X = 10, Y = 20 };
            var myType2 = new MyPointType2 { X = 10, Y = 20 };

            // Act
            ValueAndReference.ChangeType1(myType1);

            ValueAndReference.ChangeType2(myType2);

            // Assert
            Assert.AreEqual(100, myType1.X, "Type1 is a reference type; its fields should be changed by the method.");
            Assert.AreEqual(10, myType2.X, "Type2 is a value type; its fields should NOT be changed by the method.");
        }

        // [TestMethod]
        // public void Q2_GenericsAndIComparable()
        // {
        //     Assert.Inconclusive();
        //     // Arrange
        //     var intComparer = new Comparer<int>(5, 10);
        //     var stringComparer = new Comparer<string>("Apple", "Banana");
        //     var productA = new Product { Name = "Laptop", Price = 1200 };
        //     var productB = new Product { Name = "Mouse", Price = 50 };
        //     var productComparer = new Comparer<Product>(productA, productB);

        //     // Act
        //     int maxInt = intComparer.GetLarger();
        //     string maxString = stringComparer.GetLarger();
        //     Product expensiveProduct = productComparer.GetLarger();

        //     // Assert
        //     Assert.AreEqual(10, maxInt);
        //     Assert.AreEqual("Banana", maxString);
        //     Assert.AreEqual("Laptop", expensiveProduct.Name);
        // }

        [TestMethod]
        public void Q3_IDisposablePattern()
        {
            // Assert.Inconclusive();
            ResourceManager resource;
            // Arrange
            using (resource = new ResourceManager())
            {
                // Act
                Assert.IsFalse(resource.IsDisposed, "Resource should not be disposed before exiting the 'using' block.");
            }
            // Assert
            Assert.IsTrue(resource.IsDisposed, "Resource should be disposed after exiting the 'using' block.");
        }

        [TestMethod]
        public void Q4_SimpleLinq()
        {
            // Assert.Inconclusive();
            // Arrange
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var expected = new List<int> { 12, 16, 20 };

            // Act
            var result = LinqProblems.FilterAndDouble(numbers);

            // Assert
            CollectionAssert.AreEqual(expected, result.ToList());
        }

        [TestMethod]
        public void Q5_Linq_GroupByAndSum()
        {
            // Assert.Inconclusive();
            // Arrange
            var sales = new List<Sale>
            {
                new Sale { Category = "Electronics", Amount = 100 },
                new Sale { Category = "Books", Amount = 50 },
                new Sale { Category = "Electronics", Amount = 150 },
                new Sale { Category = "Clothing", Amount = 80 },
                new Sale { Category = "Books", Amount = 30 },
            };
            var expected = new Dictionary<string, int>
            {
                { "Electronics", 250 },
                { "Books", 80 },
                { "Clothing", 80 }
            };

            // Act
            var result = LinqProblems.GetTotalAmountByCategory(sales);

            // Assert
            Assert.AreEqual(expected.Count, result.Count);
            Assert.AreEqual(expected["Electronics"], result["Electronics"]);
            Assert.AreEqual(expected["Books"], result["Books"]);
            Assert.AreEqual(expected["Clothing"], result["Clothing"]);
        }

        [TestMethod]
        public void Q6_OperatorOverloadingAndIEquatable()
        {
            // Assert.Inconclusive();
            // Arrange
            var m1 = new Money(10, "USD");
            var m2 = new Money(20, "USD");
            var m3 = new Money(30, "USD");
            var m4 = new Money(10, "USD");

            // Act
            var sum = m1 + m2;

            // Assert
            Assert.AreEqual(m3.Amount, sum.Amount, "The '+' operator should sum the amounts.");
            Assert.IsTrue(sum.Equals(m3), "Equals method should return true for equal values.");
            Assert.IsTrue(m1 == m4, "The '==' operator should return true for equal values.");
            Assert.IsFalse(m1 == m2, "The '==' operator should return false for different values.");
            Assert.IsTrue(m1 != m2, "The '!=' operator should work correctly.");
        }

        [TestMethod]
        public void Q7_Delegates()
        {
            // Assert.Inconclusive();
            // Arrange
            string input = "Hello World";

            // Act
            string upperResult = DelegateProblems.ProcessString(input, DelegateProblems.ToUpper);
            string lowerResult = DelegateProblems.ProcessString(input, DelegateProblems.ToLower);

            // Assert
            Assert.AreEqual("HELLO WORLD", upperResult);
            Assert.AreEqual("hello world", lowerResult);


            // Arrange
            input = "Hello World 123 d";

            // Act
            upperResult = DelegateProblems.ProcessString(input, DelegateProblems.ToUpper);
            lowerResult = DelegateProblems.ProcessString(input, DelegateProblems.ToLower);

            // Assert
            Assert.AreEqual("HELLO WORLD 123 D", upperResult);
            Assert.AreEqual("hello world 123 d", lowerResult);
        }

        // [TestMethod]
        // public void Q8_LambdaExpressions()
        // {
        //     Assert.Inconclusive();
        //     // Arrange
        //     Func<string, int> stringLengthLambda = LambdaProblems.GetStringLengthCalculator();
        //     string testString = "C# is awesome";

        //     // Act
        //     int length = stringLengthLambda(testString);

        //     // Assert
        //     Assert.AreEqual(13, length);
        // }

    //     [TestMethod]
    //     public void Q9_EventsAndObserverPattern()
    //     {
    //         Assert.Inconclusive();
    //         // Arrange
    //         var publisher = new Publisher();
    //         var subscriber = new Subscriber(publisher);
    //         var anotherSubscriber = new Subscriber(publisher);

    //         // Act
    //         publisher.RaiseEvent("First Message");
    //         publisher.RaiseEvent("Second Message");

    //         // Unsubscribe one
    //         subscriber.Unsubscribe();
    //         publisher.RaiseEvent("Third Message");

    //         // Assert
    //         Assert.AreEqual(2, subscriber.ReceivedMessages.Count);
    //         Assert.AreEqual("First Message", subscriber.ReceivedMessages[0]);
    //         Assert.AreEqual("Second Message", subscriber.ReceivedMessages[1]);

    //         Assert.AreEqual(3, anotherSubscriber.ReceivedMessages.Count);
    //         Assert.AreEqual("Third Message", anotherSubscriber.ReceivedMessages[2]);
    //     }

    //     [TestMethod]
    //     public void Q11_Closures()
    //     {
    //         Assert.Inconclusive();
    //         // Arrange
    //         Func<int> counterA = Closures.CreateCounter();
    //         Func<int> counterB = Closures.CreateCounter();

    //         // Act & Assert
    //         Assert.AreEqual(1, counterA());
    //         Assert.AreEqual(2, counterA());
    //         Assert.AreEqual(3, counterA());

    //         Assert.AreEqual(1, counterB(), "Each counter should have its own separate state (closure).");
    //         Assert.AreEqual(2, counterB());
    //     }

        [TestMethod]
        public void Q12_MultithreadingWithLock()
        {
            // Assert.Inconclusive();
            // Arrange
            var safeCounter = new SafeCounter();
            int numThreads = 10;
            int iterationsPerThread = 10000;
            var threads = new List<Thread>();

            // Act
            for (int i = 0; i < numThreads; i++)
            {
                var t = new Thread(() =>
                {
                    for (int j = 0; j < iterationsPerThread; j++)
                    {
                        safeCounter.Increment();
                    }
                });
                threads.Add(t);
                t.Start();
            }

            foreach (var t in threads)
            {
                t.Join(); // Wait for all threads to complete
            }

            // Assert
            int expectedCount = numThreads * iterationsPerThread;
            Assert.AreEqual(expectedCount, safeCounter.Count, "The counter should be thread-safe and have the correct final value.");
        }

        [TestMethod]
        public async Task Q13_AsyncAwait_ShouldReturnDataAfterDelay()
        {
            // Assert.Inconclusive();
            // Arrange
            var service = new DataService();

            // Act
            var result = await service.FetchDataAsync("user-123");

            // Assert
            Assert.AreEqual("Data for user-123", result);
        }

    //     [TestMethod]
    //     public void Q14_GenericWhereConstraints()
    //     {
    //         Assert.Inconclusive();
    //         // Arrange
    //         var customerRepo = new Repository<Customer>();
    //         var orderRepo = new Repository<Order>();

    //         // Act
    //         Customer newCustomer = customerRepo.CreateNew();
    //         newCustomer.Id = Guid.NewGuid();

    //         Order newOrder = orderRepo.CreateNew();
    //         newOrder.Id = Guid.NewGuid();

    //         // Assert
    //         Assert.IsNotNull(newCustomer);
    //         Assert.IsInstanceOfType(newCustomer, typeof(Customer));
    //         Assert.AreNotEqual(Guid.Empty, newCustomer.Id);

    //         Assert.IsNotNull(newOrder);
    //         Assert.IsInstanceOfType(newOrder, typeof(Order));
    //         Assert.AreNotEqual(Guid.Empty, newOrder.Id);
    //     }
    //     // ------------------------------
    //     // Q15: Chain of Responsibility – string transforms (expanded cases)
    //     // ------------------------------
    //     [TestMethod]
    //     public void Q15_ChainOfResponsibility_Transforms()
    //     {
    //         Assert.Inconclusive();
    //         // Build default pipeline: Trim -> Upper -> Suffix("!")
    //         IStage<string> trim = new TrimStage();
    //         IStage<string> upper = new UpperStage();
    //         IStage<string> suffix = new SuffixStage("!");

    //         // Ensure SetNext enables fluent chaining and returns the "next" stage
    //         var returned = trim.SetNext(upper);
    //         Assert.AreSame(upper, returned, "SetNext should return the stage passed in for fluent chaining.");
    //         returned.SetNext(suffix); // now pipeline is trim -> upper -> suffix

    //         // 1) Basic happy path
    //         var input = "   hello  ";
    //         var output = trim.Handle(input);
    //         Assert.AreEqual("HELLO!", output, "Pipeline should trim, uppercase, then append '!'.");
    //         Assert.AreEqual("   hello  ", input, "Original input string must remain unchanged.");

    //         // 2) Tabs/newlines as whitespace: Trim must handle all
    //         var wsInput = "\t  hello \r\n";
    //         var wsOutput = trim.Handle(wsInput);
    //         Assert.AreEqual("HELLO!", wsOutput, "Trim should remove all leading/trailing whitespace chars.");

    //         // 3) Empty/whitespace-only input
    //         var onlyWs = " \t  \n ";
    //         var onlyWsOut = trim.Handle(onlyWs);
    //         Assert.AreEqual("!", onlyWsOut, "After trimming to empty, suffix should still be applied.");

    //         // 4) Inner spaces are preserved; Upper affects all letters
    //         var sentence = "   hello world   ";
    //         var sentenceOut = trim.Handle(sentence);
    //         Assert.AreEqual("HELLO WORLD!", sentenceOut, "Inner spaces must remain; letters uppercased; suffix appended.");

    //         // 5) Removing a stage changes behavior (no Upper)
    //         IStage<string> trim2 = new TrimStage();
    //         IStage<string> suffix2 = new SuffixStage("!");
    //         trim2.SetNext(suffix2);
    //         Assert.AreEqual("hello!", trim2.Handle("  hello   "), "Without Upper stage, case must be preserved.");

    //         // 6) Order matters when suffix contains letters
    //         //   (a) Trim -> Upper -> Suffix("-ok")  => suffix letters remain lowercase
    //         IStage<string> tA = new TrimStage();
    //         IStage<string> uA = new UpperStage();
    //         IStage<string> sA = new SuffixStage("-ok");
    //         tA.SetNext(uA).SetNext(sA);
    //         Assert.AreEqual("HELLO-ok", tA.Handle("  hello  "),
    //             "With Upper before Suffix, suffix letters should not be uppercased.");

    //         //   (b) Trim -> Suffix("-ok") -> Upper  => suffix letters uppercased too
    //         IStage<string> tB = new TrimStage();
    //         IStage<string> sB = new SuffixStage("-ok");
    //         IStage<string> uB = new UpperStage();
    //         tB.SetNext(sB).SetNext(uB);
    //         Assert.AreEqual("HELLO-OK", tB.Handle("  hello  "),
    //             "With Suffix before Upper, suffix letters should be uppercased as well.");

    //         // 7) Different suffix should be honored exactly (including spaces)
    //         IStage<string> tC = new TrimStage();
    //         IStage<string> uC = new UpperStage();
    //         IStage<string> sC = new SuffixStage(" !");
    //         tC.SetNext(uC).SetNext(sC);
    //         Assert.AreEqual("HELLO !", tC.Handle("  hello  "), "Suffix with a leading space must be preserved exactly.");

    //         // 8) Rebuilding chain must not reuse prior 'next' accidentally
    //         // Build two independent pipelines and ensure they don't interfere
    //         IStage<string> trimP1 = new TrimStage();
    //         IStage<string> upperP1 = new UpperStage();
    //         IStage<string> suffixP1 = new SuffixStage("?");
    //         trimP1.SetNext(upperP1).SetNext(suffixP1);

    //         IStage<string> trimP2 = new TrimStage();
    //         IStage<string> upperP2 = new UpperStage();
    //         IStage<string> suffixP2 = new SuffixStage("!");
    //         trimP2.SetNext(upperP2).SetNext(suffixP2);

    //         Assert.AreEqual("HI?", trimP1.Handle("  hi  "), "Pipeline P1 should end with '?'.");
    //         Assert.AreEqual("HI!", trimP2.Handle("  hi  "), "Pipeline P2 should end with '!'.");
    //     }       
    // }
}