namespace CCBS.Models
{
    public class CbsCustomerCategory
    {
        #region Public Properties

        public string CategoryCode { get; set; }

        public string CategoryDescription { get; set; }

        public DateTime CategoryTmstamp { get; set; } =  DateTime.Parse("1800-01-01");

        public string DetailDescription { get; set; }

        public string DetailSerialNum { get; set; }

        public string HeaderParameterType { get; set; }

        public string SuppliedFlag { get; set; }

        public string SuppliedSelectChar { get; set; }

        #endregion Public Properties
    }
}