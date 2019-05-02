# AcuCafe Project

Techical test

## Problem

AcuCafe has an ordering system which is poorly designed and sometime fails to deliver the right orders. For example, some of the clients complaint that their ice tea had milk in it. Also, the system turned out to be a maintenance nightmare as it is difficult to add new drinks.

### Prerequisites

In order to redesign the system, I considered the following point:
* Could be different types of coffee
* Could be different types of tea
* Coffee couldn’t be ordered with tea
* Coffee could have different types of add-ins
* Tea could have different types of add-ins
* IceTea hasn’t Milk as an add-in (as a rule)
* Tea hasn’t Chocolate as an add-in ( as a rule)
* Could be new types of coffee
* Could be new types of tea
* Could be new types of add-ins
* Could be new add-ins rules

### Chosen Design

Thinking about the first three points of the list, I  have decided to implement  Abstract factory pattern. This pattern helps us to create a factory of factories. So I have built a Coffee factory which creates different types of coffee and a Tea Factory which creates different types of tea. With this approach, I find easier to add a new coffee or tea.

#### Abstract Factory Code
Common interface for all drinks
```
public interface IDrink
{
   string Prepare();
   double Cost();
}

```
This is the Abstract Factory
```
public abstract class AbstractAcuCafeFactory
{
    public abstract IDrink GetDrink(AcuCafeEnum.EnumDrinks drinkDescription);
}

```
Next, you can see how was coding the Concrete Coffee Factory
```
public class CoffeeFactory : AbstractAcuCafeFactory
    {
        public override IDrink GetDrink(AcuCafeEnum.EnumDrinks drinkDescription)
        {
            IDrink oDrink;
            try
            {                
                switch (drinkDescription)
                {
                    case AcuCafeEnum.EnumDrinks.EXPRESSO:
                        oDrink = new Expresso();
                        break;
                    case AcuCafeEnum.EnumDrinks.RISTRETTO:
                        oDrink = new Ristretto();
                        break;
                    case AcuCafeEnum.EnumDrinks.LUNGO:
                        oDrink = new Lungo();
                        break;
                    default:
                        throw new Exception("Undefine Drink. We can not manage the order.");  
                }

                return oDrink;
            }
            catch (Exception ex)
            {
                throw ex;
            }         
        }
    }
```
Finally, I have developed a class that manage the creation of the factories depended on the order:

```
public class AcuCafeFactoryProducer
    {
        public static AbstractAcuCafeFactory GetAcuCafeFactory(bool isCoffee)
        {
            if (isCoffee)
            {
                return new CoffeeFactory();
            }
            else
            {
                return new TeaFactory();
            }
        }
    }
```

About the add-ins for the drink and about some drinks rules, I have decided to implement the Decorator pattern in order to resolve that task. This pattern creates a decorator class which wraps the original class and provides additional functionality keeping class methods signature intact


### Decorator Pattern code


```
 public abstract class AddinDecorator : IDrink
    {
        IDrink oDrink;

        protected string addInName;
        protected double addInPrice;


        public AddinDecorator(IDrink pDrink)
        {
            oDrink = pDrink;
        }

        public double Cost()
        {
            return oDrink.Cost() + addInPrice;
        }

        public string Prepare()
        {
            return string.Format("{0}, {1}", oDrink.Prepare(), addInName);
        }
    }
```



```
public class MilkDecorator: AddinDecorator
    {
        public MilkDecorator(IDrink drink)
        : base(drink)
        {
            addInName = "Milk";
            addInPrice = 0.5;
        }
    }
```

```
public static IDrink ProcessCoofeeAddIns(IDrink drinkOrder, bool hasMilk, bool hasSugar, bool hasChocolate)
        {
            try
            {
                IDrink fullDrink;
                //in this case every coffee allow every addIns
                if (hasMilk && hasSugar && hasChocolate)
                    return fullDrink = new MilkDecorator(new SugarDecorator(new ChocolateDecorator(drinkOrder)));
                else if (!hasMilk && hasSugar && hasChocolate)
                    return fullDrink = new SugarDecorator(new ChocolateDecorator(drinkOrder));
                else if (hasMilk && !hasSugar && hasChocolate)
                    return fullDrink = new MilkDecorator(new ChocolateDecorator(drinkOrder));
                if (hasMilk && hasSugar && !hasChocolate)
                    return fullDrink = new MilkDecorator(new SugarDecorator(drinkOrder));
                else if (!hasMilk && !hasSugar && hasChocolate)
                    return fullDrink = new ChocolateDecorator(drinkOrder);
                else if (hasMilk && !hasSugar && !hasChocolate)
                    return fullDrink = new MilkDecorator(drinkOrder);
                else if (!hasMilk && hasSugar && !hasChocolate)
                    return fullDrink = new SugarDecorator(drinkOrder);
                else
                    //drink without addIns
                    return drinkOrder;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
```

## Running the tests

