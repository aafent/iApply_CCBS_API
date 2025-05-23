﻿namespace CCBS.Models
{
    public static class ccbsFolders
    {
        #region Public Fields

        public const string AccountOtherTag = AccountOtherOrder + ". " + AccountOtherLabel;

        public const string CollateralTag = CollateralOrder + ". " + CollateralLabel;

        public const string CreditLimitTag = CreditLimitOrder + ". " + CreditLimitLabel;

        public const string CustomerTag = CustomerOrder + ". " + CustomerLabel;

        public const string DepositsTag = DepositsOrder + ". " + DepositsLabel;

        public const string DrawDownTag = DrawDownOrder + ". " + DrawDownLabel;

        public const string FeesTag = FeesOrder + ". " + FeesLabel;

        public const string GreenTag = GreenOrder + ". " + GreenLabel;

        public const string InformativeTag = InformativeOrder + ". " + InformativeLabel;

        public const string InsuranceTag = InsuranceOrder + ". " + InsuranceLabel;

        public const string LGTag = LGOrder + ". " + LGLabel;

        public const string MortgageTag = MortgageOrder + ". " + MortgageLabel;

        public const string OtherTag = OtherOrder + ". " + OtherLabel;

        public const string PositionTag = PositionOrder + ". " + PositionLabel;

        public const string PropertiesTag = PropertiesOrder + ". " + PropertiesLabel;

        public const string RepaymentScheduleTag = RepaymentScheduleOrder + ". " + RepaymentScheduleLabel;

        public static readonly Dictionary<string, string> folders = new Dictionary<string, string> {
            { InformativeOrder, InformativeLabel },
            { CustomerOrder, CustomerLabel },
            { PositionOrder, PositionLabel },
            { PropertiesOrder, PropertiesLabel },
            { DrawDownOrder, DrawDownLabel },
            { RepaymentScheduleOrder, RepaymentScheduleLabel },
            { CollateralOrder, CollateralLabel },
            { CreditLimitOrder, CreditLimitLabel },
            { AccountOtherOrder,AccountOtherLabel },
            { LGOrder,LGLabel },
            { InsuranceOrder, InsuranceLabel },
            { MortgageOrder,MortgageLabel },
            { FeesOrder,FeesLabel },
            { DepositsOrder,DepositsLabel },
            { GreenOrder,GreenLabel },
            { OtherOrder, OtherLabel }
        };

        #endregion Public Fields

        #region Private Fields

        private const string AccountOtherLabel = "AccountOther";

        private const string AccountOtherOrder = "07";

        private const string CollateralLabel = "Collateral";

        private const string CollateralOrder = "05";

        private const string CreditLimitLabel = "CreditLimit";

        private const string CreditLimitOrder = "06";

        private const string CustomerLabel = "Customer";

        private const string CustomerOrder = "01";

        private const string DepositsLabel = "Deposits";

        private const string DepositsOrder = "11";

        private const string DrawDownLabel = "DrawDown";

        private const string DrawDownOrder = "04";

        private const string FeesLabel = "Fees";

        private const string FeesOrder = "10";

        private const string GreenLabel = "More (Light Edition)";

        private const string GreenOrder = "90";

        private const string InformativeLabel = "Informative";

        private const string InformativeOrder = "00";

        private const string InsuranceLabel = "Insurance";

        private const string InsuranceOrder = "12";

        private const string LGLabel = "LG";

        private const string LGOrder = "08";

        private const string MortgageLabel = "Mortgage";

        private const string MortgageOrder = "09";

        private const string OtherLabel = "Other";

        private const string OtherOrder = "99";

        private const string PositionLabel = "Position";

        private const string PositionOrder = "02";

        private const string PropertiesLabel = "Properties";

        private const string PropertiesOrder = "12";

        private const string RepaymentScheduleLabel = "Repayment Schedule";

        private const string RepaymentScheduleOrder = "03";

        #endregion Private Fields
    }
}