﻿namespace SportsSubscriptionAPI.Data
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public virtual IList<User> Users { get; set; }
    }
}