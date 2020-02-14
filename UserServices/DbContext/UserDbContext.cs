namespace UserServices
{
    #region using
    using Microsoft.EntityFrameworkCore;
    #endregion

    public class UserDbContext : DbContext
    {
        #region Public Properties
        public DbSet<User> Users { get; set; }
        #endregion

        #region Constructor
        public UserDbContext (DbContextOptions<UserDbContext> pOptions) : base(pOptions)
        {

        }
        #endregion
    }
}
