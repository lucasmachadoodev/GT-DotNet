using System.Collections.Generic;

namespace GT_Visiontec.Models
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<GroupUser> GroupUsers { get; set; }
    }
}