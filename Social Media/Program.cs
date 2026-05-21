using Social_Media;
using System.ComponentModel;



Console.WriteLine("Hello, World!");

List<user_account> user_accountslist = new List<user_account>();
user_account user_account = new user_account("John Doe", 30, "Software Developer", "gamming");
user_account user_account2 = new user_account("Jane Smith", 25, "Graphic Designer", "football");
user_account user_account3 = new user_account("Alice Johnson", 28, "Content Creator", "basketball");
user_account user_account4 = new user_account("Bob Brown", 35, "Marketing Specialist", "running");

user_accountslist.Add(user_account);
user_accountslist.Add(user_account2);
user_accountslist.Add(user_account3);
user_accountslist.Add(user_account4);

user_account mainuser = new user_account("omar", 26, "IT STUDENT", "gaming");
List<user_account> myFreinds  = new List<user_account>();



bool kjører = true;

while (kjører)
{
    Console.WriteLine($"Logged in as: {mainuser.Name}");
    Console.WriteLine("1. Show all users");
    Console.WriteLine("2. Add Friend");
    Console.WriteLine("3. Remove Friend");
    Console.WriteLine("4. Show my friends");
    Console.WriteLine("5. View friend profile");
    Console.WriteLine("6. Exit");
    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            foreach (user_account user_Account in user_accountslist)
            {
                Console.WriteLine($"Name: {user_Account.Name}, Age: {user_Account.Age}, Job: {user_Account.Job}, Hobby: {user_Account.Hobby}");
            }

            break;

            case "2":
            Console.WriteLine("Choose a user to add as friend:");
            for (int i = 0; i < user_accountslist.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {user_accountslist[i].Name}");
            }
            int choice = int.Parse(Console.ReadLine()) - 1;
            myFreinds.Add(user_accountslist[choice]);
            Console.WriteLine($"{user_accountslist[choice].Name} added as friend!");
            break;

           
            case "3":
            Console.WriteLine("Choose a friend to remove:");
            for (int i = 0; i < myFreinds.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {myFreinds[i].Name}");
            }
            int removeChoice = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"{myFreinds[removeChoice].Name} removed from friends!");
            myFreinds.RemoveAt(removeChoice);
            
            break;

          

             case "4":
            Console.WriteLine("My friends:");
            foreach (user_account friend in myFreinds)
            {
                Console.WriteLine($"- {friend.Name}");
            }
            break;

            case "5":
            Console.WriteLine("Choose a friend to view profile:");
            for (int i = 0; i < myFreinds.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {myFreinds[i].Name}");
            }
            int profileChoice = int.Parse(Console.ReadLine()) - 1;
            user_account selectedFriend = myFreinds[profileChoice];
            Console.WriteLine($"Name: {selectedFriend.Name}");
            Console.WriteLine($"Age: {selectedFriend.Age}");
            Console.WriteLine($"Job: {selectedFriend.Job}");
            Console.WriteLine($"Hobby: {selectedFriend.Hobby}");
         
            break;

                case "6":
            kjører = false;
            break;

    }
}

