using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaBD.Services
{
    internal class UserServices
    {
        public void AddUser(string username, string login, string password)
        {
            if (IsLogin(login) == true) throw new Exception("Такой пользователь уже есть");
            if (string.IsNullOrEmpty(username)) throw new Exception("Поле имя пустое");
            if (string.IsNullOrEmpty(password)) throw new Exception("Поле пороль пустое ");
            
            var  usersNew = new BD.User();
            usersNew.Name= username.Trim(); 
            usersNew.Login = login.Trim();
            usersNew.Password = password.Trim();    
            
            using BD.MS_SQL_Context _Context = new BD.MS_SQL_Context(); 
        
          try
          {
                _Context.Users.Add(usersNew);
                _Context.SaveChanges();            
          }
        catch(Exception ex)
            {
                throw new Exception(ex.Message);    
            }           
        }

        private bool IsLogin(object login)
        {
            using BD.MS_SQL_Context _Context = new BD.MS_SQL_Context();

            try
            {
                bool res = _Context.Users.Any(x => x.Login == login);
                return res;
            }
        
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal string Auth (string login , string password)
        {
            if (IsLogin(login) == false) throw new Exception("пользователь не найден");
            using BD.MS_SQL_Context _Context = new BD.MS_SQL_Context();            
        
            try
            {
                return _Context.Users.Single(x => x.Login == login && x.Password == password).Name;
            }
            catch(Exception)
            {
                throw new Exception("не верный логин или пороль");       
            }             
        }          
    }
}
