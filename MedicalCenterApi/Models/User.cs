﻿namespace MedicalCenterApi.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string? SSN { get; set; }

    }
}
