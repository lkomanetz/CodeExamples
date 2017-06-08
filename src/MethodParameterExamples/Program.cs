using System;
using System.Collections.Generic;

namespace MethodParameterExamples {

    class Program {

        static void Main(string[] args) {
            TestClass objA = new TestClass() { Id = 'A', IntegerProperty = 1 };
            TestClass objB = new TestClass() { Id = 'B', IntegerProperty = 1 };
            TestClass objC = new TestClass() { Id = 'C', IntegerProperty = 1 };

            UpdateIntegerProperty(objA);
            UpdateIntegerProperty(ref objB);
            UpdateIntegerPropertyEx(objC);

            IList<TestClass> testObjects = new List<TestClass>() { objA, objB, objC };

            foreach (TestClass item in testObjects) {
                Console.WriteLine($"ID: {item.Id}\tValue: {item.IntegerProperty}");
            }
        }

        static void UpdateIntegerProperty(TestClass obj) {
            obj.IntegerProperty = 2;
        }

        static void UpdateIntegerPropertyEx(TestClass obj) {
            obj = new TestClass();
            obj.IntegerProperty = 2;
        }

        static void UpdateIntegerProperty(ref TestClass obj) {
            obj = new TestClass();
            obj.IntegerProperty = 2;
        }

    }

}
