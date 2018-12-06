namespace Models
{
    public class Stuff : BaseEntity
    {
        public Stuff() : base()
        {
        }

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 30, MinimumLength = 2)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string Name { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = true)]

        [System.ComponentModel.DataAnnotations.Range
            (minimum:1000000000000,maximum:9999999999999)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public double GeneralNumber { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = true)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 20)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string OrderCode { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 200)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Description { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = true)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public int Quantity { get; set; }
        // **********

        // **********
        public string DisplayName
        {
            get
            {
                return $"{Name} - {GeneralNumber} - {OrderCode} - {Quantity}";
            }
        }
        // **********

    }
}
