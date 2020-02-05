using System;

namespace In_class_assignment_3
{

    class MyClass                   //class members
    {
        // Class members
        public string color = "red";        // field
        public int maxSpeed = 200;          // field

        public string model1 = "Mustang";


        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

    class Person
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Person1
    {
        public string Name  // property
        { get; set; }
    }

    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class myvehicle: Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }

    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

  

    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig1 : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Car
    {
        public String model, color;
        int year,maxSpeed;

       

        public Car()
        {
            model = "Mustang"; // Set the initial value for model
        }

        public Car(string modelName)
        {
            model = modelName;
        }

        public Car(string modelName, string modelColor, int modelYear)  // constructors with multiple parameters
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        interface IFirstInterface
        {
            void myMethod(); // interface method
        }

        interface ISecondInterface
        {
            void myOtherMethod(); // interface method
        }

        // Implement multiple interfaces
        class DemoClass : IFirstInterface, ISecondInterface
        {
            public void myMethod()
            {
                Console.WriteLine("Some text..");
            }
            public void myOtherMethod()
            {
                Console.WriteLine("Some other text...");
            }
        }

        static void Main(string[] args)   //Class and create an multiple objects 
        {

            Car myObj1 = new Car();
            Car myObj2 = new Car();
            MyClass obj1 = new MyClass();

            Console.WriteLine(obj1.color);
            Console.WriteLine(obj1.maxSpeed);

            Car myObj = new Car();
            myObj.color = "red";
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);

            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);

            obj1.fullThrottle();

            Console.WriteLine(Ford.model);  // checking value initialised by the constructor

            Car Ford1 = new Car("Mustang"); //checking parameterized constructor
            Console.WriteLine(Ford1.model);

            Car Ford2 = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford2.color + " " + Ford2.year + " " + Ford2.model);

            Console.WriteLine(obj1.model1);

            Person personobj = new Person();
            personobj.Name = "Liam";
            Console.WriteLine(personobj.Name);

            Person1 personob= new Person1();
            personob.Name = "Liam";
            Console.WriteLine(personob.Name);

            myvehicle myCar1 = new myvehicle();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar1.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar1.brand + " " + myCar1.modelName);

            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            DemoClass varmyObj = new DemoClass();           
            varmyObj.myMethod();
            varmyObj.myOtherMethod();




        }
    }



}

