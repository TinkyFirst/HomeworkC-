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
                    Square = 50000
                }
                
            };
            var user2 = new User()
            {
                Name = "Andrii",
                Age = 21,
                Sex = Sex.Man,
                City = new City
                {
                Name = "Chernivtsi",
                Square = 50000
            }
                
            };
            var user3 = new User()
            {
                Name = "Julia",
                Age = 20,
                Sex = Sex.Woman,
                City = new City
                {
                    Name = "Suchava",
                    Square = 70000
                }
            };
            var users = new List<User>() { user1, user2, user3 };
            var womanList = GetBySex(users, Sex.Woman);
            var mansList = GetBySex(users, Sex.Man);
            var moreThan21 = GetByAge(users, 21);
            var sortedUsers = SortByAge(users);
            var selectedCity = selectByCity(users,"Chernivtsi");
            PrintUsers(users);
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
    }
}