using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class AuthenticateResponse : User
    {
        public string token { get; set; }

        public AuthenticateResponse(User user, string token)
        {
            this.FirstName = user.FirstName;
            this.MiddleName = user.MiddleName;
            this.LastName = user.LastName;
            this.ID = user.ID;
            this.token = token;

        }

    }
}
