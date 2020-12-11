using AuditCheckList.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditCheckList.Provider
{
    public class AuditProvider:IAuditProvider
    {
        private IAuditRepository _service;
        public AuditProvider(IAuditRepository service)
        {
            _service = service;
        }
        public List<string> GetList(string AuditType)
        {
                return _service.GetByType(AuditType);
        }

    }
}
