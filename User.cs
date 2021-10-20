using System;
namespace dz_linq_
{
    public class User
    {
        public string Pasword { get; set; }     
        public string  Login { get; set; }
        public int Age { get; set; }
        public DateTime  RegistrDate { get; set; }
        public User (string pasword, string login, int age, DateTime regisrtD){
            Pasword = pasword;
            Login = login;
            Age = age;
            RegistrDate = regisrtD;
        }
        public override string ToString()
        {
            return $"Pasword - {Pasword ?? "is no data "} \nLogin - {Login ?? "is no data "} \nAge - {Age} \nDate registr - {RegistrDate}";
        }



    }

}
