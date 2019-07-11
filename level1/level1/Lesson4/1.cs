using System;

namespace ConsoleApp41
{
    class A
    {
        public int prop1 { get; set; }
        public int prop2 { get; set; }
        public int prop3 { get; set; }

        public A CopyObject()
        {
            return new A() {
                prop1 = this.prop1,
                prop2 = this.prop2,
                prop3 = this.prop3
            };
        }
    }




    class Hero
    {
        private int level;

        public Hero()
        {
            this.level = 1;
        }


        public int Level
        {
            get { return this.level; }
            private set { level = value; }

        }


        //public void SetLevel(int value)
        //{
        //    level = value;
        //}

        //private int GetLevel()
        //{
        //    return this.level;
        //}
    }
    class Program
    {

        static void Main(string[] args)
        {



            A a = new A();
            a.prop1 = 123;
            Console.WriteLine(a.prop1);

            A b = a.CopyObject();

            a.prop1 = 12345;
            Console.WriteLine(a.prop1);

            Console.WriteLine(b.prop1);

            //  Hero hero = new Hero();

            ////hero.SetLevel(10);
            //  hero.Level = 123;

            ////Console.WriteLine(hero.GetLevel());
            //  Console.WriteLine(hero.Level);
        }
    }


    //class Herro
    //{
    //    public int Level;
    //    // Methods 
    //    public Herro()
    //    {
    //        this.Level = 1;
    //    }
    //    // Methods 
    //    public void setLevel(int value)
    //    {
    //        Level = value;
    //    }

    //    // Methods 
    //    public int GetLevel()
    //    {
    //        return Level;
    //    }

    //}

    //class Program2
    //{
    //    static void Main(string[] args)
    //    {
    //        Herro herro = new Herro();
    //        herro.setLevel(10);
    //        Console.WriteLine(herro.GetLevel());
    //    }
    //}


    class Herro
    {
        public int Level;

        public Herro()
        {
            this.Level = 1;
        }

        public int level
        {
            get { return this.level; }
            set { level = value; }
        }

        public int GetLevel()
        {
            return Level;
        }

    }

    class Program2
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.prop1 = 123;  // a= 123

            A b =  a.CopyObject(); // a = 123
            a.prop1 = 12345;//  a 12345

            //Herro herro = new Herro();
            //herro.Level = 123;

            //Console.WriteLine(herro.GetLevel());
        }
    }


}

