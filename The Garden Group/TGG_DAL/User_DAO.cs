using System;
using TGG_Model;

namespace TGG_DAL
{
    public class User_DAO
    {
        //if check existence is true then call get user by name
        public User GetUserByUserName(string username) //if the user is verified, get userinfo from DB by the username
        {
            // OpenConnection();
            //get user deatils
            string userStatus = "user";//test
            User oneUser = new User()
            {
                Username = username,
                role = userStatus
            };

            // CloseConnection();
            return oneUser;
        }


        public bool verifyUserCredentials(string username, string password)
        {
            try
            {
                if (verifyUsername(username) == true && verifyUserPassword(username, password) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error : " + e);//added exception code
            }
        }

        private bool verifyUsername(string username)
        {
            try
            {
                //query the db for a user with this username, 
                //if the query results a user, return true
                //else return false
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error : " + e);//added exception code
            }
        }

        private bool verifyUserPassword(string username, string password)
        {
            try
            {
                //query the db for the password of this user, 
                //if the paswd in the args match with this one, return true
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error : " + e);//added exception code
            }
        }


    }
}



