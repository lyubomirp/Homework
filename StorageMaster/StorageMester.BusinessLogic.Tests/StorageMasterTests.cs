using NUnit.Framework;
using System;
using StorageMaster.Core;
using StorageMaster;
using System.Reflection;
using System.Collections;
using StorageMaster.Entities.Products;
using System.Collections.Generic;

namespace StorageMester.BusinessLogic.Tests
{
    [TestFixture]
    public class StorageMasterTests
    {
        [Test]
        public void ValidateAddProductMethod()
        {
            var storageMasterType = typeof(StorageMaster.Core.StorageMaster);
            var addProductMethod = storageMasterType.GetMethod("AddProduct");

            var instance = Activator.CreateInstance(storageMasterType, true);
            string productType = "SolidStateDrive";
            double price = 230.41;

            var actualResult = addProductMethod.Invoke(instance,  new object[] { productType, price });

            var expectedResult = $"Added SolidStateDrive to pool";

            Assert.AreEqual(expectedResult, actualResult);

            var productPoolField = (IDictionary<string, Stack<Product>>)storageMasterType.GetField
                ("productsPool", (BindingFlags)62).GetValue(instance);

            Assert.That(productPoolField[productType].Count, Is.EqualTo(1));
        }

        [Test]
        public void RegisterStorage()
        {
            var storageMasterType = typeof(StorageMaster.Core.StorageMaster);
            var registerStorageMethod = storageMasterType.GetMethod("RegisterStorage");

            string storageType = "DistributionCenter";
            string name = "Gosho";

            var instance = Activator.CreateInstance(storageMasterType, true);

            var actualResult = registerStorageMethod.Invoke(instance, new object[] { storageType, name });
            var expectedResult = $"Registered Gosho";
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void ValidateSendVehicleToMethod()
        {
            var storageMasterType = typeof(StorageMaster.Core.StorageMaster);
            var registerStorageMethod = storageMasterType.GetMethod("RegisterStorage");
            var instance = Activator.CreateInstance(storageMasterType, true);

            string firstStorageType = "DistributionCenter";
            string firstName = "Gosho";

            string secondStorageType = "AutomatedWarehouse";
            string secondName = "Pesho";

            registerStorageMethod.Invoke(instance, new object[] { firstStorageType, firstName });
            registerStorageMethod.Invoke(instance, new object[] { secondStorageType, secondName});

            var sendVehicleToMethod = storageMasterType.GetMethod("SendVehicleTo").Invoke(instance, new object[] { "Gosho", 0, "Pesho" });

            var expectedResult = "Sent Van to Pesho (slot 1)";

            Assert.AreEqual(expectedResult, sendVehicleToMethod);
        }

        
    }
}
