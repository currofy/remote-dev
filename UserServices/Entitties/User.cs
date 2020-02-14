namespace UserServices.Entitties
{
    #region using
    using System.ComponentModel.DataAnnotations.Schema;
    #endregion
    public class User
    {
        #region Public Properties
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        #endregion
    }
}
