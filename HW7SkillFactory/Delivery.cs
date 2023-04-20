using System;

namespace HW7SkillFactory
{
    abstract class Delivery
    {
        public string Address;
    }

    class HomeDelivery : Delivery
    {
        /* ... */
    }

    class PickPointDelivery : Delivery
    {
        /* ... */
    }

    class ShopDelivery : Delivery
    {
        /* ... */
    }

    abstract class Product
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public virtual void CallTheProduct(string name)
        {
            Console.WriteLine($"{name}");
        }
        public Product()
        {

        }
    }

    class FromMilk : Product
    {
        public static string Type;


    }

    class Cheese : FromMilk
    {
        public int ammount = 100;
        public string Ammount
        {
            get { return ammount; }
            private set {
                if (ammount > 0)
                {
                    //если меньше 
                    ammount--;
                }
                else
                {
                    //если меньше 0 вернуть предупреждение
                }
            }
        }
        private int AddedToOrder(int amm)
        {

        }
    }

    class Order<TDelivery,
    TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        // ... Другие поля
    }
}
