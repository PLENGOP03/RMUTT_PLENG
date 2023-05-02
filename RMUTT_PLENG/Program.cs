// See https://aka.ms/new-console-template for more information





using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;



/*
LAP1
Console.WriteLine("---Student 1---");
Console.Write("Name : ");
string Name1 = Console.ReadLine();
Console.Write("Input Weight(kg) : ");
double W1 = double.Parse(Console.ReadLine());
Console.Write("Input Height(cm) : ");
double H1 = double.Parse(Console.ReadLine());

Console.WriteLine("---Student 2---");
Console.Write("Name : ");
string Name2 = Console.ReadLine();
Console.Write("Input Weight(kg) : ");
double W2 = double.Parse(Console.ReadLine());
Console.Write("Input Height(cm) : ");
double H2 = double.Parse(Console.ReadLine());
double BMI1 = Math.Round(W1 / Math.Pow(H1 / 100, 2), 2);
double BMI2 = Math.Round(W2 / Math.Pow(H2 / 100, 2), 2);

Console.WriteLine($"\n{Name1.ToUpper()} BMI = {BMI1}");
Console.WriteLine($"{Name2.ToUpper()} BMI = {BMI2}");

Console.WriteLine($"\nMax BMI = {Math.Max(BMI1, BMI2)}");




LAP2
Console.WriteLine("Your Position : ");
string position = Console.ReadLine();

Console.WriteLine("Your Salary : ");
float salary = float.Parse(Console.ReadLine());

switch (position) { 
    case "Assistant Developer":
        salary *= 1.05f;
        break;
    case "IT Support":
        salary *= 1.07f;
        break;
    case "Senior Developer":
        salary *= 1.1f;
        break;
    case "Administrator":
        salary *= 1.08f;
        break;
    default:
        salary *= 1.03f;
        break;
}

Console.WriteLine($"Your Salary = {Math.Round(salary)}");





LAP3
bool exit = false;
while (!exit) {



    Console.Write("Input Number of Student? :");
    int NumberofStudent = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("------------------------------------");

    Dictionary<string, int> IDandSCORE = new Dictionary<string, int>();



    for (int i = 0; i < NumberofStudent; i++)
    {



        Console.WriteLine("Number of Student? : {0}", NumberofStudent);
        Console.Write("Input studentID :");
        string stuname1 = Console.ReadLine();

        Console.Write("score :");
        int score1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("studentID: {0}", stuname1);
        Console.WriteLine("score is : {0}", score1);
        IDandSCORE.Add(stuname1, score1);



    }
         
        string exitChoice = "";
        while (exitChoice != "Y" && exitChoice != "N")
        {
            Console.WriteLine("----------------");
            Console.Write("Exit? (Y/N): ");
            exitChoice = Console.ReadLine().ToUpper();
        }
        if (exitChoice == "N")
        {
            continue;  
        }
        else if (exitChoice == "Y")
        {
        
        exit = true;
        }




    Console.WriteLine("Result");
    Console.WriteLine("All Students: " + IDandSCORE.Count);

    var maxKVP = IDandSCORE.MaxBy(kvp => kvp.Value);
    var count = maxKVP.Value;

    Console.WriteLine($"Max of students: ({count})");

    var minKVP = IDandSCORE.MinBy(kvp => kvp.Value);
    var countt = minKVP.Value;

    Console.WriteLine($"Min of students: ({countt})");


}


LAP4

namespace Test01
{
     class cars
    {
        private string carname;
        private int price;
        public string Carname
        { 
            get { return Carname; }
            set { Carname = value;} 
        }
        public int Price
        { 
            get { return Price; } 
            set { Price = value; } 
        }
        public  double multiply(int price)
        {
            return Price*0.07;
        }
        
        
    

        public class CAR : cars 
    {

        private string cartype;


            public CAR(string cartype) {

            Console.WriteLine("car type:",cartype);
            
            
            }

        public CAR(string carname, int price)

      {
         Carname = carname;
         Price = price;
      }
        public int Add(int Price) {

              return Price + 5;
        }



     }
        
        public cars()
        {
            this.Carname = "ToYoTa";
            this.Price = 60000;


      }
}


    public class Program
    {
        public void Main()
        {


            cars c1 = new cars();

            c1.Carname = "Nissan";
            c1.Price = 500000;
            c1.multiply(20000);

            CAR c2 = new CAR();
            c2.CAR("Sedan");



        }
    }

















*/







