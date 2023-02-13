
using WPFInventoryManagementSystem.Domain.Models.Base;

namespace WPFInventoryManagementSystem.Domain.Models
{
    public class Uom : EntityBase
    {    
        public string Code { get; private set; }
        public string Name { get; private set; }

        private Uom()
        {

        }

        public Uom(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
