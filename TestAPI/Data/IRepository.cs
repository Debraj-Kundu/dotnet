namespace TestAPI.Data
{
    public interface IRepository
    {
        IEnumerable<User> AllUsers();
        User? GetById(string id);
        bool CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(string id);

    }
}
