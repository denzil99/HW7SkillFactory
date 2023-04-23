using System;

namespace HW7SkillFactory
{
    abstract class Delivery
    {
        public string Address;
    }

    class HomeDelivery : Delivery
    {

    }

    class PickPointDelivery : Delivery
    {
        public string pickPointAdress;

        private string PickPointAdress
        {
            get { return pickPointAdress; }
            set
            {
                switch (value)
                {
                    case "Alekseevskaya":
                        pickPointAdress = "Alekseevskaya";
                        break;
                    case "Semyonovskaya":
                        pickPointAdress = "Semyonovskaya";
                        break;
                    case "Avtozavodskaya":
                        pickPointAdress = "Avtozavodskaya";
                        break;
                    case "Planernaya":
                        pickPointAdress = "Planernaya";
                        break;
                    default:
                        Console.WriteLine("По этому адресу нет постамата");
                        break;

                }
            }

        }
    }

    class ShopDelivery : Delivery
    {
        public string shopAdress;

        private string ShopAdress
        {
            get { return shopAdress; }
            set
            {
                switch (value)
                {
                    case "Alekseevskaya":
                        shopAdress = "Alekseevskaya";
                        break;
                    case "Semyonovskaya":
                        shopAdress = "Semyonovskaya";
                        break;
                    case "Avtozavodskaya":
                        shopAdress = "Avtozavodskaya";
                        break;
                    case "Planernaya":
                        shopAdress = "Planernaya";
                        break;
                    default:
                        Console.WriteLine("По этому адресу нет магазина");
                        break;

                }
            }

        }
    }

    abstract class Product
    {
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Product()
        {

        }
    }

    class ContainsMilk : Product
    {
        public static string Girnost;

       
        public virtual void CallTheProduct()
        {
            Console.WriteLine("Молокосодержащий продукт");
        }
    }

    class Cheese : ContainsMilk
    {
        public int ammount;

        public int Ammount
        {
            get
            {
                return ammount;
            }
            private set 
            {
                if (value <= 0) { Console.WriteLine("Не достаточно единиц на складе"); }
                else { value = ammount; }

            }
        }

        private void AddedToOrder(int amm)
        {
            Ammount -= amm;
        }

        public override void CallTheProduct()
        {
            base.CallTheProduct(); // Необязательное. Напишет: "Молокосодержащий продукт"
            Console.WriteLine("сыр");
        }
    }

    class Kefir : ContainsMilk
    {
        public override void CallTheProduct()
        {
            base.CallTheProduct(); // Необязательное. Напишет: "Молокосодержащий продукт"
            Console.WriteLine("Кефир");
        }

    }

    class Fruit : Product { }

    class Apple : Fruit { }

    class Cart
    {
        private Product[] collection; // содержит Product p = new Apple/Cheese/Kefir ()

        public Cart(Product[] collection)
        {
            this.collection = collection;
        }

        public Product this[int index]
        {
            get
            {
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }
                else
                {
                    return null;
                }
            }
        }

    }
    class Gift
    {
        public Gift() { }
    }

    class Order<TDelivery,
    TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;
        public Cart cart;
        public Gift gift = new Gift();

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        public Order(TDelivery del, Product[] collection) 
        {
            Delivery = del;
            cart = new Cart(collection);
            this.gift = gift;
        }
    }
}
