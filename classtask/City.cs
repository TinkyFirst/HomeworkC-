using System;

namespace classtask
{
    public class City
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public Role Role { get; set; }
    }
}