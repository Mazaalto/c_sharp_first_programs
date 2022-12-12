using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/* problem
A store is running a promotion: if the total purchase price is equal to or exceeds
10000, the price will be discounted by 20%.
The program you are given takes the total purchase price as input.
Complete the given method to take the total purchase price as an argument, and calculate and return the discounted price if campaign's requirement is satisfied.
The method should return the same price if discount is not given.

Sample Input
13000

Sample Output
10400

Explanation
13000>10000, so the discount should be given: 13000-(0.2*13000) = 10400.

My code:
*/

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write(Discount(totalPrice));
            int salaryBudget = Convert.ToInt32(Console.ReadLine());
            int percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before the increase: " + salaryBudget);
            //complete the method call
            Increase(ref salaryBudget,percent);
            Console.WriteLine("After the increase: " + salaryBudget);
            // Overloading ex
            Console.WriteLine(Add(10, 12));
            Console.WriteLine(Add(1.5, 2.9));

            // Recursion in c#
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(number));

            // Object oriented programming in c#
            //create a Welcome object with the same name
            Welcome welcome = new Welcome();
            welcome.WelcomeMessage();
            // encapsulation
            int games = Convert.ToInt32(Console.ReadLine()); 
            int wins = Convert.ToInt32(Console.ReadLine()); 

            //creating the player object
            Player player1 = new Player();
            player1.games = games;
            player1.wins = wins;

            //output
            player1.GetWinRate();

            // getter setter
            Card card1 = new Card();

            //fix the output
            Console.WriteLine(card1.AccountNum);

            Unit unit1 = new Unit();
            Unit musketeer = new Musketeer();
            Unit magician = new Magician();

            unit1.Attack();
            musketeer.Attack();
            magician.Attack();

            string color = Console.ReadLine();
            string equipment = Console.ReadLine();
            Car car = new Car(color, equipment);
            car.GetColor();
            car.GetEquipment();
        }
        static int Discount(int total)
        {
            if (total >= 10000){
                return Convert.ToInt32(total*0.8);
            } else {
                return total;
            }
        }
        // Method to calculate area of rectangle
        static int AreaRectangle(int length, int height)
        {
            return length * height;   
        }
        /* Method to If user doesn't set the language, English will be set as default.
        Complete the method with name, age and language parameters and take into account
        the default English option for language in order to correctly output the information about the provided 2 users.
        # set arguments to methods
        */
        static void Settings(string name, int age, string lang="English")
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Language: " + lang);
        }
        /*
        The program you are given takes the current salary budget and the raise percentage as input.
        It should output the salary budget before the increase, then calculate and output the budget
        with the raises included.
        Fix the program by completing the Increase() method (which should calculate the new salary budget)
        and calling it, so that the provided outputs work correctly.
        */
        static void Increase(ref int salaryBudget, int percent)
        {
            salaryBudget = salaryBudget * (percent+100)/100;
        }
        // Learning overloading
        static int Add(int a, int b)
        {
            return a+b;
        }
        //overload it for double type
        static double Add(double a, double b)
        {
            return a+b;
        }
        // recursion
        // recursive sum method
        static int Sum(int num)
        {
            //complete the recursive method
            if (num == 1) {
                return 1;
            }
            return num + Sum(num - 1);
        }
        /*Passing the first level of a video game awards the player 1 point. For each subsequent level passed,
        the points awarded increment by 1 (2 for the 2nd level, 3 for the 3rd, and so on).
        The program you are given takes the number of passed levels as input. Complete the given function to 
        take that number as an argument, and recursively calculate and return the total number of points given
        for all passed levels.
        */
        static int Points(int levels)
        {
            // I do it in recursion, because it was asked,
            // but in real life I would'nt because the calculation toll 
            if (levels == 1) {
                return 1;
            }
            return levels + Points(levels - 1);
        }
        class Welcome
        {
        //complete the class, add WelcomeMessage() method
            public void WelcomeMessage()
            {
                Console.WriteLine("Welcome to OOP");
            }
        }
        /* Encapsulation
         As seen in the previous examples, the public access modifier makes the member accessible from the outside of the class. 
        The private access modifier makes members accessible only from within the class and hides them from the outside.
        Problem: Encapsulation
        We are developing a profile system for player of our online game.
        The program already takes the number of games and wins as input and creates a player object.
        Complete the GetWinRate() method inside the given Player class to calculate and output the win rate.
        */
        class Player
        {
            public int games;
            public int wins;
            //winrate is private
            private int winrate;

             //complete the method
            public void GetWinRate()
            {
                winrate = wins*100/games;
                Console.WriteLine(winrate);
            }
        }
        /* Properties
        The program you are given should output the account number on the bank card.
        But something is wrong.
        Create a get property to access the corresponding class member and also fix the output.
        */
        class Card
        {
            private string accountNum = "0011592048120";
            //create a property to get the account
            public string AccountNum{
                get{return accountNum;}
    
            }
        
        }
        /* 
        Social Network


        You are making a social network application and want to add post creation functionality.
        As a user creates a post, the text "New post" should be automatically outputted so that then the user can add the text he/she wants to share.
        The program you are given declares a Post class with a text private field, and the ShowPost() method which outputs the content.
        Complete the class with
        - a constructor, which outputs "New post" as called,
        - Text property, which will allow you to get and set the value of the text field.
        Once you have made the changes to the program so that it works correctly, then in main, the program will take the text of the post from the user, create a post object, assign the taken value to the text field and output it.
        */
        class Post
        {
            private string text;
        
        //write a constructor here
            public Post(){
                Console.Write("New post");
            }
            public void ShowPost()
            {
                Console.WriteLine(text);
            }
        
        //write a property for member text
            public string Text //property
            {
                get { return text; }
                set { text = value; }
            } 
        }
        /*
        Arrays


        A game machine has 5 games installed on it:
        string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" }; 
        CS
        Write a program to take N number as input and output the corresponding game with N index from the array.
        If user enters an invalid number that is out of array range, the program should output "Invalid number".
        */
        class answer {
        string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };
            try {
                Console.Write(games[Int32.Parse(Console.ReadLine())]);
            }
            catch (Exception e) {
                Console.Write("Invalid number");
            }
        }
        /*Working with Strings


        You are creating an authentication system.
        The password shouldn't contain any of these symbols:
        char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' }; 
        CS
        The given program takes the password as input.

        Task
        Write a program to output "Invalid", if it contains any disallowed symbols.
        If the password requirement is satisfied, program shouldn't output anything.
        */
        class answerToString{
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };
            foreach (char character in notAllowedSymbols) {
                if (password.Contains(character)){
                    Console.Write("Invalid");
                    break;
                }
            }
        }
        class MusicGenres
        {
        private string[] genres = new string[5];
        
        //declare an indexer
        public string this[int index] {
            get {
                return genres[index];
                }
            set {

                genres[index] = value;
                }
        }
    }
    // Teamwork Makes the Dream Work
    //Overload the + operator for Score class to calculate the team score for a game.
    class Score
    {
        public int round1Score { get; set; }
        public int round2Score { get; set; }
        public Score(int r1, int r2)
        {
            round1Score = r1;
            round2Score = r2;
        }
        
        //your code goes here
        public static Score operator+(Score a, Score b) {
                int round1 = a.round1Score + b.round1Score;
                int round2 = a.round2Score + b.round2Score;
                Score res = new Score(round1, round2);
                return res;
            }
    }
    /*Dance


    In a ballroom dancing competition, each dancer from a pair is evaluated separately, and then their points are summed up to get the total pair score.
    The program you are given takes the names and the points of each dancer as input and creates a DancerPoints objects for each dancer, using the taken name and score values as parameters for constructors.
    Complete the given class, using overload + operator to return an new object where the names of dancers are in one string (see sample output) and the score is equal to the sum of their points.
    The declaration of that object and the output of its points are already written in Main()
    */
    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        //overload the + operator
        public static DancerPoints operator+ (DancerPoints a, DancerPoints b)
        {
            string names = a.name + " & "+ b.name;
            int pointstotal = a.points + b.points;
            DancerPoints uusi = new DancerPoints(names, pointstotal);
            return uusi;
           
           
        }
        
        

    }
    class Vehicle
    {
        public string Brand { get; set; }

        public void ShowBrand()
        {
            Console.WriteLine("Brand: " + Brand);
        }
    }
    
    //complete the Car class
    class Car : Vehicle
    {
        public string Model { get; set; }
        public void ShowModel(){
            Console.WriteLine("Model: " + Model);
        }
        
    }
    /* Polymorphism can be useful in many cases. For example, we could create a game where we would have different Player types with each Player having a separate behavior for the Attack method.
    In this case, Attack would be a virtual method of the base class Player and each derived class would override it.
    In a turn-based strategy game, each unit can attack.
    The standard unit attacks with a sword. But there are two more types of units - musketeers and magicians, who attack in their own way.
    The program you are given declares Unit class which has a method Attack(). It outputs "Using sword!".
    Derive Musketeer and Magician classes from the Unit class and override its Attack() method to output the corresponding messages while attacking:
    Musketeer => "Using musket!"
    Magician =>"Using magic!"
    */
     class Unit
    {
        public virtual void Attack()
        {
            Console.WriteLine("Using sword!");
        }
    }
    
    /*derive the class from Unit class
    and override Attack() method*/
    class Musketeer : Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Using musket!");

        }
        
    }
    /*derive the class from Unit class
    and override Attack() method*/
    class Magician : Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Using magic!");

        }
        
    }
    public interface IColor
    {
        void GetColor();
    }

    public interface IEquipment
    {
        void GetEquipment();
    }
    
    //implement IColor & IEquipment interfaces
    public class Car : IColor, IEquipment
    {
        public string color;
        public string equipment;

        public Car(string color, string equipment)
        {
            this.color = color;
            this.equipment = equipment;
        }
        
        public void GetColor()
        {
            Console.WriteLine("Color: "+color);
            
        }
        public void GetEquipment()
        {
            Console.WriteLine("Equipment: "+equipment);
            
        }
    }
    public interface IDraw
    {
        void StartDraw();
    }

    class Draw : IDraw
    {
        public virtual void StartDraw()
        {
            Console.WriteLine("Using pencil");
        }
    }

    //inherit this class from the class Draw
    class Brush : Draw
    {
        //implement the StartDraw() method
        public override void StartDraw()
        {
            Console.WriteLine("Using brush");
        }

    }

    //inherit this class from the class Draw
    class Spray : Draw
    {
        //implement the StartDraw() method
        public override void StartDraw()
        {
            Console.WriteLine("Using spray");
        }


    }
    struct Cuboid
    {
        public int length;
        public int width;
        public int height;

        //create a constructor
        public Cuboid(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;

        }
        
        
        //complete this method
        public int Volume()
        {
            return length*width*height;
            
        }
        //complete this method
        public int Perimeter()
        {
            return 4*(length+width+height);
            
        }
    }
    /* Enums


    A racing video game has 3 difficulty levels: Easy, Medium, and Hard.
    Each difficulty level is assigned maximum time to complete the track: the higher the difficulty, the lower the time.
    The program you are given defines Player class and Difficulty enum, and creates 3 Player objects with different difficulties as parameter for the constructor.
    Complete the Player constructor, which takes the enum as a parameter to check the time for each difficulty option and outputs the corresponding message:
    Easy => "You have 3 minutes 45 seconds"
    Medium = > "You have 3 minutes 20 seconds"
    Hard => "You have 3 minutes" 
    */
    class Player
    {
        public Player(Difficulty x)
        {
            //your code goes here
            switch (x) {
                case Difficulty.Easy:
                    Console.WriteLine("You have 3 minutes 45 seconds");
                    break;
                case Difficulty.Medium:
                    Console.WriteLine("You have 3 minutes 20 seconds");
                    break;
                case Difficulty.Hard:
                    Console.WriteLine("You have 3 minutes");
                    break;
            }
        }
    }
    enum Difficulty
    {
        Easy,
        Medium,
        Hard
    };



}