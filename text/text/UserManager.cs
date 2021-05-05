using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace text
{
    class UserManager
    {
        static public List<User> users = new List<User>();
        static public string curUsername;
        static public string curUsertype;
        static public void Load()
        {
            users.Clear();
            if (File.Exists("login.txt"))
            {
                StreamReader sr = new StreamReader("login.txt");
                string line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] values = line.Split(',');
                        User user = new User(values[0], values[1], values[2], values[3], values[4], values[5]);
                        users.Add(user);

                    }

                }

                sr.Close();
            }
        }

        static public void save()
        {
            StreamWriter sw = new StreamWriter("login.txt");
            for(int i = 0; i < users.Count; i++)
            {
                sw.WriteLine("{0},{1},{2},{3},{4},{5}", users[i].getUsername(), users[i].getPassword(),
                    users[i].getUsertype(), users[i].getFirstname(), users[i].getLastname(),
                    users[i].getDateOfBirth());
            }
        }

        static public bool IsValidUser(string user, string psw)
        {
            foreach(var item in users)
            {
                if(item.getUsername() == user && item.getPassword() == psw)
                {
                    curUsername = item.getUsername();
                    curUsertype = item.getUsertype();
                    return true;
                }
            } 
            return false;
        }
    }
}
