namespace TestAPI.Data
{
    public class Repository : IRepository
    {
        public IList<User> Users { get; set; }
        public Repository(UserData userData)
        {

            Users = userData.Users;

        }
        public IEnumerable<User> AllUsers()
        {
            return Users;
        }

        public bool CreateUser(User user)
        {
            Users.Add(user);
            return true;
        }

        public bool DeleteUser(string id)
        {
            User? userToDelete = GetById(id);
            if(userToDelete == null)
                return false;
            int index = Users.IndexOf(userToDelete);
            Users.RemoveAt(index);
            return true;
        }

        public User? GetById(string id)
        {
            return Users.Where(u => u.Id == id).FirstOrDefault();
        }

        public bool UpdateUser(User user)
        {
            User? userToUpdate = GetById(user.Id);
            if (userToUpdate == null)
                return false;
            int index = Users.IndexOf(userToUpdate);
            Users[index] = user;
            return true;
        }
    }
}
