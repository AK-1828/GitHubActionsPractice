using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MobileAutomation.Assertions
{
        public static class Asserts
        {
            public static void AreEqual<T>(T expected, T actual, string message = "")
            {
                try
                {

                    Assert.AreEqual(expected, actual, message);
                    Console.WriteLine($"Passed: {message}");
                }
                catch (AssertionException)
                {
                    Console.WriteLine($"Failed: {message} | Expected: {expected}, Actual: {actual}");
                    throw;
                }
            }

            public static void AreNotEqual<T>(T expected, T actual, string message = "")
            {
                try
                {
                    Assert.AreNotEqual(expected, actual, message);
                    Console.WriteLine($"Passed: {message}");
                }
                catch (AssertionException)
                {
                    Console.WriteLine($"Failed: {message} | Expected NOT: {expected}, but got: {actual}");
                    throw;
                }
            }
            public static void IsTrue(bool condition, string message = "")
            {
                try
                {
                    Assert.IsTrue(condition, message);
                    Console.WriteLine($"Passed: {message}");
                }
                catch (AssertionException)
                {
                    Console.WriteLine($"Failed: {message} | Condition was false");
                    throw;
                }
            }
            public static void IsFalse(bool condition, string message = "")
            {
                try
                {
                    Assert.IsFalse(condition, message);
                    Console.WriteLine($"Passed: {message}");
                }
                catch (AssertionException)
                {
                    Console.WriteLine($"Failed: {message} | Condition was true");
                    throw;
                }
            }
            public static void IsNull(object obj, string message = "")
            {
                try
                {
                    Assert.IsNull(obj, message);
                    Console.WriteLine($"Passed: {message}");
                }
                catch (AssertionException)
                {
                    Console.WriteLine($"Failed: {message} | Object was not null");
                    throw;
                }
            }
            public static void IsNotNull(object obj, string message = "")
            {
                try
                {
                    Assert.IsNotNull(obj, message);
                    Console.WriteLine($"Passed: {message}");
                }
                catch (AssertionException)
                {
                    Console.WriteLine($"Failed: {message} | Object was null");
                    throw;
                }
            }
            public static void Contains<T>(T expected, IEnumerable<T> collection, string message = "")
            {
                try
                {
                    CollectionAssert.Contains(collection, expected, message);
                    Console.WriteLine($"Passed: {message}");
                }
                catch (AssertionException)
                {
                    Console.WriteLine($"Failed: {message} | Collection did not contain expected item: {expected}");
                    throw;
                }
            }
            public static void Fail(string message)
            {
                Console.WriteLine($"Forced Fail: {message}");
                Assert.Fail(message);
            }
        }
    }
