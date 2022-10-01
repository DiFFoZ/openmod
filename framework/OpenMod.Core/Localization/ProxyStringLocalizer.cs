using System.Collections.Generic;
using Microsoft.Extensions.Localization;
using OpenMod.API;

namespace OpenMod.Core.Localization
{
    [OpenModInternal]
    public class ProxyStringLocalizer : IStringLocalizer
    {
        private readonly IStringLocalizer m_StringLocalizer;

        public ProxyStringLocalizer(IStringLocalizer stringLocalizer)
        {
            m_StringLocalizer = stringLocalizer;
        }

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            return m_StringLocalizer.GetAllStrings(includeParentCultures);
        }

        public LocalizedString this[string name]
        {
            get { return m_StringLocalizer[name]; }
        }

        public LocalizedString this[string name, params object[] arguments]
        {
            get { return m_StringLocalizer[name, arguments]; }
        }
    }
}
