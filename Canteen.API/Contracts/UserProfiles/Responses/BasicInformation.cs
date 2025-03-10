﻿namespace Canteen.API.Contracts.UserProfiles.Responses
{
    public record BasicInformation
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string CurrentCity { get; set; }
    }
}
