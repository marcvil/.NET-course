using System;

namespace Bloc_5___Pràctica_Troncal_A3_dbContext_v2
{
    public class User : Entity
    {
        public string Name { get; set; }

        public string Mail { get; set; } //can be null, Ex. Administrator user
       
        //Constructors

        public User()
        {
           
        }
        public User(string name, string mail)
        {
            
            this.Name = name;
            this.Mail = mail;
        }
    }
}

