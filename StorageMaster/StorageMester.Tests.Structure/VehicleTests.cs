using NUnit.Framework;
using StorageMaster;
using StorageMaster.Entities.Products;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace StorageMester.Tests.Structure
{
        [TestFixture]
    public class VehicleTests
    {
        private Type vehicle;

        [SetUp]
        public void Setup()
        {
            this.vehicle = typeof(Vehicle);
        }

        [Test]
        public void ValidateAllVehicles()
        {
            var types = new[]
            {
                "Semi",
                "Truck",
                "Van",
                "Vehicle"
            };

            foreach (var current in types)
            {
                var currentType = GetType(current);
                Assert.That(currentType, Is.Not.Null, $"{current} doesn't exist");
            }
        }

        [Test]
        public void ValidateVehicleProperties()
        {
            var properties = vehicle.GetProperties();
            var propsAndReturnTypes = new Dictionary<string, Type>();
            propsAndReturnTypes.Add("Capacity", typeof(int));
            propsAndReturnTypes.Add("Trunk", typeof(IReadOnlyCollection<Product>));
            propsAndReturnTypes.Add("IsFull", typeof(bool));
            propsAndReturnTypes.Add("IsEmpty", typeof(bool));

            var expectedProperties = new[] { "Capacity", "Trunk", "IsFull", "IsEmpty" };

            foreach (var item in properties)
            {
                var propertyExists = expectedProperties.Any(x => x == item.Name);

                Assert.That(propertyExists);
            }

            foreach (var item in properties)
            {
                var isValidProp = propsAndReturnTypes.Any(x => x.Key == item.Name && item.PropertyType == x.Value);

                Assert.That(isValidProp);
            }
        }

        [Test]
        public void ValidateVehicleMethods()
        {

            var expectedMethods = new List<Method>();
            expectedMethods.Add(new Method("LoadProduct", typeof(void), typeof(Product)));
            expectedMethods.Add(new Method("Unload", typeof(Product)));

            var loadProductMethod = vehicle
                .GetMethod("LoadProduct");
            var unloadMethod = vehicle
                .GetMethod("Unload");

            Assert.That(loadProductMethod, Is.Not.Null);
            Assert.That(unloadMethod, Is.Not.Null);

            var loadProductReturnType = loadProductMethod.ReturnType == typeof(void);
            var unloadReturnType = unloadMethod.ReturnType == typeof(Product);

            Assert.That(loadProductReturnType);
            Assert.That(unloadReturnType);
        }

        [Test]
        public void ValidVehicleFields()
        {
            var trunkField = vehicle.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).First(x => x.Name == "trunk");

            Assert.That(trunkField, Is.Not.Null, "InvalidField");
        }

        [Test]
        public void CheckInheritance()
        {
            Type[] types = Assembly.GetAssembly(vehicle).GetTypes();
            Type[] inheretingType = types.Where(x => vehicle.IsAssignableFrom(x)).ToArray();
            string[] vehicles = { "Semi", "Truck", "Van" };

            for (int i = 0; i < inheretingType.Length-1; i++)
            {
                Assert.That(vehicles.Contains(inheretingType[i].Name));
            }
        }

        [Test]
        public void CheckConstructor()
        {
            var constructor = vehicle.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance).FirstOrDefault();

            Assert.That(constructor, Is.Not.Null);

            var constParams = constructor.GetParameters();

            Assert.That(constParams[0].ParameterType, Is.EqualTo(typeof(int)));
        }

        [Test]
        public void ValidateVehicleIsAbstract()
        {
            Assert.That(vehicle.IsAbstract);
        }

        private class Method
        {
            public Method(string name, Type returnType, params Type[] inputParameters)
            {
                Name = name;
                ReturnType = returnType;
                InputParameters = inputParameters;
            }

            public string Name { get; set; }
            public Type ReturnType { get; set; }
            public Type[] InputParameters { get; set; }
        }

        public Type GetType(string current)
        {
            var type = typeof(StartUp).Assembly.GetTypes().First(x => x.Name == current);

            return type;
        }
    }
}
