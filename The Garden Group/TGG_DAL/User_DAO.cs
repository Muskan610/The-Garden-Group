using System;
using TGG_Model;
using NoDesk;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System.Linq;

namespace TGG_DAL
{
    public class User_DAO
    {
        //Connection file that makes a connection when created
        public Config config = new Config();
        //if check existence is true then call get user by name

        public User verifyUserCredentials(string username, string password)
        {
            try
            {
                
                var database = config.dbClient.GetDatabase("NoDesk");
                var collection = database.GetCollection<User>("Users");
                var filter = Builders<User>.Filter.Eq("Email", username);
                
                var user = collection.Find(filter).FirstOrDefault<User>();
                if (user == null)
                {
                    return null;
                }
                else if ((username == user.Email)&&(password==user.Password))
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error : " + e);//added exception code
            }
        }


    }
}



