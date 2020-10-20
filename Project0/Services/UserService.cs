// using System.Collections.Generic;
// using System.Threading.Tasks;
// using MongoDB.Driver;
// using Project0.Interfaces;
// using Project0.Models;
//
// namespace Project0.Services
// {
//     public class UserService : IUserService
//     {
//         private readonly IMongoCollection<User> _users;
//
//         public UserService(IDatabaseSettings settings)
//         {
//             // var config2 = Configuration.GetSection("DatabaseSettings").GetSection("ConnectionString").Value;
//
//             var client = new MongoClient();
//             var database = client.GetDatabase(settings.DatabaseName);
//
//             _users = database.GetCollection<User>(settings.UsersCollectionName);
//         }
//
//         // Get all users
//         public List<User> Get() =>
//             _users.Find(user => true).ToList();
//
//         // Get User by Id 
//         public async Task<User> Get(string id) =>
//             await _users.Find<User>(u => u.Id == id).FirstOrDefaultAsync();
//
//         // Create a user 
//         public User Create(User user)
//         {
//             _users.InsertOne(user);
//             return user;
//         }
//
//         public void Update(string id, User userIn) =>
//             _users.ReplaceOne(u => u.Id == id, userIn);
//
//         public void Remove(string id) =>
//             _users.DeleteOne(u => u.Id == id);
//     }
// }