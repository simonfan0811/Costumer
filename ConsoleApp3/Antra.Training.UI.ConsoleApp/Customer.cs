using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Training.UI.ConsoleApp
{
    class Customer
    {
        int cid;
        string name;
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setId(int cid)
        {
            this.cid = cid;
        }
        public int getId()
        {
            return cid;
        }
        public virtual void AddCustomer()
        {
            Console.Write("Enter Id -> ");
            setId(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter Name -> ");
            setName(Console.ReadLine());

        }
        public virtual void print()
        {
            Console.WriteLine("--------------Information-----------------");
            Console.WriteLine("Customer: " + getName());
            Console.WriteLine("CustomerId : " + getId());
        }
    }
    class BronzeCustomer : Customer
    {   

        string lvl = "Bronze";
        string mobile;
        public void setLvl(string lvl)
        {
            this.lvl = lvl;
        }
        public string getLvl()
        {
            return this.lvl;
        }
        public override void AddCustomer()
        {
            base.AddCustomer();
            Console.WriteLine("Welcome Bronze Customer!!!");
            Console.WriteLine("please enter Mobile:");
            this.mobile = Console.ReadLine();
        }
        public override void print()
        {
            base.print();
            Console.WriteLine("Customer Level :" + this.lvl);
            Console.WriteLine("Customer Mobile : " + this.mobile);
        }
    }

    class SilverCustomer : Customer
    {

        string lvl = "Silver";
        string mobile;
        public void setLvl(string lvl)
        {
            this.lvl = lvl;
        }
        public string getLvl()
        {
            return this.lvl;
        }
        public override void AddCustomer()
        {
            base.AddCustomer();
            Console.WriteLine("Welcome Silver Customer!!!");
            Console.WriteLine("please enter Mobile:");
            this.mobile = Console.ReadLine();
        }
        public override void print()
        {
            base.print();
            Console.WriteLine("Customer Level :" + this.lvl);
            Console.WriteLine("Customer Mobile : " + this.mobile);
        }
    }

    class GoldCustomer : Customer
    {

        string lvl = "$- Gold -$";
        string mobile;
        public void setLvl(string lvl)
        {
            this.lvl = lvl;
        }
        public string getLvl()
        {
            return this.lvl;
        }
        public override void AddCustomer()
        {
            base.AddCustomer();
            Console.WriteLine("Welcome $- Gold -$ Customer!!!");
            Console.WriteLine("please enter Mobile:");
            this.mobile = Console.ReadLine();
        }
        public override void print()
        {
            base.print();
            Console.WriteLine("Customer Level :" + this.lvl);
            Console.WriteLine("Customer Mobile : " + this.mobile);
        }
    }

    class PlatinumCustomer : Customer
    {

        string lvl = "-$-$-$- Platinum -$-$-$-";
        string mobile;
        public void setLvl(string lvl)
        {
            this.lvl = lvl;
        }
        public string getLvl()
        {
            return this.lvl;
        }
        public override void AddCustomer()
        {
            base.AddCustomer();
            Console.WriteLine("Welcome -$-$-$- Platinum -$-$-$- Customer!!!");
            Console.WriteLine("please enter Mobile:");
            this.mobile = Console.ReadLine();
        }
        public override void print()
        {
            base.print();
            Console.WriteLine("Customer Level :" + this.lvl);
            Console.WriteLine("Customer Mobile : " + this.mobile);
        }
    }

    enum CustomerOptions
    {
        BronzeCustomer = 1,
        SilverCustomer,
        GoldCustomer,
        PlatinumCustomer
    }
    class CustomerLevel
    {
        public Customer chooseLvl()
        {
            
            string[] names = Enum.GetNames(typeof(CustomerOptions));
            int[] values = (int[])Enum.GetValues(typeof(CustomerOptions));
            int OptionsLength = names.Length;
            for (int i = 0; i < OptionsLength; i++)
            {
                
                Console.WriteLine("Choose {0} Press {1}", names[i], values[i]); 
            }
            int choosen = Convert.ToInt32(Console.ReadLine());
            switch (choosen)
            {
                case (int)CustomerOptions.BronzeCustomer:
                    return new BronzeCustomer();
                case (int)CustomerOptions.SilverCustomer:
                    return new SilverCustomer();
                case (int)CustomerOptions.GoldCustomer:
                    return new GoldCustomer();
                case (int)CustomerOptions.PlatinumCustomer:
                    return new PlatinumCustomer();
            }
            return null;
        }
    }
}
