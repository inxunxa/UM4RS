using System.ComponentModel.DataAnnotations;

namespace UM4RS
{
    public class ModelAttribute :  ModelEntity<ModelAttribute>, IBaseEntity
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
