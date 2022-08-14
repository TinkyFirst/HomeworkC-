using System;
using System.Collections.Generic;
using System.Linq;


namespace classtask
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User()
            {
                Name = "Vlad",
                Age = 20,
                Sex = Sex.Man,
                City = new City
                {
                    Name = "Chernivtsi",
                },
                UserName = "vetrov",
                Role = Role.Admin,
                Password = 12345,
            };
            var user2 = new User()
            {
                Name = "Andrii",
                Age = 20,
                Sex = Sex.Man,
                City = new City
                {
                    Name = "Chernivtsi",
                },
                UserName = "andriirsee",
                Role = Role.User,
                Password = 54321,
            };

            var users = new List<User>() { user1, user2 };
            var womanList = GetBySex(users, Sex.Woman);
            var mansList = GetBySex(users, Sex.Man);
            var moreThan21 = GetByAge(users, 21);
            var sortedUsers = SortByAge(users);
            var selectedCity = selectByCity(users, "Chernivtsi");
            Console.WriteLine("You are registered?");

            Console.WriteLine("Write 1 in console if you not registed");
            Console.WriteLine("Write 2 in console if you already registed");
            int selectedChoice = int.Parse(Console.ReadLine());
            SelectLoginMethod(users, selectedChoice);
        }

        public static void PrintUsers(List<User> listUsers)
        {
            foreach (var user in listUsers)
            {
                Console.WriteLine(user.Name);
                Console.WriteLine(user.Id);
                Console.WriteLine(user.Age);
                Console.WriteLine(user.Sex);
            }
        }

        /*public static List<User> GetMans(List<User> users)
        {
            var mansList = new List<User>();
            foreach (var user in users)
            {
                if (user.Sex == Sex.Man)
                {
                    mansList.Add(user);
                }
            }

            return mansList;
        }

        public static List<User> GetWoman(List<User> users)
        {
            var womanList = new List<User>();
            foreach (var user in users)
            {
                if (user.Sex == Sex.Woman)
                {
                    womanList.Add(user);
                }
            }

            return womanList;
        }*/

        public static List<User> GetBySex(List<User> users, Sex sex)
        {
            var separatedUsers = new List<User>();
            foreach (var user in users)
            {
                if (user.Sex == sex)
                {
                    separatedUsers.Add(user);
                }
            }

            return separatedUsers;
        }

        public static List<User> GetByAge(List<User> users, uint age)
        {
            var ageList = new List<User>();
            foreach (var user in users)
            {
                if (user.Age >= age)
                {
                    ageList.Add(user);
                }
            }

            return ageList;
        }

        public static List<User> SortByAge(List<User> users)
        {
            var sortedUsers = users
                .OrderBy(x => x.Age)
                .ToList();

            return sortedUsers;
        }

        public static List<User> selectByCity(List<User> users, string city)
        {
            var selectedCity = new List<User>();
            foreach (var user in users)
            {
                if (user.City.Name == city)
                {
                    selectedCity.Add(user);
                }
            }

            return selectedCity;
        }

        public static void SelectLoginMethod(List<User> users, int choice)
        {
            User user = null;
            switch (choice)
            {
                case 1:
                    user = Register(users);
                    break;
                case 2:
                    user = Login(users);
                    break;
            }

            if (user == null)
            {
                SelectLoginMethod(users, choice);
            }
            else
            {
                switch (user.Role)
                {
                    case Role.User:
                        PrintUser(user, Role.User, users);
                        break;
                    case Role.Admin:
                        PrintUser(user, Role.Admin, users);
                        AdminPanel(users);
                        break;
                }
            }
        }

        public static User Register(List<User> users)
        {
            Console.WriteLine("Write your name");
            var newName = Console.ReadLine();

            Console.WriteLine("Write your age");
            var newAge = uint.Parse(Console.ReadLine());

            Console.WriteLine("Write your sex");
            Console.WriteLine("Write 1 if you Man");
            Console.WriteLine("Write 2 if you Women");
            var newSex = int.Parse(Console.ReadLine());

            Console.WriteLine("Write your city");
            var newCity = Console.ReadLine();

            Console.WriteLine("Write your login");
            var newLogin = Console.ReadLine();

            Console.WriteLine("Write your password");
            var newPassword = int.Parse(Console.ReadLine());

            Sex selectedSex;
            if (newSex == 1)
            {
                selectedSex = Sex.Man;
            }
            else
            {
                selectedSex = Sex.Woman;
            }

            var newUser = new User
            {
                Name = newName,
                Age = newAge,
                Sex = selectedSex,
                City = new City
                {
                    Name = newCity
                },
                UserName = newLogin,
                Password = newPassword,
                Role = Role.User,
            };
            users.Add(newUser);
            return newUser;
        }

        public static User Login(List<User> users)
        {
            Console.WriteLine("Write your login");
            var login = Console.ReadLine();

            Console.WriteLine("Write your password");
            var password = int.Parse(Console.ReadLine());
            foreach (var user in users)
            {
                if (login == user.UserName && password == user.Password)
                {
                    return user;
                }
            }

            return null;
        }


        public static void PrintUser(User user, Role role, List<User> users)
        {
            Console.WriteLine($"Your name {user.Name}");
            Console.WriteLine($"Your nickname {user.UserName}");
            Console.WriteLine($"Your age {user.Age}");
            Console.WriteLine($"Your role {user.Role}");
            Console.WriteLine($"Your sex {user.Sex}");
            Console.WriteLine($"Your city {user.City.Name}");

            if (role == Role.Admin)
            {
                Console.WriteLine($"Your id {user.Id}");
            }
        }

        public static void PrintAdmin(User user, List<User> users)
        {
            PrintUser(user, Role.Admin, users);
        }

        public static void PrintUserList(List<User> users)
        {
            Console.WriteLine("List registered users");
            var nmb = 0;
            foreach (var user in users)
            {
                Console.WriteLine(user.Name + " #" + nmb +"\t id  "+ user.Id);
                nmb++;
            }
        }

        public static void AdminPanel(List<User> users)
        {
            Console.WriteLine("You want manage users?");
            Console.WriteLine("Write 1 for delete user");
            Console.WriteLine("Write 2 for add user");

            var choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintUserList(users);
                    DeleteUser(1, users);
                    PrintUserList(users);
                    break;
                case 2:
                    Register(users);
                    PrintUserList(users);
                    break;
            }
        }

        public static List<User> DeleteUser(int choice, List<User> users)
        {
            
            switch (choice)
            {
                case 1:
                    choice = int.Parse(Console.ReadLine());
                    users.Remove(users[choice]);
                    return users;
            }
            return users;
        }
        
    }
}