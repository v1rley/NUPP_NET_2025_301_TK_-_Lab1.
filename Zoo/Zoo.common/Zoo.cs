using System;

namespace Zoo.Common
{
    public class Zoo
    {
        public Zoo(string name, string location)
        {
            Id = Guid.NewGuid();
            Name = name;
            Location = location;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
