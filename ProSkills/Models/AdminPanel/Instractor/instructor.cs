﻿namespace ProSkills.Models.AdminPanel.Instractor
{
    public class instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Bio { get; set; }
        public string CreatedAt { get; set;}
        public bool IsDeleted { get; set;}

    }
}
