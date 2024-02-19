using Codify.Automation.Core.Interfaces.Structures;

namespace Codify.Automation.UI.Structures
{
    public class UserEntity : IBusinessEntity
    {
        public string? Login { get; set; }
        public string? Password { get; set; }
    }
}
