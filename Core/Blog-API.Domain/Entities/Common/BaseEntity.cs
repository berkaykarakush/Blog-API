namespace Blog_API.Domain.Entities.Common
{
    /// The BaseEntity, which serves as the base entity class, contains common properties for all entity classess
    public class BaseEntity
    {
        /// The Id property generates a random value between 111111111(inclusive) and 999999999(exclusive) during object instantiation and assings this generated value as the unique identifier (Id) for the object
        public double Id { get; set; } = new Random().Next(111111111, 999999999);
        /// The creation date of the entity
        public DateTime CreatedDate { get; set; }
        /// The last updated date of the entity
        virtual public DateTime UpdatedDate { get; set; }
    }
}
