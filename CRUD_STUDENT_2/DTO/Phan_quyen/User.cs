using CRUD_STUDENT_2.DTO.Phan_quyen;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace CRUD_STUDENT_2
{
    [Dapper.Contrib.Extensions.Table("tbl_User_Account")]
    internal class User
    {
        [Key]
        public string U_ID { get; set; }
        public string U_Name { get; set; }
        public string U_Pass { get; set; }
        //public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

        public void EncryptionHashPassword(out byte[] salt)
        {
            const int keySize = 64;
            const int iterations = 350000;
            HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

            salt = new byte[keySize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            var hash = new Rfc2898DeriveBytes(
                Encoding.UTF8.GetBytes(this.U_Pass),
                salt,
                iterations,
                hashAlgorithm);

            this.U_Pass = BitConverter.ToString(hash.GetBytes(keySize)).Replace("-", string.Empty).ToLower().Substring(0,40);
        }
    }
}
