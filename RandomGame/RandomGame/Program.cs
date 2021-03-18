
using System;
using System.Collections;


interface MyGame
{
    Person Compare(Person person, ref ArrayList random,ref ArrayList userInput);
    void Result(Person person);
    void Statistic(ref ArrayList random, ref ArrayList userInput);
}

class Person:MyGame
{
    public int coin = 0;
    public int number = 0;
    
    public Person Compare(Person person, ref ArrayList random,ref ArrayList userInput)
    {
        Random rd = null;
       
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine("Please enter a number: ");
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Wrong input.");
            }
            
            rd = new Random();
            int rndmNumber = rd.Next(1, 10);
            random.Add(rndmNumber);
            userInput.Add(number);
            if (number == rndmNumber)
            {
                person.coin += 10;
            }
        }
        
        

        return person;
    }

    public void Statistic(ref ArrayList random, ref ArrayList userInput)
    {
        Console.Write("random numbers: ");
        for(int i = 0 ; i < random.Count;i++)
        {
            Console.Write(random[i] + " ");
        }
        Console.WriteLine();
        Console.Write("your numbers:   ");
        for(int i = 0 ; i < userInput.Count;i++)
        {
            
            Console.Write(userInput[i] + " ");
        }
        Console.WriteLine();

    }

    
    public void Result(Person person)
    {
        if (person.coin > 30)
        {
            Console.WriteLine("Congratulation!");
        }
        else
        {
            Console.WriteLine("You lost!");
        }
    }
    
}





class Start
{
    static void Main()
    {
        Person person = new Person();

        ArrayList arrRandom = new ArrayList();
        ArrayList arrUserInput = new ArrayList();


        person.Compare(person, ref arrRandom, ref arrUserInput);
        person.Statistic(ref arrRandom, ref arrUserInput);
        person.Result(person);

    }
}
