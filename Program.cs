using System;
using System.Collections.Generic;
using System.Linq;

namespace dz_linq_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> listUser = new List<User>();
            listUser.Add(new User ( "paword1", "login1", 17, new DateTime(2021,10,1)));
            listUser.Add(new User ( "paword2", "login2", 18, new DateTime(2021,10,2)));
            listUser.Add(new User ( "paword3", "login3", 19, new DateTime(2021,10,3)));
            listUser.Add(new User ( "paword4", "login4", 20, new DateTime(2021,10,4)));
            listUser.Add(new User ( "paword5", "login5", 21, new DateTime(2021,10,5)));
            listUser.Add(new User ( "paword1", "login1", 17, new DateTime(2021,10,1)));
            listUser.Add(new User ( "paword2", "login2", 18, new DateTime(2021,10,2)));
            listUser.Add(new User ( "paword3", "login3", 19, new DateTime(2021,10,3)));
            listUser.Add(new User ( "paword4", "login4", 20, new DateTime(2021,10,4)));
            listUser.Add(new User ( "paword5", "login5", 21, new DateTime(2021,10,5)));
            listUser.Add(new User ( "paword1", "login1", 17, new DateTime(2021,10,1)));
            listUser.Add(new User ( "paword2", "login2", 18, new DateTime(2021,10,2)));
            listUser.Add(new User ( "paword3", "login3", 19, new DateTime(2021,10,3)));
            listUser.Add(new User ( "paword4", "login4", 20, new DateTime(2021,10,4)));
            listUser.Add(new User ( "paword5", "login5", 21, new DateTime(2021,10,5)));
            listUser.Add(new User ( "paword1", "login1", 17, new DateTime(2021,10,1)));
            listUser.Add(new User ( "paword2", "login2", 18, new DateTime(2021,10,2)));
            listUser.Add(new User ( "paword3", "login3", 19, new DateTime(2021,10,3)));
            listUser.Add(new User ( "paword4", "login4", 20, new DateTime(2021,10,4)));
            listUser.Add(new User ( "paword5", "login5", 21, new DateTime(2021,10,5)));
            listUser.Add(new User ( "paword1", "login1", 17, new DateTime(2021,10,1)));
            listUser.Add(new User ( "paword2", "login2", 18, new DateTime(2021,10,2)));
            listUser.Add(new User ( "paword3", "login3", 19, new DateTime(2021,10,3)));
            listUser.Add(new User ( "paword4", "login4", 20, new DateTime(2021,10,4)));
            listUser.Add(new User ( "paword5", "login5", 21, new DateTime(2021,10,5)));
            listUser.Add(new User ( "paword1", "login1", 17, new DateTime(2021,10,1)));
            listUser.Add(new User ( "paword2", "login2", 18, new DateTime(2021,10,2)));
            listUser.Add(new User ( "paword3", "login3", 19, new DateTime(2021,10,3)));
            listUser.Add(new User ( "paword4", "login4", 20, new DateTime(2021,10,4)));
            listUser.Add(new User ( "paword5", "login5", 21, new DateTime(2021,10,5)));

           // listUser.ForEach(Console.WriteLine);
            
            //Реализовать метод который уберет все повторения логина и / или пароля
            // var res = listUser.Distinct(new UserEqualityComparer_All());
             /*foreach(var item in listUser.Distinct(new UserEqualityComparer_All())){
                 Console.WriteLine(item);
                 Console.WriteLine("\n");
             }*/

             
             /*var res = listUser.Distinct(new UserEqualityComparer_Age());
             foreach(var item in res){
                 Console.WriteLine(item);
                 Console.WriteLine("\n");
                }
                */
            //Вывода минимального пользователя (по возрасту)
            /*int minAge = listUser.Min<User>(x => x.Age);
            foreach(var item in listUser){
                if(item.Age == minAge){
                    Console.WriteLine($"min Age  \n{item}");
                    }
                }
                 Console.WriteLine("\n");*/
                
                

           //  Количества пользователей, кто зарегистрировался в определенную дату 
           DateTime faindRegData = new DateTime(2021,10,5);
           int i = 0; 
           foreach(var item in listUser){
                if(item.RegistrDate == faindRegData){
                    Console.WriteLine($"faindRegDat: {faindRegData}  \n{item}");
                    i++;
                    }
                }
                Console.WriteLine($"registered users date {faindRegData} :  {i}");

           
           




             Console.ReadKey();

        }
    }
}
