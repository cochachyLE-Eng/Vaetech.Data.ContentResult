namespace Vaetech.Data.ContentResult
{
    public class EncryptResult : TupleResult
    {
        public string Encoded { get; set; }
        public byte[] EncodedInBytes { get; set; }

        public EncryptResult() { }
        public EncryptResult(string encrypted, byte[] encryptedInBytes, bool ibExeption = false, string message = null): base(ibExeption, message)
        {
            Encoded = encrypted;
            EncodedInBytes = encryptedInBytes;
        }
        public EncryptResult(string encrypted, bool ibExeption, string message) : base(ibExeption, message) => Encoded = encrypted;
        public EncryptResult(byte[] encrypted, bool ibExeption, string message) : base(ibExeption, message) => EncodedInBytes = encrypted;        
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
