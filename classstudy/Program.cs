using System;

namespace classstudy
{
    class User
    {
        public int userID;
        public string userName;
        public int userOld;
        public void Print()
        {
            Console.WriteLine($"Имя: {userName}  Возраст: {userOld}");
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            User userFirst = new User();
            userFirst.userName = "Andrii";
            userFirst.userID = 12412;
            userFirst.userOld = 21;
            
        }
    }
  

    
}