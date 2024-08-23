using System.Diagnostics.Contracts;

namespace GenericAttributes;

[Validator<UserValidator>]
public class User
{
}
