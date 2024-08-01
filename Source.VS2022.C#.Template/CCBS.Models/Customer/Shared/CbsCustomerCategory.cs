namespace CCBS.Models
{
    public class CbsCustomerCategory
    {
        #region Public Properties

        public string CategoryCode { get; set; }

        public string CategoryDescription { get; set; }

        public DateTime CategoryTmstamp { get; set; }

        public string DetailDescription { get; set; }

        public int DetailSerialNum { get; set; }

        public string HeaderParameterType { get; set; }

        public string SuppliedFlag { get; set; }

        public string SuppliedSelectChar { get; set; }

        #endregion Public Properties
    }
}