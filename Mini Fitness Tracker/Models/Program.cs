using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        /*

                // Create a new user
                User user1 = new User("Yahya", 22, 70.5, 1.75);


                // Show the user's profile
                user1.ShowProfile();
                Console.WriteLine(@"Note that the BMI categories are as follows:
                                    BMI < 18.5 => underweight

                                    BMI 18.5-24.9 => normal weight

                                    BMI 25-29.9 => overweightt

                                    BMI >= 30 => obese"
                );

                user1.UpdateProfile("Yahya 23244124123421", 23, 75.0, 1.75);
                user1.ShowProfile();
        


        Dictionary<int, string> sub = new Dictionary<int, string>();

        // Adding elements
        sub.Add(1, "C#");
        sub.Add(2, "Javascript");
        sub.Add(3, "Dart");

        // Displaying dictionary
        foreach (var ele in sub){
            Console.WriteLine($"Key: {ele.Key}, Value: {ele.Value}");
        }
        */


        Exercise jogging = new Exercise("Jogging", "Cardio", 8.5);
        

        double totalCalories = jogging.CalculateCalories(30);
        Console.WriteLine("Calories burned in 30 minutes: " + totalCalories);


        
        Exercise habd = new Exercise("habd", "Cardio", 8.5);
        habd.ShowExercise();
        Exercise pushups = new Exercise("Push-ups", "Strength", 6.0);
        pushups.ShowExercise();





        WorkoutPlan todayPlan = new WorkoutPlan(DateTime.Now);
        todayPlan.ShowWorkoutPlan();


        WorkoutPlan plan = new WorkoutPlan(DateTime.Today);
        plan.ShowWorkoutPlan();


        todayPlan.ShowWorkoutPlan();















        Progresstracker tracker = new Progresstracker();
        tracker.UpdateProgress(60, 500, "finished");
        tracker.ShowProgress();
        tracker.DisplaydailyProgress();





        /*

                Console.WriteLine("enter your name");
                string? name = Console.ReadLine();

                Console.WriteLine("enter your age");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter your weight in kg");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter your height in cm ");
                double height = Convert.ToDouble(Console.ReadLine());
                height = height / 100.0;
                User user = new User(name, age, weight, height);
                user.Showprofile();




                User user1 = new User("John", 25, 70, 1.75);
                user1.Showprofile();
                user1.Updateprofile("John Doe", 26, 72, 1.76);
                user1.Showprofile();


        */

        Console.WriteLine("press enter to exit");
        Console.ReadLine();
    }
}


