using AuditCheckList.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditCheckList.Repository
{
    public class AuditRepository : IAuditRepository
    {
        static List<string> internalList = new List<string>()
        {
            "Have all Change requests followed SDLC before PROD move?",
            "Have all Change requests been approved by the application owner?",
            "Are all artifacts like CR document, Unit test cases available?",
            "Is the SIT and UAT sign-off available?",
            "Is data deletion from the system done with application owner approval?"
        };
        static List<string> soxList = new List<string>()
        {
            "Have all Change requests followed SDLC before PROD move? ",
            "Have all Change requests been approved by the application owner?",
            "For a major change, was there a database backup taken before and after PROD move?",
            "Has the application owner approval obtained while adding a user to the system?",
            "Is data deletion from the system done with application owner approval"
        };

        public List<string> GetByType(string auditType)
        {
            if (auditType == "Internal")
            {
                return internalList;
            }
            else 
            {
                return soxList;
            }
        }
    }
}
