using System;

namespace Bloc_5___Pràctica_Troncal_A3_dbContext_v2
{
    public class User : Entity
    {
        public string Name { get => name; set => name = value; }
        private string name;

        public string Mail{ get => mail; set => mail = value; } //puede no tener mail
        private string mail;
        //Constructors
        public User()
        {
           
        }
        public User(string name, string mail)
        {
            
            this.name = name;
            this.mail = mail;
        }
    }
}

