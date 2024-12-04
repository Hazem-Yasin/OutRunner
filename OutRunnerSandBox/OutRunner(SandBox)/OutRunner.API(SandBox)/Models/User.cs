using System;
using System.Collections.Generic;

namespace OutRunner.API_SandBox_.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string ProfilePictureURL { get; set; }
        public DateTime JoinDate { get; set; }

    }
}
