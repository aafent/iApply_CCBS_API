namespace CCBS.Models
{
    public class CbsDownloadRepScenarioResponse : CommonResponseModel
    {
        #region Public Properties

        public List<CbsCoinsuredDataModel> CoinsuredDataList { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Customer Id
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: sourceData.CustomerId
        /// </summary>
        public string cu_id { get; set; }

        public List<CbsCustomerDataModel> CustomerDataList { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Approved Amount
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: sourceData.Amount
        /// </summary>
        public decimal la_appamt { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Branch
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: sourceData.Branch
        /// </summary>
        public string la_branc { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Customer Category
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: sourceData.CustomerCategory
        /// </summary>
        public string la_custcat { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Application Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: sourceData.ApplicationDate
        /// </summary>
        public DateTime la_date { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Application Id
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: request.ApplicationId
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Product Category
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: sourceData.ProductCategory
        /// </summary>
        public string la_mark_id { get; set; }

        public List<CbsMediators> MediatorDataList { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Source
        /// Data Type: N/A
        /// Notes: 2
        /// CBS: N/A
        /// </summary>
        public string source { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Type
        /// Data Type: varchar (15)
        /// Notes: 1
        /// CBS: N/A
        /// </summary>
        public string type { get; set; }

        #endregion Public Properties
    }
}