using System;

class GFG
{

    // Main Method
    static public void Main(String[] args)
    {
        Console.WriteLine("Welcome user!");
List<string> taskList = new List<string>();
        string choose = "";

        while (choose != "exit")
        {
            Console.WriteLine("What would you whant to do?");
            Console.WriteLine("Enter 1 to add a task to the list");
            Console.WriteLine("Enter 2 to remove a task from the list");
            Console.WriteLine("Enter 3 to view the list");
            Console.WriteLine("Enter exit to exit the program");


           choose = Console.ReadLine();

            switch (choose)
            {

                case "1":
                    
                    Console.WriteLine("Enter the name of the task you want to add");
                    String task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added");
                    break;
                case "2":
                    
                    Console.WriteLine("The number of the task you whant to remove");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + ": " + taskList[i]);




                    }
                    int tasknumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(tasknumber);

                    break;


              
                case "x":
                   
                    Console.WriteLine(result);



                    break;



            }


        }

    }

}