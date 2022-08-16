using System;

namespace classtask
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public uint Age { get; set; }
        public Sex Sex { get; set; }
        public City City {get; set; }
    }
}