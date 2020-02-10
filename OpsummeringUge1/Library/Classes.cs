using System;
using System.Collections.Generic;

namespace Library
{
    public class Registry
    {
        List<User> User = new List<User>();
        List<Admin> Admin = new List<Admin>();
        
            
        public void AddNewUser(User user)
        {   
            this.User.Add(user);     
        }
        public bool Login(string login, string password)
        {
            int x = 0;
            for (int i = 0; i < this.User.Count; i++)
            {
                if (this.User[i].ToString().Contains(login) && this.User[i].ToString().Contains(password))
                {
                    x = 1;
                }
            }
            if (x == 1)
            {
                return true;
            }
            for (int i = 0; i < this.Admin.Count; i++)
            {
                if (this.Admin[i].ToString().Contains(login) && this.Admin[i].ToString().Contains(password))
                {
                    x = 1;
                }
            }
            if (x == 1)
            {
                return true;
            }
            else { return false; }
        }

    }

    public class User
    {
        string login;
        string password;
        
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
            
        }
    
        Job job { get; set; }
        public bool IsAdmin()
        {
            return true;
        }
    }
    public class Admin : User
    {
        public Admin(string login, string password) : base(login, password)
        {
        }

        public void ChangePassword(User user, string newpassword)
        {
        }
    }
    public abstract class Job
    {
        public abstract int GetMonthlyPay();
    }
    public class HourlyPaidJob : Job
    {
        public override int GetMonthlyPay()
        {
            throw new NotImplementedException();
        }
        private int HourlyPay;
    }
    public class DailyPaidJob : Job
    {
        public override int GetMonthlyPay()
        {
            throw new NotImplementedException();
        }
        private int DailyPay;
    }
}
