using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Common
{
    public abstract class NameView: UniqueEntityView
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }
    }
}