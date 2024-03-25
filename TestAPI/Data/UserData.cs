namespace TestAPI.Data
{
    public class UserData
    {
        public IList<User> Users { get; set; }
        public UserData() 
        {
            Users = new List<User> 
            {
                new User
                {
                    Id = "1",
                    Name = "Test1",
                    Email = "test1@test.com",
                    Age = 20,
                    Address = "abc"
                },
                new User
                {
                    Id = "2",
                    Name = "Test2",
                    Email = "test2@test.com",
                    Age = 22,
                    Address = "xyz"
                },
                new User
                {
                    Id = "3",
                    Name = "Test3",
                    Email = "test3@test.com",
                    Age = 23,
                    Address = "lmn"
                },
            };
        }
    }
}
