namespace CCBS.Models
{
    public class RepaymentScheduleInsuranceData
    {
        #region Public Properties

        public DateTime? BirthDate { get; set; } =  DateTime.Parse("1800-01-01");

        public int? InsuranceCode { get; set; }

        public decimal? InsuredAmount { get; set; }

        public string MainBeneficiaryFlag { get; set; }

        #endregion Public Properties
    }
}