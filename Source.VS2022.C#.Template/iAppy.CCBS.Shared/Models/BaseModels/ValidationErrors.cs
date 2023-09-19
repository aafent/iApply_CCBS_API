using iApplyShared.CbsModels;

namespace iApplyShared.Models.BaseModels
{
    /// <summary>
    /// Each service operation extends this class with its own errors.
    /// </summary>
    public static partial class ValidationErrors
    {
        public static OperationResult PRFTS01(CommonValidationsException ex)
        {
            return OperationResults.ValidationError(string.Format("PRFT:{0}", ex.Id, ex),
                string.Format("Profits error Id:{0}, Message:{1}, ReferenceKey:{2}", ex.Id, ex.Message, ex.ReferenceKey), ex);
        }

        public static OperationResult PRFTS01(CommonException ex)
        {
            return OperationResults.ValidationError(string.Format("PRFT:{0}", ex.Id, ex),
                string.Format("Profits error Id:{0}, Message:{1}, ReferenceKey:{2}", ex.Id, ex.Message, ex.ReferenceKey), ex);
        }

        //public static OperationResult DCS01(DCValidationException ex)
        public static OperationResult DCS01(Exception ex)
        {
            return OperationResults.ValidationError(string.Format("DCS01"),
                string.Format("Banker error , Message:{0}, ", ex.Message));
        }

        public static OperationResult BCE01(BusinessConventionException ex)
        {
            return OperationResults.ValidationError(string.Format("BCE:{0}", ex.Id),
                string.Format("Business Convention Id:{0}, Message:{1}", ex.Id, ex.Message));
        }

        public static OperationResult CREBU01(Exception ex)
        {
            return OperationResults.ValidationError(string.Format("CREBU01"),
                string.Format("Credit Bureau error , Message:{0}, ", ex.Message));
        }

        public static OperationResult SAPCRM01(Exception ex)
        {
            return OperationResults.ValidationError(string.Format("SAPCRM01"),
                string.Format("Sap Crm error , Message:{0}, ", ex.Message));
        }

        public static OperationResult RTEML01(Exception ex)
        {
            return OperationResults.ValidationError(string.Format("RTEML01"),
                string.Format("Email Error , Message:{0}, ", ex.Message));
        }

        public static OperationResult IPRS01(Exception ex)
        {
            return OperationResults.ValidationError(string.Format("IPRS01"),
                string.Format("IPRS error , Message:{0}, ", ex.Message));
        }

        public static OperationResult KRA01(Exception ex)
        {
            return OperationResults.ValidationError(string.Format("KRA01"),
                string.Format("KRA error , Message:{0}, ", ex.Message));
        }
        public static OperationResult IMSI01(Exception ex)
        {
            return OperationResults.ValidationError(string.Format("IMSI01"),
                string.Format("IMSI error , Message:{0}, ", ex.Message));
        }
    }
}
