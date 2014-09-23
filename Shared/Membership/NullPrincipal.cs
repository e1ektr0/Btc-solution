using System.Security.Principal;

namespace BtcSolutions.Shared.Membership
{
    /// <summary>
    /// Заглушка для IPrincipal
    /// Должна быть использована когда HttpContext null
    /// </summary>
    public class NullPrincipal : IPrincipal
    {
        public bool IsInRole(string role)
        {
            return false;
        }

        public IIdentity Identity { get; private set; }
    }
}