using System;

namespace DeansOffice.Domain.Models
{
    /// <summary>
    /// Документ, который выдают студенту по его заявлению.
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Уникальный идентификатор документа.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Название документа.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Данные документа.
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// Уникальный идентификатор заявки, для которой создан этот документ.
        /// </summary>
        public long RequestId { get; set; }

        /// <summary>
        /// Заявка, для которой создан этот документ.
        /// </summary>
        public DocumentRequest Request { get; set; }

        /// <summary>
        /// Когда документ был сгенерирован.
        /// </summary>
        public DateTime GeneratedDate { get; set; }
    }
}
