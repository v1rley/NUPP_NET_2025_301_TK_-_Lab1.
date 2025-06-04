using System;

namespace Zoo.Common
{
    public class Zookeeper
    {
        public Zookeeper(string fullName, int experienceYears)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            ExperienceYears = experienceYears;
        }

        public Guid Id { get; set; }
        public string FullName { get; set; }
        public int ExperienceYears { get; set; }
    }
}
