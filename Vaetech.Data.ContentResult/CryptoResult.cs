namespace Vaetech.Data.ContentResult
{
    public class EncryptResult : TupleResult
    {
        public string Encrypted { get; set; }
        public byte[] EncryptedInBytes { get; set; }

        public EncryptResult() { }
        public EncryptResult(string encrypted, byte[] encryptedInBytes, bool ibExeption = false, string message = null): base(ibExeption, message)
        {
            Encrypted = encrypted;
            EncryptedInBytes = encryptedInBytes;
        }
        public EncryptResult(string encrypted, bool ibExeption, string message) : base(ibExeption, message) => Encrypted = encrypted;
        public EncryptResult(byte[] encrypted, bool ibExeption, string message) : base(ibExeption, message) => EncryptedInBytes = encrypted;        
    }
    public class DecryptResult : TupleResult
    {
        public string Decoded { get; set; }
        public byte[] DecodedInBytes { get; set; }

        public DecryptResult() { }
        public DecryptResult(string decoded, byte[] decodedInBytes, bool ibExeption = false, string message = null) : base(ibExeption, message)
        {
            Decoded = decoded;
            DecodedInBytes = decodedInBytes;
        }
        public DecryptResult(string decoded, bool ibExeption, string message) : base(ibExeption, message) => Decoded = decoded;
        public DecryptResult(byte[] decoded, bool ibExeption, string message) : base(ibExeption, message) => DecodedInBytes = decoded;
    }
}
