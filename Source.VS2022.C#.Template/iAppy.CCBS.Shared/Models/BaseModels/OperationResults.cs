namespace iApplyShared.Models
{
    public static class OperationResults
    {
        #region Public Methods

        public static OperationResult Sucess()
        {
            return new OperationResult();
        }

        //public static OperationResult ValidationError(string errorCode, string errorMessage, CoreBankingSystemException ex = null)
        //{
        //    if (ex != null)
        //    {
        //        Type exType = ex.GetType();

        //        if (exType == typeof(CoreBankingSystemException) || exType == typeof(ProfitsValidationException))
        //        {
        //            return ValidationError(errorCode, "{0}", ex, errorMessage);
        //        }
        //    }

        //    return ValidationError(errorCode, "{0}", errorMessage);
        //}

        public static OperationResult ValidationError(string errorCode, string format, params object[] args)
        {
            return new OperationResult(new OperationError(errorCode, "400", String.Format(format, args)));
        }

        //public static OperationResult ValidationError(string errorCode, string format, CoreBankingSystemException ex, params object[] args)
        //{
        //    return new OperationResult(new OperationError(errorCode, "400", String.Format(format, args), ex.ProfitsInnerRequest, ex.ProfitsInnerResponse));
        //}

        #endregion Public Methods
    }
}