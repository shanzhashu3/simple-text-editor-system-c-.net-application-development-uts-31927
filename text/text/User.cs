using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace text
{
    class User
    {

        string username;
        string password;
        string usertype;
        string firstname;
        string lastname;
        string dateOfBirth;

        public User(string username, string password, string usertype, string firstname, string lastname, string dateOfBirth)
        {
            this.username = username;
            this.password = password;
            this.usertype = usertype;
            this.firstname = firstname;
            this.lastname = lastname;
            this.dateOfBirth = dateOfBirth;
        }

        public string getUsername()
        {
            return this.username;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getUsertype()
        {
            return this.usertype;
        }
        public void setType(string usertype)
        {
            this.usertype = usertype;
        }

        public string getFirstname()
        {
            return this.firstname;
        }

        public void setFirstname(string firstname)
        {
           this.firstname = firstname;
        }

        public string getLastname()
        {
            return this.lastname;
        }

        public void setLastname(string lastname)
        {
            this.lastname = lastname;
        }

        public string getDateOfBirth()
        {
            return this.dateOfBirth;
        }

        public void setDateOfBirth(string dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

    }
}
