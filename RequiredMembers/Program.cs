var user = new User
{
    //FullName = "Test",
};

//user.FullName = "not"; // compile error cause cannot change it

class User
{
    public required string FullName { get; init; }

}