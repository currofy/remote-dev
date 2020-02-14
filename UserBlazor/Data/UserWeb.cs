namespace UserBlazor.Data
{
    #region using
    using System.ComponentModel.DataAnnotations;
    #endregion

    public class UserWeb
    {
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }
    }
}
