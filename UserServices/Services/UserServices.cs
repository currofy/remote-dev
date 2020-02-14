namespace UserServices
{
    #region using
    using System.Linq;
    using System.Threading.Tasks;
    using Grpc.Core;
    using Microsoft.Extensions.Logging;
    #endregion

    public class UserServices : UserRepo.UserRepoBase
    {
        #region Private Properties
        private readonly ILogger<UserServices> _logger;
        private UserDbContext gUserDbContext = null;
        #endregion

        #region Constructor
        public UserServices(ILogger<UserServices> logger, UserDbContext pUserDbContext)
        {
            _logger = logger;
            gUserDbContext = pUserDbContext;
        }
        #endregion

        #region Public Methods
        public override Task<Users> GetAll(Nothing pRequestData, ServerCallContext pServerContext)
        {
            Users vResponseData = new Users();
            var vUserQuery = from vUser in gUserDbContext.Users
                             select new User()
                             {
                                 UserId = vUser.UserId,
                                 UserName = vUser.UserName,
                                 UserEMail = vUser.UserEMail
                             };

            vResponseData.Records.AddRange(vUserQuery.ToArray());

            return Task.FromResult(vResponseData);
        }

        public override Task<User> GetById(UserFilter pUserFilter, ServerCallContext pServerCallContext)
        {
            var vUserSearch = gUserDbContext.Users.Find(pUserFilter.UserId);
            User vUser = new User()
            {
                UserId = vUserSearch.UserId,
                UserName = vUserSearch.UserName,
                UserEMail = vUserSearch.UserEMail
            };

            return Task.FromResult(vUser);
        }

        public override Task<Nothing> Add(User pUser, ServerCallContext pServerCallContext)
        {
            gUserDbContext.Users.Add(new User()
            {
                UserId = pUser.UserId,
                UserName = pUser.UserName,
                UserEMail = pUser.UserEMail
            });

            gUserDbContext.SaveChanges();

            return Task.FromResult(new Nothing());
        }

        public override Task<Nothing> Update(User pUser, ServerCallContext pServerCallContext)
        {
            gUserDbContext.Users.Update(new User()
            {
                UserId = pUser.UserId,
                UserName = pUser.UserName,
                UserEMail = pUser.UserEMail
            });

            gUserDbContext.SaveChanges();

            return Task.FromResult(new Nothing());
        }

        public override Task<Nothing> Delete(UserFilter pUserFilter, ServerCallContext pServerCallContext)
        {
            var vUserSearch = gUserDbContext.Users.Find(pUserFilter.UserId);

            //gUserDbContext.Users.Remove(new User()
            //{
            //    UserId = vUserSearch.UserId,
            //    UserName = vUserSearch.UserName,
            //    UserEMail = vUserSearch.UserEMail
            //});

            gUserDbContext.Users.Remove(vUserSearch);

            gUserDbContext.SaveChanges();

            return Task.FromResult(new Nothing());
        }
        #endregion
    }
}
