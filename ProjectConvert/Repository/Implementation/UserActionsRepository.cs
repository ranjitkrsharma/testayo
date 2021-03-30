//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using ConverterAPI.Entities;
//using ConverterAPI.Repository.Contract;

//namespace ConverterAPI.Repository.Implementation
//{
//    public class UserActionsRepository : IUserActionsRepository<UserActions>
//    {
//        readonly AuditContext _auditContext;

//        public UserActionsRepository(AuditContext context)
//        {
//            _auditContext = context;
//        }

//        public IEnumerable<UserActions> GetAllUserActions()
//        {
//            return _auditContext.UserAction.ToList();
//        }
//    }
//}