namespace AspNetApiTemplate.Security;

public interface ITokenHasher
{
    string Hash(string rawToken);
    bool Verify(string rawToken, string hashedTokwn);
}
