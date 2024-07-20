# TeamSprit_input

## �����c
- �ݒ��ʂ̓��͒l�`�F�b�N
- �ݒ�t�@�C���̈Í���  
AES�ɂ��Í���(AI�����ɂ��v���O�����̂��߁A�������K�v)  
``` csharp
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string password = "mySecurePassword";
        string encryptedFilePath = "encryptedPassword.dat";
        string keyFilePath = "protectedKey.dat";

        // �Í����L�[�̐����ƕۑ��i����̂݁j
        if (!File.Exists(keyFilePath))
        {
            GenerateAndSaveKey(keyFilePath);
        }

        // �Í����L�[�̓ǂݍ���
        string encryptionKey = LoadAndUnprotectKey(keyFilePath);

        // �p�X���[�h�̈Í����ƕۑ�
        EncryptAndSavePassword(password, encryptedFilePath, encryptionKey);

        // �t�@�C������p�X���[�h�𕜍������ēǂݍ���
        string decryptedPassword = LoadAndDecryptPassword(encryptedFilePath, encryptionKey);

        Console.WriteLine($"Decrypted Password: {decryptedPassword}");
    }

    static void GenerateAndSaveKey(string filePath)
    {
        using (Aes aes = Aes.Create())
        {
            byte[] key = aes.Key;
            byte[] protectedKey = ProtectedData.Protect(key, null, DataProtectionScope.CurrentUser);
            File.WriteAllBytes(filePath, protectedKey);
        }
    }

    static string LoadAndUnprotectKey(string filePath)
    {
        byte[] protectedKey = File.ReadAllBytes(filePath);
        byte[] key = ProtectedData.Unprotect(protectedKey, null, DataProtectionScope.CurrentUser);
        return Convert.ToBase64String(key);
    }

    static void EncryptAndSavePassword(string password, string filePath, string base64Key)
    {
        byte[] key = Convert.FromBase64String(base64Key);

        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.GenerateIV();

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                fileStream.Write(aes.IV, 0, aes.IV.Length);

                using (CryptoStream cryptoStream = new CryptoStream(fileStream, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter writer = new StreamWriter(cryptoStream))
                    {
                        writer.Write(password);
                    }
                }
            }
        }
    }

    static string LoadAndDecryptPassword(string filePath, string base64Key)
    {
        byte[] key = Convert.FromBase64String(base64Key);

        using (Aes aes = Aes.Create())
        {
            aes.Key = key;

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                byte[] iv = new byte[aes.BlockSize / 8];
                fileStream.Read(iv, 0, iv.Length);
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (CryptoStream cryptoStream = new CryptoStream(fileStream, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader reader = new StreamReader(cryptoStream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }
    }
}
```