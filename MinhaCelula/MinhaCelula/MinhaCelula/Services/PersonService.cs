using MinhaCelula.Commons;
using MinhaCelula.Models;
using MinhaCelula.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MinhaCelula.Services
{
    public class PersonService
    {
        private static Person loggedUser { get; set; }

        public static Person GetLoggedUser()
        {
            return loggedUser;
        }

        private static void SetLoggedUser(Person user)
        {
            loggedUser = user;
        }

        public static Person GetUserByEmailAndPassword(string email, string password)
        {
            Person user = new Person();

            if (email.Equals("admin"))
            {
                user.Name = "Admin";
                user.Profile = PersonProfile.Admin;
            }
            else if (email.Equals("lider"))
            {
                user.Name = "Lider";
                user.Profile = PersonProfile.Leader;
            }
            else if (email.Equals("coordenador"))
            {
                user.Name = "Coordenador";
                user.Profile = PersonProfile.Coordinator;
            }
            else if (email.Equals("pastor"))
            {
                user.Name = "Pastor";
                user.Profile = PersonProfile.Pastor;
            }

            SetLoggedUser(user);

            return user;
        }

        private static ObservableCollection<Person> personList { get; set; } 

        public static ObservableCollection<Person> GetPersons()
        {
            personList = new ObservableCollection<Person>();

            var admin = new Person() { Name = "Person 0",  Profile = PersonProfile.Admin };

            var pastor1 = new Person() { Name = "Pastor 1", Profile = PersonProfile.Pastor };
            var pastor2 = new Person() { Name = "Pastor 2", Profile = PersonProfile.Pastor };

            var coordinator1 = new Person() { Name = "Coordinator 1", Profile = PersonProfile.Coordinator, CelulaId = 1 };
            var coordinator2 = new Person() { Name = "Coordinator 2", Profile = PersonProfile.Coordinator, CelulaId = 2 };

            var leader1 = new Person() { Name = "Leader 1", Profile = PersonProfile.Leader, CelulaId = 1 };
            var leader2 = new Person() { Name = "Leader 2", Profile = PersonProfile.Leader, CelulaId = 2 };

            var member1 = new Person() { Name = "Member 1", Profile = PersonProfile.Member, CelulaId = 1 };
            var member2 = new Person() { Name = "Member 2", Profile = PersonProfile.Member, CelulaId = 1 };
            var member3 = new Person() { Name = "Member 3", Profile = PersonProfile.Member, CelulaId = 1 };
            var member4 = new Person() { Name = "Member 4", Profile = PersonProfile.Member, CelulaId = 2 };
            var member5 = new Person() { Name = "Member 5", Profile = PersonProfile.Member, CelulaId = 2 };
            var member6 = new Person() { Name = "Member 6", Profile = PersonProfile.Member, CelulaId = 2 };

            var visitant1 = new Person() { Name = "Visitant 1", Profile = PersonProfile.Visitant, CelulaId = 2 };
            var visitant2 = new Person() { Name = "Visitant 2", Profile = PersonProfile.Visitant, CelulaId = 2 };

            personList.Add(admin);
            personList.Add(pastor1);
            personList.Add(pastor2);
            personList.Add(coordinator1);
            personList.Add(coordinator2);
            personList.Add(leader1);
            personList.Add(leader2);
            personList.Add(member1);
            personList.Add(member2);
            personList.Add(member3);
            personList.Add(member4);
            personList.Add(member5);
            personList.Add(member6);
            personList.Add(visitant1);
            personList.Add(visitant2);

            return personList;
        }
    }
}
