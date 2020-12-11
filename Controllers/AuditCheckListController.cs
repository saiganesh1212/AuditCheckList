using AuditCheckList.Provider;
using AuditCheckList.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditCheckList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditCheckListController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AuditCheckListController));
        private IAuditProvider _provider;
        public AuditCheckListController(IAuditProvider provider)
        {
            _provider = provider;
        }
        [HttpGet("{AuditType}")]
        public IActionResult Get(string AuditType)
        {
            try
            {
                _log4net.Info("Http get request initiated with " + AuditType);
                var questionlist = _provider.GetList(AuditType);
                if (questionlist != null)
                    return Ok(questionlist);
                else
                    return NotFound();
            }
            catch(Exception e)
            {
                _log4net.Error("No content Obtained " + e.Message);
                return new NoContentResult();
            }
        }
    }
}
