using AcuCafeCore;
using AcuCafeCore.Addins;
using AcuCafeCore.Factories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafeTest
{
    [TestFixture]
    public class AcuCafeUnitTest
    {

        

        #region ExpressoTest
        [Test]
        public void OrderExpresso()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkOrder = AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.EXPRESSO);
            Assert.AreEqual("Expresso", drinkOrder.Prepare());
            Assert.AreEqual(1.8, drinkOrder.Cost());
        }

        [Test]
        public void OrderExpresso_WithMilk()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.EXPRESSO), true, false, false);
            Assert.AreEqual("Expresso, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(1.8 + 0.5, drinkFullOrder.Cost());
        }
        [Test]
        public void OrderExpresso_WithSugar()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.EXPRESSO), false, true, false);
            Assert.AreEqual("Expresso, Sugar", drinkFullOrder.Prepare());
            Assert.AreEqual(1.8 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderExpresso_WithChocolate()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.EXPRESSO), false, false, true);
            Assert.AreEqual("Expresso, Chocolate", drinkFullOrder.Prepare());
            Assert.AreEqual(1.8 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderExpresso_WithSugarAndMilk()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.EXPRESSO), true, true, false);
            Assert.AreEqual("Expresso, Sugar, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(1.8 + 0.5 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderExpresso_WithSugarAndChocolate()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.EXPRESSO), false, true, true);
            Assert.AreEqual("Expresso, Chocolate, Sugar", drinkFullOrder.Prepare());
            Assert.AreEqual(1.8 + 0.5 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderExpresso_WithMilkAndChocolate()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.EXPRESSO), true, false, true);
            Assert.AreEqual("Expresso, Chocolate, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(1.8 + 0.5 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderExpresso_WithMilkAndSugarAndChocolate()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.EXPRESSO), true, true, true);
            Assert.AreEqual("Expresso, Chocolate, Sugar, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(1.8 + 0.5 + 0.5 + 0.5, drinkFullOrder.Cost());
        }

        #endregion

        #region RistrettoTest

        [Test]
        public void OrderRistretto()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkOrder = AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.RISTRETTO);
            Assert.AreEqual("Ristretto", drinkOrder.Prepare());
            Assert.AreEqual(1.5, drinkOrder.Cost());
        }

        [Test]
        public void OrderRistretto_WithMilk()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.RISTRETTO), true, false, false);
            Assert.AreEqual("Ristretto, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(1.5 + 0.5, drinkFullOrder.Cost());
        }
        [Test]
        public void OrderRistretto_WithSugar()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.RISTRETTO), false, true, false);
            Assert.AreEqual("Ristretto, Sugar", drinkFullOrder.Prepare());
            Assert.AreEqual(1.5 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderRistretto_WithChocolate()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.RISTRETTO), false, false, true);
            Assert.AreEqual("Ristretto, Chocolate", drinkFullOrder.Prepare());
            Assert.AreEqual(1.5 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderRistretto_WithSugarAndMilk()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.RISTRETTO), true, true, false);
            Assert.AreEqual("Ristretto, Sugar, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(1.5 + 0.5 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderRistretto_WithSugarAndChocolate()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.RISTRETTO), false, true, true);
            Assert.AreEqual("Ristretto, Chocolate, Sugar", drinkFullOrder.Prepare());
            Assert.AreEqual(1.5 + 0.5 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderRistretto_WithMilkAndChocolate()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.RISTRETTO), true, false, true);
            Assert.AreEqual("Ristretto, Chocolate, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(1.5 + 0.5 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderRistretto_WithMilkAndSugarAndChocolate()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.RISTRETTO), true, true, true);
            Assert.AreEqual("Ristretto, Chocolate, Sugar, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(1.5 + 0.5 + 0.5 + 0.5, drinkFullOrder.Cost());
        }
        #endregion

        #region LungoTest

        [Test]
        public void OrderLungo()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkOrder = AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.LUNGO);
            Assert.AreEqual("Lungo", drinkOrder.Prepare());
            Assert.AreEqual(2, drinkOrder.Cost());
        }

        [Test]
        public void OrderLungo_WithMilk()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.LUNGO), true, false, false);
            Assert.AreEqual("Lungo, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(2 + 0.5, drinkFullOrder.Cost());
        }
        [Test]
        public void OrderLungo_WithSugar()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.LUNGO), false, true, false);
            Assert.AreEqual("Lungo, Sugar", drinkFullOrder.Prepare());
            Assert.AreEqual(2 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderLungo_WithChocolate()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.LUNGO), false, false, true);
            Assert.AreEqual("Lungo, Chocolate", drinkFullOrder.Prepare());
            Assert.AreEqual(2 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderLungo_WithSugarAndMilk()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.LUNGO), true, true, false);
            Assert.AreEqual("Lungo, Sugar, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(2 + 0.5 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderLungo_WithSugarAndChocolate()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.LUNGO), false, true, true);
            Assert.AreEqual("Lungo, Chocolate, Sugar", drinkFullOrder.Prepare());
            Assert.AreEqual(2 + 0.5 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderLungo_WithMilkAndChocolate()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.LUNGO), true, false, true);
            Assert.AreEqual("Lungo, Chocolate, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(2 + 0.5 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderLungo_WithMilkAndSugarAndChocolate()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(true);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.LUNGO), true, true, true);
            Assert.AreEqual("Lungo, Chocolate, Sugar, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(2 + 0.5 + 0.5 + 0.5, drinkFullOrder.Cost());
        }

        #endregion

        #region TeaTest
        public void OrderTea()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(false);
            IDrink drinkOrder = AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.TEA);
            Assert.AreEqual("Tea", drinkOrder.Prepare());
            Assert.AreEqual(1.5, drinkOrder.Cost());
        }

        [Test]
        public void OrderTea_WithMilk()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(false);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessTeaAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.TEA), true, false);
            Assert.AreEqual("Tea, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(1.5 + 0.5, drinkFullOrder.Cost());
        }
        [Test]
        public void OrderTea_WithSugar()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(false);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessTeaAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.TEA), false, true);
            Assert.AreEqual("Tea, Sugar", drinkFullOrder.Prepare());
            Assert.AreEqual(1.5 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderTea_WithSugarAndMilk()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(false);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.TEA), true, true, false);
            Assert.AreEqual("Tea, Sugar, Milk", drinkFullOrder.Prepare());
            Assert.AreEqual(1.5 + 0.5 + 0.5, drinkFullOrder.Cost());
        }
        #endregion

        #region IceTeaTest

        public void OrderIceTea()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(false);
            IDrink drinkOrder = AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.ICETEA);
            Assert.AreEqual("IceTea", drinkOrder.Prepare());
            Assert.AreEqual(1.8, drinkOrder.Cost());
        }

        [Test]
        public void OrderIceTea_WithSugar()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(false);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessTeaAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.ICETEA), false, true);
            Assert.AreEqual("IceTea, Sugar", drinkFullOrder.Prepare());
            Assert.AreEqual(1.8 + 0.5, drinkFullOrder.Cost());
        }

        [Test]
        public void OrderIceTea_WithMilk()
        {
            AbstractAcuCafeFactory AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(false);
            IDrink drinkFullOrder = AcuCafeAddInsRules.ProcessTeaAddIns(AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.ICETEA), true, false);
            Assert.AreEqual("IceTea", drinkFullOrder.Prepare());
            Assert.AreEqual(1.8, drinkFullOrder.Cost());
        }
        #endregion




    }
}
