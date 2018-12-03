namespace Models
{
    public class User : BaseEntity
    {
        public User() : base()
        {
        }

        // **********
        public bool IsActive { get; set; }
        // **********

        // **********
        public bool IsAdmin { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 20, MinimumLength = 6)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string Username { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 64, MinimumLength = 8)]
        public string Password { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string FullName { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 200)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Description { get; set; }
        // **********

        // **********
        public string DisplayName
        {
            get
            {
                return $"{FullName} [{Username}] [{(IsActive ? "Active" : "NotActive")}] [{(IsAdmin ? "Admin" : "NotAdmin")}]";
            }
        }
        // **********

        // **********
        public bool NeedPassChange { get; set; }
        // **********

    }
}
