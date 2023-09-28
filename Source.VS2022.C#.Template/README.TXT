CCBS-API
Common Core Banking System API
C# Template Program
Visual Studio 2022

Solution: Into folder iApplyCCBSTemplateAPI
Folders: 	iApplyCCBSTemplateAPI
			iAppy.CCBS.Shared
			iApply.CCBS.Template


---------28/9/2023 updates--------
	modified:   iAppy.CCBS.Shared/Attributes/MockupAttribute.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/AccountOther/CreateInstantLoan/CbsInstantLoanRequest.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/AccountOther/CreateInstantLoan/GuarantorsList.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/AccountOther/DownloadDebt/CbsDownloadDebtResponse.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/AccountOther/DownloadDebt/OtherCollateral.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/AccountOther/DownloadDebt/PropertyCollateral.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/AccountOther/SaveAccountScenario/CbsSaveAccountScenarioRequest.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/Collateral/FinalizeCollateralMaintenanceMaster/CbsFinalizeCollateralCbsRequest.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/Collateral/FinalizeCollateralMaintenanceMaster/CbsFinalizeCollateralCbsResponse.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Collateral/InsertCollateralMaintenanceMaster/CbsInsertCollateralCbsRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Collateral/InsertCollateralMaintenanceMaster/CbsInsertCollateralCbsResponse.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Collateral/InsertFinCollateralMaintenanceMaster/CbsInsertFinCollateralMaintenanceMasterRequest.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/Collateral/InsertFinCollateralMaintenanceMaster/InGrp.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/Collateral/InsertFinCollateralMaintenanceMaster/OutGrp.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Collateral/RetrieveCbsCollateral/CbsRetrieveCbsCollateralRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Collateral/RetrieveCbsCollateral/CbsRetrieveCbsCollateralResponse.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Collateral/UpdateCollateralMaintenanceMaster/CbsUpdateCollateralCbsRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Collateral/UpdateCollateralMaintenanceMaster/CbsUpdateCollateralCbsResponse.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/CreditLimit/CreateCreditLine/CbsCreateCreditLineRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/CreditLimit/DeleteCreditLine/CbsDeleteCreditLineRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/CreditLimit/UpdateCreditLine/CbsUpdateCreditLineRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Customer/DeleteAddress/CbsDeleteAdressRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Customer/DeleteCustAccRelationships/CbsDeleteCustAccRelationshipsRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Customer/DeleteCustIdentif/CbsDeleteCustIdentifRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Customer/DeleteCustomerRelationships/CbsDeleteCustomerRelationshipsRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Customer/GetCustomerRelationships/CbsGetCustomerRelationshipsRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Customer/GetCustomerRelationships/CbsGetCustomerRelationshipsResponse.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/Customer/GetCustomerRelationships/CustomerRelationshipAccountDetail.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/Customer/GetCustomerRelationships/CustomerRelationshipDetail.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Customer/GetIndividualCustomer/CbsGetIndividualCustomerResponse.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Customer/GetLegalCustomer/CbsGetLegalCustomerResponse.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/Customer/Shared/CustomerAddress.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/Customer/Shared/CustomerCategory.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/Customer/Shared/CustomerIdentification.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Customer/UpdateCustomerRelationships/CbsUpdateCustomerRelationshipsRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Customer/UpdateIndividualCustomer/CbsUpdateIndividualCustomerRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Deposits/UpdateDepositAccount/CbsUpdateDepositAccountRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Deposits/UpdateDepositStatus/CbsUpdateDepositStatusRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Deposits/UpdateDepositStatus/CbsUpdateDepositStatusResponse.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/DrawDown/CancelDrawDown/CbsCancelDrawDownRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/DrawDown/CreateDrawDown/CbsCreateDrawDownRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/DrawDown/CreateDrawDown/CbsCreateDrawDownResponse.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/DrawDown/RetrieveDrawDown/CbsRetrieveDrawDownRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Mortgage/InsertMortgage/CbsInsertMortgageRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Mortgage/RetrieveMortgage/CbsRetrieveMortgageResponse.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/Mortgage/Shared/MortgageProperty.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Mortgage/UpdateMortgage/CbsUpdateMortgageRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Other/CreateLGBeneficiary/CbsCreateLGBeneficiaryRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Other/DownloadRepScenario/CbsDownloadRepScenarioRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Other/DownloadRepScenario/CbsDownloadRepScenarioResponse.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Other/DownloadRepScenarioSim/CbsDownloadRepScenarioSimRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Other/DownloadRepScenarioSim/CbsDownloadRepScenarioSimResponse.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/Other/DownloadRepScenarioSim/RepaymentScheduleInsuranceData.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Other/LetOfGuaBenef/CbsLetOfGuaBenefResponse.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Other/SaveRepScenario/CbsSaveRepScenarioRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Other/SaveRepScenario/CbsSaveRepScenarioResponse.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Other/UpdateLGBeneficiary/CbsUpdateLGBeneficiaryRequest.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Positions/DownloadAccountDetails/CbsDownloadAccountDetailsResponse.cs
	modified:   iAppy.CCBS.Shared/CCbsModels/Positions/DownloadPositionAndDetails/CbsDownloadPositionAndDetailsResponse.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/Positions/DownloadPositionAndDetails/DownloadLoanInsurance.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/RepaymentSchedule/DownloadRepScheduleSim/CbsDownloadRepScheduleSimRequest.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/RepaymentSchedule/DownloadRepScheduleSim/CbsDownloadRepScheduleSimResponse.cs
	new file:   iAppy.CCBS.Shared/CCbsModels/RepaymentSchedule/DownloadRepScheduleSim/RepaymentScheduleSimInsuranceData.cs
	modified:   iAppy.CCBS.Shared/Models/CbsCustomer/GetCustomerRelationshipsRequest.cs
	modified:   iAppy.CCBS.Shared/Models/DepositAccount/UpdateDepositAccountRequest.cs
	modified:   iAppy.CCBS.Shared/Models/DownloadRepScenario/DownloadRepScenarioResponse.cs
	modified:   iAppy.CCBS.Shared/iApply.CCBS.Shared.csproj


