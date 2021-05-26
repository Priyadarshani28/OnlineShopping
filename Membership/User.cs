using System;

namespace Membership
{
    public class User
    {
       public int Id{get; set;}
       public string LoginName{get; set;}
       public string Password{get; set;}
       public static User Register()
       {
           User newUser=new User();
           newUser.LoginName="Priya";
           newUser.Password="priya123";
           return newUser;
       } 
         
    }
}
