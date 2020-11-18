using System;
using System.Collections.Generic;
using System.Text;

namespace DeansOffice.Domain.Models
{
    /// <summary>
    /// Заявка на получение документа.
    /// </summary>
    public class DocumentRequest
    {
        /// <summary>
        /// Уникальный идентификатор заявки.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор отправителя заявки.
        /// </summary>
        public long SenderId { get; set; }
        /// <summary>
        /// Отправитель заявки.
        /// </summary>
        public User Sender { get; set; }

        /// <summary>
        /// В каком статусе заявка.
        /// </summary>
        public DocumentRequestStatus Status { get; set; }

        /// <summary>
        /// Тип документа, который заявитель хочет получить.
        /// </summary>
        public DocumentType RequestedDocument { get; set; }

        /// <summary>
        /// Дата создания заявки.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Поля заявки.
        /// </summary>
        public ICollection<DocumentRequestField> Fields { get; set; }
    }
}
