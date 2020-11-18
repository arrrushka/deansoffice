using System;

namespace DeansOffice.Domain.Models
{
    /// <summary>
    /// Пользователь системы.
    /// </summary>
    public class User
    {
        public long Id { get; set; }

        public string Login { get; set; }

        public string Role { get; set; }

        public DateTime RegisteredDate { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
