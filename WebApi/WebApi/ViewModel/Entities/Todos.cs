using Dapper.Contrib.Extensions;

namespace WebApi.ViewModel.Entities
{
    [Table("Todos")]
    public class Todos
    {
        [Key]
        public int Id { get; set; }
        public string Todo { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
