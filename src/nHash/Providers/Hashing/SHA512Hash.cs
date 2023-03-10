using System.Security.Cryptography;

namespace nHash.Providers.Hashing;

public class SHA512Hash : IHash
{
    private readonly SHA512 _provider = SHA512.Create();

    public byte[] ComputeHash(byte[] buffer)
    {
        return _provider.ComputeHash(buffer);
    }
}