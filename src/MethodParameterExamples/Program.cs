using System;
using System.Collections.Generic;

namespace MethodParameterExamples {

    class Program {

        static void Main(string[] args) {
            TestClass objA = new TestClass() { Id = 'A', IntegerProperty = 1 };
            TestClass objB = new TestClass() { Id = 'B', IntegerProperty = 1 };
            TestClass objC = new TestClass() { Id = 'C', IntegerProperty = 1 };

            IncrementIntegerProperty(objA);
            IncrementIntegerProperty(ref objB);
            IncrementIntegerPropertyEx(objC);

            IList<TestClass> testObjects = new List<TestClass>() { objA, objB, objC };

            foreach (TestClass item in testObjects) {
                Console.WriteLine($"ID: {item.Id}\tValue: {item.IntegerProperty}");
            }
        }

        static void IncrementIntegerProperty(TestClass obj) {
            obj.IntegerProperty = 2;
        }

        static void IncrementIntegerPropertyEx(TestClass obj) {
            obj = new TestClass();
            obj.IntegerProperty = 2;
        }

        static void IncrementIntegerProperty(ref TestClass obj) {
            obj = new TestClass();
            obj.IntegerProperty = 2;
        }

    }

}
