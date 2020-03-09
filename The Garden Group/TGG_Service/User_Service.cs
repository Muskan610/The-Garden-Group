using System;
using TGG_DAL;
using TGG_Model;

namespace TGG_Service
{
    public class User_Service
    {
        User_DAO User_DAO = new User_DAO();

        public bool verifyUserCredentials(string username, string password)
        {
            try
            {
                return User_DAO.verifyUserCredentials(username, password);
            }
            catch (Exception e)
            {
                throw new Exception(" " + e.Message);
            }
        }

        public User GetUserByUserName(string username)
        {
            try
            {
                User user = User_DAO.GetUserByUserName(username);
                return user;
            }
            catch (Exception e)
            {
                throw new Exception(" " + e.Message);
            }

        }

    }
}
