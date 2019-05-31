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
                user.Name = "Luiz Lider";
                user.Profile = PersonProfile.Leader;
            }
            else if (email.Equals("coordenador"))
            {
                user.Name = "Luiz Coordenador";
                user.Profile = PersonProfile.Coordinator;
            }
            else if (email.Equals("pastor"))
            {
                user.Name = "Luiz Pastor";
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
        
        private static ObservableCollection<Person> pastoresList { get; set; }

        public static ObservableCollection<Person> GetPastores()
        {
            pastoresList = new ObservableCollection<Person>();

            var pastor1 = new Person() { Name = "Pastor 1", Profile = PersonProfile.Pastor };
            var pastor2 = new Person() { Name = "Pastor 2", Profile = PersonProfile.Pastor };

            pastoresList.Add(pastor1);
            pastoresList.Add(pastor2);

            return pastoresList;
        }

        private static ObservableCollection<Person> coordenadoresList { get; set; }

        public static ObservableCollection<Person> GetCoordenadores()
        {
            coordenadoresList = new ObservableCollection<Person>();

            var coordinator1 = new Person() { Name = "Coordinator 1", Profile = PersonProfile.Coordinator, CelulaId = 1 };
            var coordinator2 = new Person() { Name = "Coordinator 2", Profile = PersonProfile.Coordinator, CelulaId = 2 };

            coordenadoresList.Add(coordinator1);
            coordenadoresList.Add(coordinator2);
            
            return coordenadoresList;
        }

        private static ObservableCollection<Person> lideresList { get; set; }

        public static ObservableCollection<Person> GetLideres()
        {
            lideresList = new ObservableCollection<Person>();

            var leader1 = new Person() { Name = "Leader 1", Profile = PersonProfile.Leader, CelulaId = 1 };
            var leader2 = new Person() { Name = "Leader 2", Profile = PersonProfile.Leader, CelulaId = 2 };

            lideresList.Add(leader1);
            lideresList.Add(leader2);
            
            return lideresList;
        }

        private static ObservableCollection<Person> membrosList { get; set; }

        public static ObservableCollection<Person> GetMembros()
        {
            membrosList = new ObservableCollection<Person>();

            var member1 = new Person() { Name = "Member 1", Profile = PersonProfile.Member, CelulaId = 1 };
            var member2 = new Person() { Name = "Member 2", Profile = PersonProfile.Member, CelulaId = 1 };
            var member3 = new Person() { Name = "Member 3", Profile = PersonProfile.Member, CelulaId = 1 };
            var member4 = new Person() { Name = "Member 4", Profile = PersonProfile.Member, CelulaId = 2 };
            var member5 = new Person() { Name = "Member 5", Profile = PersonProfile.Member, CelulaId = 2 };
            var member6 = new Person() { Name = "Member 6", Profile = PersonProfile.Member, CelulaId = 2 };

            membrosList.Add(member1);
            membrosList.Add(member2);
            membrosList.Add(member3);
            membrosList.Add(member4);
            membrosList.Add(member5);
            membrosList.Add(member6);
            
            return membrosList;
        }

        private static ObservableCollection<Person> visitantesList { get; set; }

        public static ObservableCollection<Person> GetVisitantes()
        {
            visitantesList = new ObservableCollection<Person>();

            var visitant1 = new Person() { Name = "Visitant 1", Profile = PersonProfile.Visitant, CelulaId = 2 };
            var visitant2 = new Person() { Name = "Visitant 2", Profile = PersonProfile.Visitant, CelulaId = 2 };

            visitantesList.Add(visitant1);
            visitantesList.Add(visitant2);

            return visitantesList;
        }
    }
}
