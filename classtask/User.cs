using System;

namespace classtask
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public uint Age { get; set; }
        public Sex Sex { get; set; }
    }
}