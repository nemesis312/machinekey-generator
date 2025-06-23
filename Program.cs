
using System.Security.Cryptography;

Console.WriteLine("<machineKey");
Console.WriteLine($"  validationKey=\"{GenerateKey(128)}\"");
Console.WriteLine($"  decryptionKey=\"{GenerateKey(64)}\"");
Console.WriteLine("  validation=\"SHA1\"");
Console.WriteLine("  decryption=\"AES\" />");

static string GenerateKey(int length) {
    byte[] buffer = new byte[length / 2];
    using (var rng = RandomNumberGenerator.Create()) {
        rng.GetBytes(buffer);
    }
    return BitConverter.ToString(buffer).Replace("-", "");
}