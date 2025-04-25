CCBS-API Specification
Common Core Banking System API
C# Template Program
Visual Studio 2022

Solution: Into folder iApplyCCBSTemplateAPI 
Folders: 	CCBS.Template (solution folder)
			CCBS.Models


---------BEFORE 1/8/2024 updates--------



Solution: Into folder iApplyCCBSTemplateAPI
Folders: 	iApplyCCBSTemplateAPI
			iAppy.CCBS.Shared
			iApply.CCBS.Template


---------updates of 28/Sep/2023--------
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


---------updates of 25 Apr 20205--------
        new file:   CCBS.Models/ErrorDump.cs
        new file:   CCBS.Models/Insurance/CancelInsurance/CbsCancelInsuranceRequest.cs
        new file:   CCBS.Models/Insurance/CancelInsurance/CbsCancelInsuranceResponse.cs
        new file:   CCBS.Models/Insurance/CreateInsurance/CbsCreateInsuranceRequest.cs
        new file:   CCBS.Models/Insurance/CreateInsurance/CbsCreateInsuranceResponse.cs
        new file:   CCBS.Models/Insurance/FinalizeInsurance/CbsFinalizeInsuranceRequest.cs
        new file:   CCBS.Models/Insurance/FinalizeInsurance/CbsFinalizeInsuranceResponse.cs
        new file:   CCBS.Models/Insurance/InsuranceForecast/CbsInsuranceForecastRequest.cs
        new file:   CCBS.Models/Insurance/InsuranceForecast/CbsInsuranceForecastResponse.cs
        new file:   CCBS.Models/Insurance/RetrieveInsurance/CbsRetrieveInsuranceRequest.cs
        new file:   CCBS.Models/Insurance/RetrieveInsurance/CbsRetrieveInsuranceResponse.cs
        new file:   CCBS.Models/Insurance/UpdateInsurance/CbsUpdateInsuranceRequest.cs
        new file:   CCBS.Models/Insurance/UpdateInsurance/CbsUpdateInsuranceResponse.cs
        new file:   CCBS.Models/IrequestAdditionals.cs
        modified:   CCBS.Models/Mortgage/InsertMortgage/CbsInsertMortgageRequest.cs
        modified:   CCBS.Models/Mortgage/RetrieveMortgage/CbsRetrieveMortgageResponse.cs
        modified:   CCBS.Models/Mortgage/Shared/MortgageProperty.cs
        modified:   CCBS.Models/Mortgage/UpdateMortgage/CbsUpdateMortgageRequest.cs
        modified:   CCBS.Models/Positions/DownloadAccountDetails/CbsDownloadAccountDetailsResponse.cs
        modified:   CCBS.Models/Positions/DownloadPosition/CbsDownloadPositionResponse.cs
        modified:   CCBS.Models/Positions/DownloadPositionAndDetails/DownloadLoanInsurance.cs
        modified:   CCBS.Models/Positions/PositionData/PositionDataModel.cs
        modified:   CCBS.Models/RepaymentSchedule/Common/CbsCoinsuredDataModel.cs
        modified:   CCBS.Models/RepaymentSchedule/Common/CbsCustomerDataModel.cs
        modified:   CCBS.Models/RepaymentSchedule/Common/CbsGrace.cs
        modified:   CCBS.Models/RepaymentSchedule/Common/CbsInstallment.cs
        modified:   CCBS.Models/RepaymentSchedule/Common/CbsInsurance.cs
        modified:   CCBS.Models/RepaymentSchedule/Common/RepaymentScheduleInsuranceData.cs
        modified:   CCBS.Models/RepaymentSchedule/DownloadRepScenario/CbsDownloadRepScenarioResponse.cs
        modified:   CCBS.Models/RepaymentSchedule/DownloadRepScheduleSim/CbsDownloadRepScheduleSimResponse.cs
        modified:   CCBS.Models/RepaymentSchedule/DownloadRepScheduleSim/RepaymentScheduleSimInsuranceData.cs
        modified:   CCBS.Models/RepaymentSchedule/RepaymentSchedule/CbsRepaymentScheduleFixResponse.cs
        modified:   CCBS.Models/RepaymentSchedule/RepaymentSchedule_Retrieve/CbsRepaymentScheduleRetrieveResponse.cs
        modified:   CCBS.Models/RepaymentSchedule/RepaymentSchedule_Save/CbsRepaymentScheduleSaveRequest.cs
        modified:   CCBS.Models/RepaymentSchedule/RepaymentSchedule_Simulation/CbsRepaymentScheduleSimulationRequest.cs
        modified:   CCBS.Models/RepaymentSchedule/RepaymentSchedule_Simulation/CbsRepaymentScheduleSimulationResponse.cs
        modified:   CCBS.Models/RepaymentSchedule/SaveRepScenario/CbsSaveRepScenarioRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCancelAgreementRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCancelAgreementResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCancelDrawdownByIdRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCancelDrawdownByIdResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCancelInsuranceRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCancelInsuranceResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCheckBulkMessagesRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCheckBulkMessagesResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCollateralDetailListRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCollateralDetailListResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCollateralFxRateRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCollateralFxRateResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCollateralListPerTypeRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCollateralListPerTypeResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCreateAgreementBeneficiaryRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCreateAgreementBeneficiaryResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCreateAgreementGuarrantorRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCreateAgreementGuarrantorResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCreateAgreementRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCreateAgreementResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCreateBBFRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCreateBBFResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCreateCollateralRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCreateCollateralResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCreateInsuranceRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCreateInsuranceResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCreateJointAccountRequestHFB.cs
        modified:   CCBS.Models/_Rest_/CbsCreateJointAccountResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCreateLoanWithTopupRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCreateLoanWithTopupResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCreateMemberMessageRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCreateMemberMessageResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCreateMemberRegistrationRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCreateMemberRegistrationResponse.cs
        modified:   CCBS.Models/_Rest_/CbsCsInfoDCRequest.cs
        modified:   CCBS.Models/_Rest_/CbsCsInfoDCResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDMSUpdateLoanNumberByAppNoRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDMSUpdateLoanNumberByAppNoResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDMSUpdateMemberDocumentByAppNoRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDMSUpdateMemberDocumentByAppNoResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteAgreementBeneficiaryRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteAgreementBeneficiaryResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteAgreementGuarrantorRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteAgreementGuarrantorResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteBBFRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteBBFResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteCollateralDetailsRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteCollateralDetailsResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteCollateralGeneralRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteCollateralGeneralResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteDynamicCollateralRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteDynamicCollateralResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteMemberMessageRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteMemberMessageResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDeletePropertyOwnersRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDeletePropertyOwnersResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDeletePropertyRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDeletePropertyResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDeletePropertyValuationRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDeletePropertyValuationResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDeletePropertyValuersRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDeletePropertyValuersResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteValuerRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDeleteValuerResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadDepositAccountRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadDepositAccountResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadLetterOfCreditRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadLetterOfCreditResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadLetterOfGuaranteeRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadLetterOfGuaranteeResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadLoanAccountRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadLoanAccountResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadRepInstallmentRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadRepInstallmentResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadSecuritiesAccountRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadSecuritiesAccountResponse.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadTradeFinanceRequest.cs
        modified:   CCBS.Models/_Rest_/CbsDownloadTradeFinanceResponse.cs
        modified:   CCBS.Models/_Rest_/CbsFinalizeAgreementRequest.cs
        modified:   CCBS.Models/_Rest_/CbsFinalizeAgreementResponse.cs
        modified:   CCBS.Models/_Rest_/CbsFinalizeCollateralRequest.cs
        modified:   CCBS.Models/_Rest_/CbsFinalizeCollateralResponse.cs
        modified:   CCBS.Models/_Rest_/CbsFinalizeInsuranceRequest.cs
        modified:   CCBS.Models/_Rest_/CbsFinalizeInsuranceResponse.cs
        modified:   CCBS.Models/_Rest_/CbsGeneralCollateralListRequest.cs
        modified:   CCBS.Models/_Rest_/CbsGeneralCollateralListResponse.cs
        modified:   CCBS.Models/_Rest_/CbsGetAccountInfoRequest.cs
        modified:   CCBS.Models/_Rest_/CbsGetAccountInfoResponse.cs
        modified:   CCBS.Models/_Rest_/CbsGetApplicationListRequest.cs
        modified:   CCBS.Models/_Rest_/CbsGetApplicationListResponse.cs
        modified:   CCBS.Models/_Rest_/CbsGetBankEmployeeRequest.cs
        modified:   CCBS.Models/_Rest_/CbsGetBankEmployeeResponse.cs
        modified:   CCBS.Models/_Rest_/CbsGetCustomerCategoryRequest.cs
        modified:   CCBS.Models/_Rest_/CbsGetCustomerCategoryResponse.cs
        modified:   CCBS.Models/_Rest_/CbsGetDepBalanceAccrualsRequest.cs
        modified:   CCBS.Models/_Rest_/CbsGetDepBalanceAccrualsResponse.cs
        modified:   CCBS.Models/_Rest_/CbsGetDynamicCollateralFieldsRequest.cs
        modified:   CCBS.Models/_Rest_/CbsGetDynamicCollateralFieldsResponse.cs
        modified:   CCBS.Models/_Rest_/CbsGetDynamicCollateralListRequest.cs
        modified:   CCBS.Models/_Rest_/CbsGetDynamicCollateralListResponse.cs
        modified:   CCBS.Models/_Rest_/CbsGetDynamicCollateralTypesRequest.cs
        modified:   CCBS.Models/_Rest_/CbsGetDynamicCollateralTypesResponse.cs
        modified:   CCBS.Models/_Rest_/CbsGetListMediatorsRequest.cs
        modified:   CCBS.Models/_Rest_/CbsGetListMediatorsResponse.cs
        modified:   CCBS.Models/_Rest_/CbsGetValuerRequest.cs
        modified:   CCBS.Models/_Rest_/CbsGetValuerResponse.cs
        modified:   CCBS.Models/_Rest_/CbsInsertCollateralDetailsRequest.cs
        modified:   CCBS.Models/_Rest_/CbsInsertCollateralDetailsResponse.cs
        modified:   CCBS.Models/_Rest_/CbsInsertCollateralGeneralRequest.cs
        modified:   CCBS.Models/_Rest_/CbsInsertCollateralGeneralResponse.cs
        modified:   CCBS.Models/_Rest_/CbsInsertDynamicCollateralRequest.cs
        modified:   CCBS.Models/_Rest_/CbsInsertDynamicCollateralResponse.cs
        modified:   CCBS.Models/_Rest_/CbsInsertFileRequest.cs
        modified:   CCBS.Models/_Rest_/CbsInsertFileResponse.cs
        modified:   CCBS.Models/_Rest_/CbsInsertPropertyOwnersRequest.cs
        modified:   CCBS.Models/_Rest_/CbsInsertPropertyOwnersResponse.cs
        modified:   CCBS.Models/_Rest_/CbsInsertPropertyRequest.cs
        modified:   CCBS.Models/_Rest_/CbsInsertPropertyResponse.cs
        modified:   CCBS.Models/_Rest_/CbsInsertPropertyValuationRequest.cs
        modified:   CCBS.Models/_Rest_/CbsInsertPropertyValuationResponse.cs
        modified:   CCBS.Models/_Rest_/CbsInsertPropertyValuersRequest.cs
        modified:   CCBS.Models/_Rest_/CbsInsertPropertyValuersResponse.cs
        modified:   CCBS.Models/_Rest_/CbsInsertValuerRequest.cs
        modified:   CCBS.Models/_Rest_/CbsInsertValuerResponse.cs
        modified:   CCBS.Models/_Rest_/CbsInstantLoanRequest.cs
        modified:   CCBS.Models/_Rest_/CbsInstantLoanResponse.cs
        modified:   CCBS.Models/_Rest_/CbsInsuranceForecastRequest.cs
        modified:   CCBS.Models/_Rest_/CbsInsuranceForecastResponse.cs
        modified:   CCBS.Models/_Rest_/CbsLoanAccountForecastRequest.cs
        modified:   CCBS.Models/_Rest_/CbsLoanAccountForecastResponse.cs
        modified:   CCBS.Models/_Rest_/CbsLoanCalculatorRequest.cs
        modified:   CCBS.Models/_Rest_/CbsLoanCalculatorResponse.cs
        modified:   CCBS.Models/_Rest_/CbsLoanMoratoriumRequest.cs
        modified:   CCBS.Models/_Rest_/CbsLoanMoratoriumResponse.cs
        modified:   CCBS.Models/_Rest_/CbsLoanVariationRequest.cs
        modified:   CCBS.Models/_Rest_/CbsLoanVariationResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRepaymentModeRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRepaymentModeResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetLinePropertyValuationRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetLinePropertyValuationResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveAccountStatisticRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveAccountStatisticResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveAgreementRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveAgreementResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveAllPropertiesRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveAllPropertiesResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveBBFRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveBBFResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveCollateralDetailsRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveCollateralDetailsResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveCollateralGeneralRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveCollateralGeneralResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveDynamicCollateralRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveDynamicCollateralResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveDynamicCustomerFormRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveDynamicCustomerFormResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveFileRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveFileResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveFilesRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveFilesResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveGuaranteeAmountRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveGuaranteeAmountResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveInsuranceRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveInsuranceResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveLimitsInformationRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveLimitsInformationResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveLoanWithTopupRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveLoanWithTopupResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveMediatorsRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveMediatorsResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveMemberMessageRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveMemberMessageResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveMembersRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveMembersResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrievePropertyOwnersRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrievePropertyOwnersResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrievePropertyRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrievePropertyResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrievePropertyValuationRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrievePropertyValuationResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrievePropertyValuersRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrievePropertyValuersResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveRepaymentModeRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveRepaymentModeResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveSaveAccountRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveSaveAccountResponse.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveValuerRequest.cs
        modified:   CCBS.Models/_Rest_/CbsRetrieveValuerResponse.cs
        modified:   CCBS.Models/_Rest_/CbsSafeDepositBoxesListRequest.cs
        modified:   CCBS.Models/_Rest_/CbsSafeDepositBoxesListResponse.cs
        modified:   CCBS.Models/_Rest_/CbsSaveScenarioWithSerNoGenRequest.cs
        modified:   CCBS.Models/_Rest_/CbsSaveScenarioWithSerNoGenResponse.cs
        modified:   CCBS.Models/_Rest_/CbsSearchPropertyRequest.cs
        modified:   CCBS.Models/_Rest_/CbsSearchPropertyResponse.cs
        modified:   CCBS.Models/_Rest_/CbsSearchSecuritiesAccountsRequest.cs
        modified:   CCBS.Models/_Rest_/CbsSearchSecuritiesAccountsResponse.cs
        modified:   CCBS.Models/_Rest_/CbsSearchValuerRequest.cs
        modified:   CCBS.Models/_Rest_/CbsSearchValuerResponse.cs
        modified:   CCBS.Models/_Rest_/CbsSetAgreementLimitRequest.cs
        modified:   CCBS.Models/_Rest_/CbsSetAgreementLimitResponse.cs
        modified:   CCBS.Models/_Rest_/CbsSetBusinessDateRequest.cs
        modified:   CCBS.Models/_Rest_/CbsSetBusinessDateResponse.cs
        modified:   CCBS.Models/_Rest_/CbsShareTransferRequest.cs
        modified:   CCBS.Models/_Rest_/CbsShareTransferResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateAgreementBeneficiaryRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateAgreementBeneficiaryResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateAgreementGuarrantorRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateAgreementGuarrantorResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateAgreementRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateAgreementResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateBBFRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateBBFResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateCollateralDetailsRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateCollateralDetailsResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateCollateralGeneralRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateCollateralGeneralResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateCustomerCategoriesRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateCustomerCategoriesResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateDynamicCollateralRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateDynamicCollateralResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateDynamicCustomerFormRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateDynamicCustomerFormResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateInsuranceRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateInsuranceResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateMemberMessageRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateMemberMessageResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateMemberRegistrationRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateMemberRegistrationResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateMembershipContractualRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateMembershipContractualResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdatePropertyOwnersRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdatePropertyOwnersResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdatePropertyRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdatePropertyResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdatePropertyValuationRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdatePropertyValuationResponse.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateValuerRequest.cs
        modified:   CCBS.Models/_Rest_/CbsUpdateValuerResponse.cs
        modified:   CCBS.Models/ccbsFolders.cs
        deleted:    CCBS.Template/.config/dotnet-tools.json
        modified:   CCBS.Template/CCBS.Template.csproj
        modified:   CCBS.Template/Controllers/Partial/Other/CreateJointAccountHFB.cs
        modified:   CCBS.Template/Program.cs
        deleted:    CCBS.Template/iApplyCCBSTemplateAPI.sln
	new file:   iApplyCCBSTemplateAPI.sln
        modified:   README.TXT
        



