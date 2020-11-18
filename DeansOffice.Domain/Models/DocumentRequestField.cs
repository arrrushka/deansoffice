namespace DeansOffice.Domain.Models
{
    /// <summary>
    /// Поле заявки.
    /// Любые данные, которые могут быть в форме.
    /// Например, Имя, Возраст, Группа и т.д.
    /// </summary>
    public class DocumentRequestField
    {
        /// <summary>
        /// Уникальный идентификатор поля.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Ключ поля. Например: Имя
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Значение поля. Например: Иван.
        /// </summary>
        public string Value { get; set; }


        /// <summary>
        /// Уникальный идентификатор заявки, к которой это поле принадлежит.
        /// </summary>
        public long RequestId { get; set; }

        /// <summary>
        /// Заявка, к которой это поле принадлежит.
        /// </summary>
        public DocumentRequest Request { get; set; }
    }
}
