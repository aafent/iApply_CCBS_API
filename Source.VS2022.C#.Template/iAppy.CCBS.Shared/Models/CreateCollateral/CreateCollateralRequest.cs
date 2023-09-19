using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CreateCollateralRequest : BaseRequest
    {
        [DataMember]
        public string ApplicationId { get; set; }

        //This was commented out by iApply 

        ///// <summary>
        ///// Total collateral estimated value	InCollateral.ColEstValueAmn	Numeric	
        ///// </summary>
        //[DataMember]
        //public decimal TotalValue { get; set; }
        ///// <summary>
        ///// currency of the collateral	InCurrency.IdCurrency	Numeric	
        ///// </summary>
        //[DataMember]
        //public int CurrencyID { get; set; }
        ///// <summary>
        ///// Branch	InMonitoringUnit.Code	Numeric	
        ///// </summary>
        //[DataMember]
        //public int BranchID { get; set; }
        ///// <summary>
        /////Collateral type code	InCollateralProduct.IdProduct	Text	Permitted values: 1 - Prenotation, 2 - Mortgage, 3 - Deposit Pledges, 4 - Stock Mortgages, 5 - Stock Margin, 6 - Ship Mortgage, 7 - Bond Mortgage, 8 - Automobiles, 9- Cheques, 10- Invoices, 11- Dynamic Pledges, 99 - Other.  
        ///// </summary>
        //[DataMember]
        //public ProfitsCollateralType CollateralTypeCode { get; set; }
        ///// <summary>
        ///// Collateral type desc	InCollateralTypeProduct.Description	Text	
        ///// </summary>
        //[DataMember]
        //public string CollateralTypeDescription { get; set; }
        ///// <summary>
        ///// Customer ID	InNewColltblCustomer.CustId	Numeric
        ///// </summary>
        //[DataMember]
        //public int CustomerID { get; set; }
        ///// <summary>
        ///// Current date	InTrxBankParameters.CurrTrxDate	Date
        ///// </summary>
        //[DataMember]
        //public DateTime CurrentDate { get; set; }

    }
}
