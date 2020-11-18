namespace DeansOffice.Domain.Models
{
    /// <summary>
    /// Статус заявки.
    /// </summary>
    public enum DocumentRequestStatus
    {
        /// <summary>
        /// Не проверена.
        /// </summary>
        NotChecked,

        /// <summary>
        /// Документ выдан.
        /// </summary>
        Approved,

        /// <summary>
        /// Отказано
        /// </summary>
        Denied
    }
}
