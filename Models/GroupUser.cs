﻿using System.Collections.Generic;

namespace GT_Visiontec.Models
{
    public class GroupUser
    {
        public int GroupId { get; set; }

        public int UserId { get; set; }


        public Group Group { get; set; }

        public User User { get; set; }
    }
}