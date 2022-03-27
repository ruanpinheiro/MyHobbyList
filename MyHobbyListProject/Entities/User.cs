using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHobbyListProject.Enums;

namespace MyHobbyListProject.Entities
{
    public class User
    {
        public int Id { get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Anime> Animes { get; set; } = new List<Anime>();
        public ICollection<Serie> Series { get; set; } = new List<Serie>();
        public ICollection<Film> Films { get; set; } = new List<Film>();

        
        public User(string firstName, string lastName, DateTime birthDay,string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Email = email;           
            Password = password;
        }

        public User()
        {
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void RegisterNewUser(string firstName, string lastName, DateTime birthday ,string email, string password)
        {                           
            var context = new UserContext();
            var novoUsuario = new User(firstName, lastName,birthday, email,  password);
            context.Users.Add(novoUsuario);
            context.SaveChanges();
        }

        /*public ICollection<Anime> GetAnimes(string email)
        {
            var context = new UserContext();

            return (ICollection<Anime>)context.Users.Where(u => u.Email == email).Select(a => a.Animes.ToList());// não sei se vai funcionar

        }*/
        
        public void AddNewAnime(string email, string animeName, int qtdEpisodes, EnumStatus enumStatus, EnumScore enumScore, EnumClassificationAnimes enumClassificationAnime, string resume)
        {
            var context = new UserContext();

            foreach(var user in context.Users)
            {
                if(user.Email == email)
                {
                    Animes.Add(new Anime(animeName, qtdEpisodes ,resume, enumStatus, enumScore, enumClassificationAnime));
                }
            }

            
        }
        

        
        
    }
}
