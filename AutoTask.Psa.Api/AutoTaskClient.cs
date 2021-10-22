using AutoTask.Psa.Api.Interfaces;
using Microsoft.Extensions.Logging;
using Refit;
using System;
using System.Net.Http;

namespace AutoTask.Psa.Api
{
	/// <summary>
	/// API client is mainly responsible for making the HTTP call to the API backend.
	/// </summary>
	public class AutoTaskClient
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="options"></param>
		public AutoTaskClient(
			AutoTaskClientOptions options,
			ILogger logger)
			: this(new HttpClient(new AuthenticatedHttpClientHandler(options, logger))
			{
				BaseAddress = new Uri($"https://webservices{options.ServerId}.autotask.net/atservicesrest")
			})
		{
		}

		public AutoTaskClient(HttpClient client)
		{
			ActionTypes = RestService.For<IActionTypesApi>(client);
			AdditionalInvoiceFieldValues = RestService.For<IAdditionalInvoiceFieldValuesApi>(client);
			ApiVersions = RestService.For<IApiVersions>(client);
			Appointments = RestService.For<IAppointmentsApi>(client);
			AttachmentInfo = RestService.For<IAttachmentInfoApi>(client);
			BillingCodes = RestService.For<IBillingCodesApi>(client);
			BillingItemApprovalLevels = RestService.For<IBillingItemApprovalLevelsApi>(client);
			BillingItems = RestService.For<IBillingItemsApi>(client);
			ChangeOrderCharges = RestService.For<IChangeOrderChargesApi>(client);
			ChangeRequestLinks = RestService.For<IChangeRequestLinksApi>(client);
			ChecklistLibraries = RestService.For<IChecklistLibrariesApi>(client);
			ChecklistLibraryChecklistItems = RestService.For<IChecklistLibraryChecklistItemsApi>(client);
			ChecklistLibraryChecklistItemsChild = RestService.For<IChecklistLibraryChecklistItemsChildApi>(client);
			ClassificationIcons = RestService.For<IClassificationIconsApi>(client);
			ClientPortalUsers = RestService.For<IClientPortalUsersApi>(client);
			ComanagedAssociations = RestService.For<IComanagedAssociationsApi>(client);
			Companies = RestService.For<ICompaniesApi>(client);
			CompanyAlerts = RestService.For<ICompanyAlertsApi>(client);
			CompanyAlertsChild = RestService.For<ICompanyAlertsChildApi>(client);
			CompanyAttachments = RestService.For<ICompanyAttachmentsApi>(client);
			CompanyAttachmentsChild = RestService.For<ICompanyAttachmentsChildApi>(client);
			CompanyContactsChild = RestService.For<ICompanyContactsChildApi>(client);
			CompanyLocations = RestService.For<ICompanyLocationsApi>(client);
			CompanyLocationsChild = RestService.For<ICompanyLocationsChildApi>(client);
			CompanyNotes = RestService.For<ICompanyNotesApi>(client);
			CompanyNotesChild = RestService.For<ICompanyNotesChildApi>(client);
			CompanySiteConfigurations = RestService.For<ICompanySiteConfigurationsApi>(client);
			CompanySiteConfigurationsChild = RestService.For<ICompanySiteConfigurationsChildApi>(client);
			CompanyTeams = RestService.For<ICompanyTeamsApi>(client);
			CompanyTeamsChild = RestService.For<ICompanyTeamsChildApi>(client);
			CompanyToDos = RestService.For<ICompanyToDosApi>(client);
			CompanyToDosChild = RestService.For<ICompanyToDosChildApi>(client);
			CompanyWebhookExcludedResources = RestService.For<ICompanyWebhookExcludedResourcesApi>(client);
			CompanyWebhookExcludedResourcesChild = RestService.For<ICompanyWebhookExcludedResourcesChildApi>(client);
			CompanyWebhookFields = RestService.For<ICompanyWebhookFieldsApi>(client);
			CompanyWebhookFieldsChild = RestService.For<ICompanyWebhookFieldsChildApi>(client);
			CompanyWebhookUdfFields = RestService.For<ICompanyWebhookUdfFieldsApi>(client);
			CompanyWebhookUdfFieldsChild = RestService.For<ICompanyWebhookUdfFieldsChildApi>(client);
			CompanyWebhooks = RestService.For<ICompanyWebhooksApi>(client);
			ConfigurationItemBillingProductAssociations = RestService.For<IConfigurationItemBillingProductAssociationsApi>(client);
			ConfigurationItemBillingProductAssociationsChild = RestService.For<IConfigurationItemBillingProductAssociationsChildApi>(client);
			ConfigurationItemCategories = RestService.For<IConfigurationItemCategoriesApi>(client);
			ConfigurationItemCategoryUdfAssociations = RestService.For<IConfigurationItemCategoryUdfAssociationsApi>(client);
			ConfigurationItemCategoryUdfAssociationsChild = RestService.For<IConfigurationItemCategoryUdfAssociationsChildApi>(client);
			ConfigurationItemExts = RestService.For<IConfigurationItemExtsApi>(client);
			ConfigurationItemNotes = RestService.For<IConfigurationItemNotesApi>(client);
			ConfigurationItemNotesChild = RestService.For<IConfigurationItemNotesChildApi>(client);
			ConfigurationItemTypes = RestService.For<IConfigurationItemTypesApi>(client);
			ConfigurationItems = RestService.For<IConfigurationItemsApi>(client);
			ContactBillingProductAssociations = RestService.For<IContactBillingProductAssociationsApi>(client);
			ContactBillingProductAssociationsChild = RestService.For<IContactBillingProductAssociationsChildApi>(client);
			ContactGroupContacts = RestService.For<IContactGroupContactsApi>(client);
			ContactGroupContactsChild = RestService.For<IContactGroupContactsChildApi>(client);
			ContactGroups = RestService.For<IContactGroupsApi>(client);
			ContactWebhookExcludedResources = RestService.For<IContactWebhookExcludedResourcesApi>(client);
			ContactWebhookExcludedResourcesChild = RestService.For<IContactWebhookExcludedResourcesChildApi>(client);
			ContactWebhookFields = RestService.For<IContactWebhookFieldsApi>(client);
			ContactWebhookFieldsChild = RestService.For<IContactWebhookFieldsChildApi>(client);
			ContactWebhookUdfFields = RestService.For<IContactWebhookUdfFieldsApi>(client);
			ContactWebhookUdfFieldsChild = RestService.For<IContactWebhookUdfFieldsChildApi>(client);
			ContactWebhooks = RestService.For<IContactWebhooksApi>(client);
			Contacts = RestService.For<IContactsApi>(client);
			ContractBillingRules = RestService.For<IContractBillingRulesApi>(client);
			ContractBillingRulesChild = RestService.For<IContractBillingRulesChildApi>(client);
			ContractBlockHourFactors = RestService.For<IContractBlockHourFactorsApi>(client);
			ContractBlockHourFactorsChild = RestService.For<IContractBlockHourFactorsChildApi>(client);
			ContractBlocks = RestService.For<IContractBlocksApi>(client);
			ContractBlocksChild = RestService.For<IContractBlocksChildApi>(client);
			ContractCharges = RestService.For<IContractChargesApi>(client);
			ContractChargesChild = RestService.For<IContractChargesChildApi>(client);
			ContractExclusionBillingCodes = RestService.For<IContractExclusionBillingCodesApi>(client);
			ContractExclusionBillingCodesChild = RestService.For<IContractExclusionBillingCodesChildApi>(client);
			ContractExclusionRoles = RestService.For<IContractExclusionRolesApi>(client);
			ContractExclusionRolesChild = RestService.For<IContractExclusionRolesChildApi>(client);
			ContractExclusionSetExcludedRoles = RestService.For<IContractExclusionSetExcludedRolesApi>(client);
			ContractExclusionSetExcludedRolesChild = RestService.For<IContractExclusionSetExcludedRolesChildApi>(client);
			ContractExclusionSetExcludedWorkTypes = RestService.For<IContractExclusionSetExcludedWorkTypesApi>(client);
			ContractExclusionSetExcludedWorkTypesChild = RestService.For<IContractExclusionSetExcludedWorkTypesChildApi>(client);
			ContractExclusionSets = RestService.For<IContractExclusionSetsApi>(client);
			ContractMilestones = RestService.For<IContractMilestonesApi>(client);
			ContractMilestonesChild = RestService.For<IContractMilestonesChildApi>(client);
			ContractNotes = RestService.For<IContractNotesApi>(client);
			ContractNotesChild = RestService.For<IContractNotesChildApi>(client);
			ContractRates = RestService.For<IContractRatesApi>(client);
			ContractRatesChild = RestService.For<IContractRatesChildApi>(client);
			ContractRetainers = RestService.For<IContractRetainersApi>(client);
			ContractRetainersChild = RestService.For<IContractRetainersChildApi>(client);
			ContractRoleCosts = RestService.For<IContractRoleCostsApi>(client);
			ContractRoleCostsChild = RestService.For<IContractRoleCostsChildApi>(client);
			ContractServiceAdjustments = RestService.For<IContractServiceAdjustmentsApi>(client);
			ContractServiceAdjustmentsChild = RestService.For<IContractServiceAdjustmentsChildApi>(client);
			ContractServiceBundleAdjustments = RestService.For<IContractServiceBundleAdjustmentsApi>(client);
			ContractServiceBundleAdjustmentsChild = RestService.For<IContractServiceBundleAdjustmentsChildApi>(client);
			ContractServiceBundleUnits = RestService.For<IContractServiceBundleUnitsApi>(client);
			ContractServiceBundleUnitsChild = RestService.For<IContractServiceBundleUnitsChildApi>(client);
			ContractServiceBundles = RestService.For<IContractServiceBundlesApi>(client);
			ContractServiceBundlesChild = RestService.For<IContractServiceBundlesChildApi>(client);
			ContractServiceUnits = RestService.For<IContractServiceUnitsApi>(client);
			ContractServiceUnitsChild = RestService.For<IContractServiceUnitsChildApi>(client);
			ContractServices = RestService.For<IContractServicesApi>(client);
			ContractServicesChild = RestService.For<IContractServicesChildApi>(client);
			ContractTicketPurchases = RestService.For<IContractTicketPurchasesApi>(client);
			ContractTicketPurchasesChild = RestService.For<IContractTicketPurchasesChildApi>(client);
			Contracts = RestService.For<IContractsApi>(client);
			Countries = RestService.For<ICountriesApi>(client);
			Currencies = RestService.For<ICurrenciesApi>(client);
			Departments = RestService.For<IDepartmentsApi>(client);
			ExpenseItems = RestService.For<IExpenseItemsApi>(client);
			ExpenseItemsChild = RestService.For<IExpenseItemsChildApi>(client);
			ExpenseReports = RestService.For<IExpenseReportsApi>(client);
			HolidaySets = RestService.For<IHolidaySetsApi>(client);
			Holidays = RestService.For<IHolidaysApi>(client);
			HolidaysChild = RestService.For<IHolidaysChildApi>(client);
			InternalLocationWithBusinessHours = RestService.For<IInternalLocationWithBusinessHoursApi>(client);
			InternalLocations = RestService.For<IInternalLocationsApi>(client);
			InventoryItemSerialNumbers = RestService.For<IInventoryItemSerialNumbersApi>(client);
			InventoryItemSerialNumbersChild = RestService.For<IInventoryItemSerialNumbersChildApi>(client);
			InventoryItems = RestService.For<IInventoryItemsApi>(client);
			InventoryLocations = RestService.For<IInventoryLocationsApi>(client);
			InventoryTransfers = RestService.For<IInventoryTransfersApi>(client);
			InvoiceTemplates = RestService.For<IInvoiceTemplatesApi>(client);
			Invoices = RestService.For<IInvoicesApi>(client);
			MetadataApiIntegration = RestService.For<IMetadataApiIntegrationApi>(client);
			NotificationHistory = RestService.For<INotificationHistoryApi>(client);
			Opportunities = RestService.For<IOpportunitiesApi>(client);
			OpportunityAttachments = RestService.For<IOpportunityAttachmentsApi>(client);
			OpportunityAttachmentsChild = RestService.For<IOpportunityAttachmentsChildApi>(client);
			OrganizationalLevel1 = RestService.For<IOrganizationalLevel1Api>(client);
			OrganizationalLevel2 = RestService.For<IOrganizationalLevel2Api>(client);
			OrganizationalLevelAssociation = RestService.For<IOrganizationalLevelAssociationApi>(client);
			OrganizationalResources = RestService.For<IOrganizationalResourcesApi>(client);
			OrganizationalResourcesChild = RestService.For<IOrganizationalResourcesChildApi>(client);
			PaymentTerms = RestService.For<IPaymentTermsApi>(client);
			Phases = RestService.For<IPhasesApi>(client);
			PhasesChild = RestService.For<IPhasesChildApi>(client);
			PriceListMaterialCodes = RestService.For<IPriceListMaterialCodesApi>(client);
			PriceListProductTiers = RestService.For<IPriceListProductTiersApi>(client);
			PriceListProducts = RestService.For<IPriceListProductsApi>(client);
			PriceListRoles = RestService.For<IPriceListRolesApi>(client);
			PriceListServiceBundles = RestService.For<IPriceListServiceBundlesApi>(client);
			PriceListServices = RestService.For<IPriceListServicesApi>(client);
			PriceListWorkTypeModifiers = RestService.For<IPriceListWorkTypeModifiersApi>(client);
			ProductNotes = RestService.For<IProductNotesApi>(client);
			ProductNotesChild = RestService.For<IProductNotesChildApi>(client);
			ProductTiers = RestService.For<IProductTiersApi>(client);
			ProductTiersChild = RestService.For<IProductTiersChildApi>(client);
			ProductVendors = RestService.For<IProductVendorsApi>(client);
			ProductVendorsChild = RestService.For<IProductVendorsChildApi>(client);
			Products = RestService.For<IProductsApi>(client);
			ProjectAttachments = RestService.For<IProjectAttachmentsApi>(client);
			ProjectAttachmentsChild = RestService.For<IProjectAttachmentsChildApi>(client);
			ProjectCharges = RestService.For<IProjectChargesApi>(client);
			ProjectChargesChild = RestService.For<IProjectChargesChildApi>(client);
			ProjectNotes = RestService.For<IProjectNotesApi>(client);
			ProjectNotesChild = RestService.For<IProjectNotesChildApi>(client);
			Projects = RestService.For<IProjectsApi>(client);
			PurchaseApprovals = RestService.For<IPurchaseApprovalsApi>(client);
			PurchaseOrderItemReceiving = RestService.For<IPurchaseOrderItemReceivingApi>(client);
			PurchaseOrderItemReceivingChild = RestService.For<IPurchaseOrderItemReceivingChildApi>(client);
			PurchaseOrderItems = RestService.For<IPurchaseOrderItemsApi>(client);
			PurchaseOrderItemsChild = RestService.For<IPurchaseOrderItemsChildApi>(client);
			PurchaseOrders = RestService.For<IPurchaseOrdersApi>(client);
			QuoteItems = RestService.For<IQuoteItemsApi>(client);
			QuoteItemsChild = RestService.For<IQuoteItemsChildApi>(client);
			QuoteLocations = RestService.For<IQuoteLocationsApi>(client);
			QuoteTemplates = RestService.For<IQuoteTemplatesApi>(client);
			Quotes = RestService.For<IQuotesApi>(client);
			ResourceRoleDepartments = RestService.For<IResourceRoleDepartmentsApi>(client);
			ResourceRoleDepartmentsChild = RestService.For<IResourceRoleDepartmentsChildApi>(client);
			ResourceRoleQueues = RestService.For<IResourceRoleQueuesApi>(client);
			ResourceRoleQueuesChild = RestService.For<IResourceRoleQueuesChildApi>(client);
			ResourceRoles = RestService.For<IResourceRolesApi>(client);
			ResourceRolesChild = RestService.For<IResourceRolesChildApi>(client);
			ResourceServiceDeskRoles = RestService.For<IResourceServiceDeskRolesApi>(client);
			ResourceServiceDeskRolesChild = RestService.For<IResourceServiceDeskRolesChildApi>(client);
			ResourceSkills = RestService.For<IResourceSkillsApi>(client);
			ResourceSkillsChild = RestService.For<IResourceSkillsChildApi>(client);
			Resources = RestService.For<IResourcesApi>(client);
			Roles = RestService.For<IRolesApi>(client);
			SalesOrders = RestService.For<ISalesOrdersApi>(client);
			SalesOrdersChild = RestService.For<ISalesOrdersChildApi>(client);
			ServiceBundleServices = RestService.For<IServiceBundleServicesApi>(client);
			ServiceBundleServicesChild = RestService.For<IServiceBundleServicesChildApi>(client);
			ServiceBundles = RestService.For<IServiceBundlesApi>(client);
			ServiceCallTaskResources = RestService.For<IServiceCallTaskResourcesApi>(client);
			ServiceCallTaskResourcesChild = RestService.For<IServiceCallTaskResourcesChildApi>(client);
			ServiceCallTasks = RestService.For<IServiceCallTasksApi>(client);
			ServiceCallTasksChild = RestService.For<IServiceCallTasksChildApi>(client);
			ServiceCallTicketResources = RestService.For<IServiceCallTicketResourcesApi>(client);
			ServiceCallTicketResourcesChild = RestService.For<IServiceCallTicketResourcesChildApi>(client);
			ServiceCallTickets = RestService.For<IServiceCallTicketsApi>(client);
			ServiceCallTicketsChild = RestService.For<IServiceCallTicketsChildApi>(client);
			ServiceCalls = RestService.For<IServiceCallsApi>(client);
			ServiceLevelAgreementResults = RestService.For<IServiceLevelAgreementResultsApi>(client);
			ServiceLevelAgreementResultsChild = RestService.For<IServiceLevelAgreementResultsChildApi>(client);
			Services = RestService.For<IServicesApi>(client);
			ShippingTypes = RestService.For<IShippingTypesApi>(client);
			Skills = RestService.For<ISkillsApi>(client);
			SubscriptionPeriods = RestService.For<ISubscriptionPeriodsApi>(client);
			SubscriptionPeriodsChild = RestService.For<ISubscriptionPeriodsChildApi>(client);
			Subscriptions = RestService.For<ISubscriptionsApi>(client);
			SurveyResults = RestService.For<ISurveyResultsApi>(client);
			Surveys = RestService.For<ISurveysApi>(client);
			TaskAttachments = RestService.For<ITaskAttachmentsApi>(client);
			TaskAttachmentsChild = RestService.For<ITaskAttachmentsChildApi>(client);
			TaskNotes = RestService.For<ITaskNotesApi>(client);
			TaskNotesChild = RestService.For<ITaskNotesChildApi>(client);
			TaskPredecessors = RestService.For<ITaskPredecessorsApi>(client);
			TaskPredecessorsChild = RestService.For<ITaskPredecessorsChildApi>(client);
			TaskSecondaryResources = RestService.For<ITaskSecondaryResourcesApi>(client);
			TaskSecondaryResourcesChild = RestService.For<ITaskSecondaryResourcesChildApi>(client);
			Tasks = RestService.For<ITasksApi>(client);
			TasksChild = RestService.For<ITasksChildApi>(client);
			TaxCategories = RestService.For<ITaxCategoriesApi>(client);
			TaxRegions = RestService.For<ITaxRegionsApi>(client);
			Taxes = RestService.For<ITaxesApi>(client);
			ThresholdApiIntegration = RestService.For<IThresholdApiIntegrationApi>(client);
			TicketAdditionalConfigurationItems = RestService.For<ITicketAdditionalConfigurationItemsApi>(client);
			TicketAdditionalConfigurationItemsChild = RestService.For<ITicketAdditionalConfigurationItemsChildApi>(client);
			TicketAdditionalContacts = RestService.For<ITicketAdditionalContactsApi>(client);
			TicketAdditionalContactsChild = RestService.For<ITicketAdditionalContactsChildApi>(client);
			TicketAttachments = RestService.For<ITicketAttachmentsApi>(client);
			TicketAttachmentsChild = RestService.For<ITicketAttachmentsChildApi>(client);
			TicketCategories = RestService.For<ITicketCategoriesApi>(client);
			TicketCategoryFieldDefaults = RestService.For<ITicketCategoryFieldDefaultsApi>(client);
			TicketCategoryFieldDefaultsChild = RestService.For<ITicketCategoryFieldDefaultsChildApi>(client);
			TicketChangeRequestApprovals = RestService.For<ITicketChangeRequestApprovalsApi>(client);
			TicketChangeRequestApprovalsChild = RestService.For<ITicketChangeRequestApprovalsChildApi>(client);
			TicketCharges = RestService.For<ITicketChargesApi>(client);
			TicketChargesChild = RestService.For<ITicketChargesChildApi>(client);
			TicketChecklistItems = RestService.For<ITicketChecklistItemsApi>(client);
			TicketChecklistItemsChild = RestService.For<ITicketChecklistItemsChildApi>(client);
			TicketChecklistLibraries = RestService.For<ITicketChecklistLibrariesApi>(client);
			TicketChecklistLibrariesChild = RestService.For<ITicketChecklistLibrariesChildApi>(client);
			TicketHistory = RestService.For<ITicketHistoryApi>(client);
			TicketNotes = RestService.For<ITicketNotesApi>(client);
			TicketNotesChild = RestService.For<ITicketNotesChildApi>(client);
			TicketRmaCredits = RestService.For<ITicketRmaCreditsApi>(client);
			TicketRmaCreditsChild = RestService.For<ITicketRmaCreditsChildApi>(client);
			TicketSecondaryResources = RestService.For<ITicketSecondaryResourcesApi>(client);
			TicketSecondaryResourcesChild = RestService.For<ITicketSecondaryResourcesChildApi>(client);
			Tickets = RestService.For<ITicketsApi>(client);
			TimeEntries = RestService.For<ITimeEntriesApi>(client);
			UserDefinedFieldDefinitions = RestService.For<IUserDefinedFieldDefinitionsApi>(client);
			UserDefinedFieldListItems = RestService.For<IUserDefinedFieldListItemsApi>(client);
			UserDefinedFieldListItemsChild = RestService.For<IUserDefinedFieldListItemsChildApi>(client);
			WebhookEventErrorLogs = RestService.For<IWebhookEventErrorLogsApi>(client);
			WorkTypeModifiers = RestService.For<IWorkTypeModifiersApi>(client);
			ZoneInformationApiIntegration = RestService.For<IZoneInformationApiIntegrationApi>(client);
		}

		/// <inheritdoc />
		public IActionTypesApi ActionTypes { get; }

		/// <inheritdoc />
		public IAdditionalInvoiceFieldValuesApi AdditionalInvoiceFieldValues { get; }

		/// <inheritdoc />
		public IApiVersions ApiVersions { get; }

		/// <inheritdoc />
		public IAppointmentsApi Appointments { get; }

		/// <inheritdoc />
		public IAttachmentInfoApi AttachmentInfo { get; }

		/// <inheritdoc />
		public IBillingCodesApi BillingCodes { get; }

		/// <inheritdoc />
		public IBillingItemApprovalLevelsApi BillingItemApprovalLevels { get; }

		/// <inheritdoc />
		public IBillingItemsApi BillingItems { get; }

		/// <inheritdoc />
		public IChangeOrderChargesApi ChangeOrderCharges { get; }

		/// <inheritdoc />
		public IChangeRequestLinksApi ChangeRequestLinks { get; }

		/// <inheritdoc />
		public IChecklistLibrariesApi ChecklistLibraries { get; }

		/// <inheritdoc />
		public IChecklistLibraryChecklistItemsApi ChecklistLibraryChecklistItems { get; }

		/// <inheritdoc />
		public IChecklistLibraryChecklistItemsChildApi ChecklistLibraryChecklistItemsChild { get; }

		/// <inheritdoc />
		public IClassificationIconsApi ClassificationIcons { get; }

		/// <inheritdoc />
		public IClientPortalUsersApi ClientPortalUsers { get; }

		/// <inheritdoc />
		public IComanagedAssociationsApi ComanagedAssociations { get; }

		/// <inheritdoc />
		public ICompaniesApi Companies { get; }

		/// <inheritdoc />
		public ICompanyAlertsApi CompanyAlerts { get; }

		/// <inheritdoc />
		public ICompanyAlertsChildApi CompanyAlertsChild { get; }

		/// <inheritdoc />
		public ICompanyAttachmentsApi CompanyAttachments { get; }

		/// <inheritdoc />
		public ICompanyAttachmentsChildApi CompanyAttachmentsChild { get; }

		/// <inheritdoc />
		public ICompanyContactsChildApi CompanyContactsChild { get; }

		/// <inheritdoc />
		public ICompanyLocationsApi CompanyLocations { get; }

		/// <inheritdoc />
		public ICompanyLocationsChildApi CompanyLocationsChild { get; }

		/// <inheritdoc />
		public ICompanyNotesApi CompanyNotes { get; }

		/// <inheritdoc />
		public ICompanyNotesChildApi CompanyNotesChild { get; }

		/// <inheritdoc />
		public ICompanySiteConfigurationsApi CompanySiteConfigurations { get; }

		/// <inheritdoc />
		public ICompanySiteConfigurationsChildApi CompanySiteConfigurationsChild { get; }

		/// <inheritdoc />
		public ICompanyTeamsApi CompanyTeams { get; }

		/// <inheritdoc />
		public ICompanyTeamsChildApi CompanyTeamsChild { get; }

		/// <inheritdoc />
		public ICompanyToDosApi CompanyToDos { get; }

		/// <inheritdoc />
		public ICompanyToDosChildApi CompanyToDosChild { get; }

		/// <inheritdoc />
		public ICompanyWebhookExcludedResourcesApi CompanyWebhookExcludedResources { get; }

		/// <inheritdoc />
		public ICompanyWebhookExcludedResourcesChildApi CompanyWebhookExcludedResourcesChild { get; }

		/// <inheritdoc />
		public ICompanyWebhookFieldsApi CompanyWebhookFields { get; }

		/// <inheritdoc />
		public ICompanyWebhookFieldsChildApi CompanyWebhookFieldsChild { get; }

		/// <inheritdoc />
		public ICompanyWebhookUdfFieldsApi CompanyWebhookUdfFields { get; }

		/// <inheritdoc />
		public ICompanyWebhookUdfFieldsChildApi CompanyWebhookUdfFieldsChild { get; }

		/// <inheritdoc />
		public ICompanyWebhooksApi CompanyWebhooks { get; }

		/// <inheritdoc />
		public IConfigurationItemBillingProductAssociationsApi ConfigurationItemBillingProductAssociations { get; }

		/// <inheritdoc />
		public IConfigurationItemBillingProductAssociationsChildApi ConfigurationItemBillingProductAssociationsChild { get; }

		/// <inheritdoc />
		public IConfigurationItemCategoriesApi ConfigurationItemCategories { get; }

		/// <inheritdoc />
		public IConfigurationItemCategoryUdfAssociationsApi ConfigurationItemCategoryUdfAssociations { get; }

		/// <inheritdoc />
		public IConfigurationItemCategoryUdfAssociationsChildApi ConfigurationItemCategoryUdfAssociationsChild { get; }

		/// <inheritdoc />
		public IConfigurationItemExtsApi ConfigurationItemExts { get; }

		/// <inheritdoc />
		public IConfigurationItemNotesApi ConfigurationItemNotes { get; }

		/// <inheritdoc />
		public IConfigurationItemNotesChildApi ConfigurationItemNotesChild { get; }

		/// <inheritdoc />
		public IConfigurationItemTypesApi ConfigurationItemTypes { get; }

		/// <inheritdoc />
		public IConfigurationItemsApi ConfigurationItems { get; }

		/// <inheritdoc />
		public IContactBillingProductAssociationsApi ContactBillingProductAssociations { get; }

		/// <inheritdoc />
		public IContactBillingProductAssociationsChildApi ContactBillingProductAssociationsChild { get; }

		/// <inheritdoc />
		public IContactGroupContactsApi ContactGroupContacts { get; }

		/// <inheritdoc />
		public IContactGroupContactsChildApi ContactGroupContactsChild { get; }

		/// <inheritdoc />
		public IContactGroupsApi ContactGroups { get; }

		/// <inheritdoc />
		public IContactWebhookExcludedResourcesApi ContactWebhookExcludedResources { get; }

		/// <inheritdoc />
		public IContactWebhookExcludedResourcesChildApi ContactWebhookExcludedResourcesChild { get; }

		/// <inheritdoc />
		public IContactWebhookFieldsApi ContactWebhookFields { get; }

		/// <inheritdoc />
		public IContactWebhookFieldsChildApi ContactWebhookFieldsChild { get; }

		/// <inheritdoc />
		public IContactWebhookUdfFieldsApi ContactWebhookUdfFields { get; }

		/// <inheritdoc />
		public IContactWebhookUdfFieldsChildApi ContactWebhookUdfFieldsChild { get; }

		/// <inheritdoc />
		public IContactWebhooksApi ContactWebhooks { get; }

		/// <inheritdoc />
		public IContactsApi Contacts { get; }

		/// <inheritdoc />
		public IContractBillingRulesApi ContractBillingRules { get; }

		/// <inheritdoc />
		public IContractBillingRulesChildApi ContractBillingRulesChild { get; }

		/// <inheritdoc />
		public IContractBlockHourFactorsApi ContractBlockHourFactors { get; }

		/// <inheritdoc />
		public IContractBlockHourFactorsChildApi ContractBlockHourFactorsChild { get; }

		/// <inheritdoc />
		public IContractBlocksApi ContractBlocks { get; }

		/// <inheritdoc />
		public IContractBlocksChildApi ContractBlocksChild { get; }

		/// <inheritdoc />
		public IContractChargesApi ContractCharges { get; }

		/// <inheritdoc />
		public IContractChargesChildApi ContractChargesChild { get; }

		/// <inheritdoc />
		public IContractExclusionBillingCodesApi ContractExclusionBillingCodes { get; }

		/// <inheritdoc />
		public IContractExclusionBillingCodesChildApi ContractExclusionBillingCodesChild { get; }

		/// <inheritdoc />
		public IContractExclusionRolesApi ContractExclusionRoles { get; }

		/// <inheritdoc />
		public IContractExclusionRolesChildApi ContractExclusionRolesChild { get; }

		/// <inheritdoc />
		public IContractExclusionSetExcludedRolesApi ContractExclusionSetExcludedRoles { get; }

		/// <inheritdoc />
		public IContractExclusionSetExcludedRolesChildApi ContractExclusionSetExcludedRolesChild { get; }

		/// <inheritdoc />
		public IContractExclusionSetExcludedWorkTypesApi ContractExclusionSetExcludedWorkTypes { get; }

		/// <inheritdoc />
		public IContractExclusionSetExcludedWorkTypesChildApi ContractExclusionSetExcludedWorkTypesChild { get; }

		/// <inheritdoc />
		public IContractExclusionSetsApi ContractExclusionSets { get; }

		/// <inheritdoc />
		public IContractMilestonesApi ContractMilestones { get; }

		/// <inheritdoc />
		public IContractMilestonesChildApi ContractMilestonesChild { get; }

		/// <inheritdoc />
		public IContractNotesApi ContractNotes { get; }

		/// <inheritdoc />
		public IContractNotesChildApi ContractNotesChild { get; }

		/// <inheritdoc />
		public IContractRatesApi ContractRates { get; }

		/// <inheritdoc />
		public IContractRatesChildApi ContractRatesChild { get; }

		/// <inheritdoc />
		public IContractRetainersApi ContractRetainers { get; }

		/// <inheritdoc />
		public IContractRetainersChildApi ContractRetainersChild { get; }

		/// <inheritdoc />
		public IContractRoleCostsApi ContractRoleCosts { get; }

		/// <inheritdoc />
		public IContractRoleCostsChildApi ContractRoleCostsChild { get; }

		/// <inheritdoc />
		public IContractServiceAdjustmentsApi ContractServiceAdjustments { get; }

		/// <inheritdoc />
		public IContractServiceAdjustmentsChildApi ContractServiceAdjustmentsChild { get; }

		/// <inheritdoc />
		public IContractServiceBundleAdjustmentsApi ContractServiceBundleAdjustments { get; }

		/// <inheritdoc />
		public IContractServiceBundleAdjustmentsChildApi ContractServiceBundleAdjustmentsChild { get; }

		/// <inheritdoc />
		public IContractServiceBundleUnitsApi ContractServiceBundleUnits { get; }

		/// <inheritdoc />
		public IContractServiceBundleUnitsChildApi ContractServiceBundleUnitsChild { get; }

		/// <inheritdoc />
		public IContractServiceBundlesApi ContractServiceBundles { get; }

		/// <inheritdoc />
		public IContractServiceBundlesChildApi ContractServiceBundlesChild { get; }

		/// <inheritdoc />
		public IContractServiceUnitsApi ContractServiceUnits { get; }

		/// <inheritdoc />
		public IContractServiceUnitsChildApi ContractServiceUnitsChild { get; }

		/// <inheritdoc />
		public IContractServicesApi ContractServices { get; }

		/// <inheritdoc />
		public IContractServicesChildApi ContractServicesChild { get; }

		/// <inheritdoc />
		public IContractTicketPurchasesApi ContractTicketPurchases { get; }

		/// <inheritdoc />
		public IContractTicketPurchasesChildApi ContractTicketPurchasesChild { get; }

		/// <inheritdoc />
		public IContractsApi Contracts { get; }

		/// <inheritdoc />
		public ICountriesApi Countries { get; }

		/// <inheritdoc />
		public ICurrenciesApi Currencies { get; }

		/// <inheritdoc />
		public IDepartmentsApi Departments { get; }

		/// <inheritdoc />
		public IExpenseItemsApi ExpenseItems { get; }

		/// <inheritdoc />
		public IExpenseItemsChildApi ExpenseItemsChild { get; }

		/// <inheritdoc />
		public IExpenseReportsApi ExpenseReports { get; }

		/// <inheritdoc />
		public IHolidaySetsApi HolidaySets { get; }

		/// <inheritdoc />
		public IHolidaysApi Holidays { get; }

		/// <inheritdoc />
		public IHolidaysChildApi HolidaysChild { get; }

		/// <inheritdoc />
		public IInternalLocationWithBusinessHoursApi InternalLocationWithBusinessHours { get; }

		/// <inheritdoc />
		public IInternalLocationsApi InternalLocations { get; }

		/// <inheritdoc />
		public IInventoryItemSerialNumbersApi InventoryItemSerialNumbers { get; }

		/// <inheritdoc />
		public IInventoryItemSerialNumbersChildApi InventoryItemSerialNumbersChild { get; }

		/// <inheritdoc />
		public IInventoryItemsApi InventoryItems { get; }

		/// <inheritdoc />
		public IInventoryLocationsApi InventoryLocations { get; }

		/// <inheritdoc />
		public IInventoryTransfersApi InventoryTransfers { get; }

		/// <inheritdoc />
		public IInvoiceTemplatesApi InvoiceTemplates { get; }

		/// <inheritdoc />
		public IInvoicesApi Invoices { get; }

		/// <inheritdoc />
		public IMetadataApiIntegrationApi MetadataApiIntegration { get; }

		/// <inheritdoc />
		public INotificationHistoryApi NotificationHistory { get; }

		/// <inheritdoc />
		public IOpportunitiesApi Opportunities { get; }

		/// <inheritdoc />
		public IOpportunityAttachmentsApi OpportunityAttachments { get; }

		/// <inheritdoc />
		public IOpportunityAttachmentsChildApi OpportunityAttachmentsChild { get; }

		/// <inheritdoc />
		public IOrganizationalLevel1Api OrganizationalLevel1 { get; }

		/// <inheritdoc />
		public IOrganizationalLevel2Api OrganizationalLevel2 { get; }

		/// <inheritdoc />
		public IOrganizationalLevelAssociationApi OrganizationalLevelAssociation { get; }

		/// <inheritdoc />
		public IOrganizationalResourcesApi OrganizationalResources { get; }

		/// <inheritdoc />
		public IOrganizationalResourcesChildApi OrganizationalResourcesChild { get; }

		/// <inheritdoc />
		public IPaymentTermsApi PaymentTerms { get; }

		/// <inheritdoc />
		public IPhasesApi Phases { get; }

		/// <inheritdoc />
		public IPhasesChildApi PhasesChild { get; }

		/// <inheritdoc />
		public IPriceListMaterialCodesApi PriceListMaterialCodes { get; }

		/// <inheritdoc />
		public IPriceListProductTiersApi PriceListProductTiers { get; }

		/// <inheritdoc />
		public IPriceListProductsApi PriceListProducts { get; }

		/// <inheritdoc />
		public IPriceListRolesApi PriceListRoles { get; }

		/// <inheritdoc />
		public IPriceListServiceBundlesApi PriceListServiceBundles { get; }

		/// <inheritdoc />
		public IPriceListServicesApi PriceListServices { get; }

		/// <inheritdoc />
		public IPriceListWorkTypeModifiersApi PriceListWorkTypeModifiers { get; }

		/// <inheritdoc />
		public IProductNotesApi ProductNotes { get; }

		/// <inheritdoc />
		public IProductNotesChildApi ProductNotesChild { get; }

		/// <inheritdoc />
		public IProductTiersApi ProductTiers { get; }

		/// <inheritdoc />
		public IProductTiersChildApi ProductTiersChild { get; }

		/// <inheritdoc />
		public IProductVendorsApi ProductVendors { get; }

		/// <inheritdoc />
		public IProductVendorsChildApi ProductVendorsChild { get; }

		/// <inheritdoc />
		public IProductsApi Products { get; }

		/// <inheritdoc />
		public IProjectAttachmentsApi ProjectAttachments { get; }

		/// <inheritdoc />
		public IProjectAttachmentsChildApi ProjectAttachmentsChild { get; }

		/// <inheritdoc />
		public IProjectChargesApi ProjectCharges { get; }

		/// <inheritdoc />
		public IProjectChargesChildApi ProjectChargesChild { get; }

		/// <inheritdoc />
		public IProjectNotesApi ProjectNotes { get; }

		/// <inheritdoc />
		public IProjectNotesChildApi ProjectNotesChild { get; }

		/// <inheritdoc />
		public IProjectsApi Projects { get; }

		/// <inheritdoc />
		public IPurchaseApprovalsApi PurchaseApprovals { get; }

		/// <inheritdoc />
		public IPurchaseOrderItemReceivingApi PurchaseOrderItemReceiving { get; }

		/// <inheritdoc />
		public IPurchaseOrderItemReceivingChildApi PurchaseOrderItemReceivingChild { get; }

		/// <inheritdoc />
		public IPurchaseOrderItemsApi PurchaseOrderItems { get; }

		/// <inheritdoc />
		public IPurchaseOrderItemsChildApi PurchaseOrderItemsChild { get; }

		/// <inheritdoc />
		public IPurchaseOrdersApi PurchaseOrders { get; }

		/// <inheritdoc />
		public IQuoteItemsApi QuoteItems { get; }

		/// <inheritdoc />
		public IQuoteItemsChildApi QuoteItemsChild { get; }

		/// <inheritdoc />
		public IQuoteLocationsApi QuoteLocations { get; }

		/// <inheritdoc />
		public IQuoteTemplatesApi QuoteTemplates { get; }

		/// <inheritdoc />
		public IQuotesApi Quotes { get; }

		/// <inheritdoc />
		public IResourceRoleDepartmentsApi ResourceRoleDepartments { get; }

		/// <inheritdoc />
		public IResourceRoleDepartmentsChildApi ResourceRoleDepartmentsChild { get; }

		/// <inheritdoc />
		public IResourceRoleQueuesApi ResourceRoleQueues { get; }

		/// <inheritdoc />
		public IResourceRoleQueuesChildApi ResourceRoleQueuesChild { get; }

		/// <inheritdoc />
		public IResourceRolesApi ResourceRoles { get; }

		/// <inheritdoc />
		public IResourceRolesChildApi ResourceRolesChild { get; }

		/// <inheritdoc />
		public IResourceServiceDeskRolesApi ResourceServiceDeskRoles { get; }

		/// <inheritdoc />
		public IResourceServiceDeskRolesChildApi ResourceServiceDeskRolesChild { get; }

		/// <inheritdoc />
		public IResourceSkillsApi ResourceSkills { get; }

		/// <inheritdoc />
		public IResourceSkillsChildApi ResourceSkillsChild { get; }

		/// <inheritdoc />
		public IResourcesApi Resources { get; }

		/// <inheritdoc />
		public IRolesApi Roles { get; }

		/// <inheritdoc />
		public ISalesOrdersApi SalesOrders { get; }

		/// <inheritdoc />
		public ISalesOrdersChildApi SalesOrdersChild { get; }

		/// <inheritdoc />
		public IServiceBundleServicesApi ServiceBundleServices { get; }

		/// <inheritdoc />
		public IServiceBundleServicesChildApi ServiceBundleServicesChild { get; }

		/// <inheritdoc />
		public IServiceBundlesApi ServiceBundles { get; }

		/// <inheritdoc />
		public IServiceCallTaskResourcesApi ServiceCallTaskResources { get; }

		/// <inheritdoc />
		public IServiceCallTaskResourcesChildApi ServiceCallTaskResourcesChild { get; }

		/// <inheritdoc />
		public IServiceCallTasksApi ServiceCallTasks { get; }

		/// <inheritdoc />
		public IServiceCallTasksChildApi ServiceCallTasksChild { get; }

		/// <inheritdoc />
		public IServiceCallTicketResourcesApi ServiceCallTicketResources { get; }

		/// <inheritdoc />
		public IServiceCallTicketResourcesChildApi ServiceCallTicketResourcesChild { get; }

		/// <inheritdoc />
		public IServiceCallTicketsApi ServiceCallTickets { get; }

		/// <inheritdoc />
		public IServiceCallTicketsChildApi ServiceCallTicketsChild { get; }

		/// <inheritdoc />
		public IServiceCallsApi ServiceCalls { get; }

		/// <inheritdoc />
		public IServiceLevelAgreementResultsApi ServiceLevelAgreementResults { get; }

		/// <inheritdoc />
		public IServiceLevelAgreementResultsChildApi ServiceLevelAgreementResultsChild { get; }

		/// <inheritdoc />
		public IServicesApi Services { get; }

		/// <inheritdoc />
		public IShippingTypesApi ShippingTypes { get; }

		/// <inheritdoc />
		public ISkillsApi Skills { get; }

		/// <inheritdoc />
		public ISubscriptionPeriodsApi SubscriptionPeriods { get; }

		/// <inheritdoc />
		public ISubscriptionPeriodsChildApi SubscriptionPeriodsChild { get; }

		/// <inheritdoc />
		public ISubscriptionsApi Subscriptions { get; }

		/// <inheritdoc />
		public ISurveyResultsApi SurveyResults { get; }

		/// <inheritdoc />
		public ISurveysApi Surveys { get; }

		/// <inheritdoc />
		public ITaskAttachmentsApi TaskAttachments { get; }

		/// <inheritdoc />
		public ITaskAttachmentsChildApi TaskAttachmentsChild { get; }

		/// <inheritdoc />
		public ITaskNotesApi TaskNotes { get; }

		/// <inheritdoc />
		public ITaskNotesChildApi TaskNotesChild { get; }

		/// <inheritdoc />
		public ITaskPredecessorsApi TaskPredecessors { get; }

		/// <inheritdoc />
		public ITaskPredecessorsChildApi TaskPredecessorsChild { get; }

		/// <inheritdoc />
		public ITaskSecondaryResourcesApi TaskSecondaryResources { get; }

		/// <inheritdoc />
		public ITaskSecondaryResourcesChildApi TaskSecondaryResourcesChild { get; }

		/// <inheritdoc />
		public ITasksApi Tasks { get; }

		/// <inheritdoc />
		public ITasksChildApi TasksChild { get; }

		/// <inheritdoc />
		public ITaxCategoriesApi TaxCategories { get; }

		/// <inheritdoc />
		public ITaxRegionsApi TaxRegions { get; }

		/// <inheritdoc />
		public ITaxesApi Taxes { get; }

		/// <inheritdoc />
		public IThresholdApiIntegrationApi ThresholdApiIntegration { get; }

		/// <inheritdoc />
		public ITicketAdditionalConfigurationItemsApi TicketAdditionalConfigurationItems { get; }

		/// <inheritdoc />
		public ITicketAdditionalConfigurationItemsChildApi TicketAdditionalConfigurationItemsChild { get; }

		/// <inheritdoc />
		public ITicketAdditionalContactsApi TicketAdditionalContacts { get; }

		/// <inheritdoc />
		public ITicketAdditionalContactsChildApi TicketAdditionalContactsChild { get; }

		/// <inheritdoc />
		public ITicketAttachmentsApi TicketAttachments { get; }

		/// <inheritdoc />
		public ITicketAttachmentsChildApi TicketAttachmentsChild { get; }

		/// <inheritdoc />
		public ITicketCategoriesApi TicketCategories { get; }

		/// <inheritdoc />
		public ITicketCategoryFieldDefaultsApi TicketCategoryFieldDefaults { get; }

		/// <inheritdoc />
		public ITicketCategoryFieldDefaultsChildApi TicketCategoryFieldDefaultsChild { get; }

		/// <inheritdoc />
		public ITicketChangeRequestApprovalsApi TicketChangeRequestApprovals { get; }

		/// <inheritdoc />
		public ITicketChangeRequestApprovalsChildApi TicketChangeRequestApprovalsChild { get; }

		/// <inheritdoc />
		public ITicketChargesApi TicketCharges { get; }

		/// <inheritdoc />
		public ITicketChargesChildApi TicketChargesChild { get; }

		/// <inheritdoc />
		public ITicketChecklistItemsApi TicketChecklistItems { get; }

		/// <inheritdoc />
		public ITicketChecklistItemsChildApi TicketChecklistItemsChild { get; }

		/// <inheritdoc />
		public ITicketChecklistLibrariesApi TicketChecklistLibraries { get; }

		/// <inheritdoc />
		public ITicketChecklistLibrariesChildApi TicketChecklistLibrariesChild { get; }

		/// <inheritdoc />
		public ITicketHistoryApi TicketHistory { get; }

		/// <inheritdoc />
		public ITicketNotesApi TicketNotes { get; }

		/// <inheritdoc />
		public ITicketNotesChildApi TicketNotesChild { get; }

		/// <inheritdoc />
		public ITicketRmaCreditsApi TicketRmaCredits { get; }

		/// <inheritdoc />
		public ITicketRmaCreditsChildApi TicketRmaCreditsChild { get; }

		/// <inheritdoc />
		public ITicketSecondaryResourcesApi TicketSecondaryResources { get; }

		/// <inheritdoc />
		public ITicketSecondaryResourcesChildApi TicketSecondaryResourcesChild { get; }

		/// <inheritdoc />
		public ITicketsApi Tickets { get; }

		/// <inheritdoc />
		public ITimeEntriesApi TimeEntries { get; }

		/// <inheritdoc />
		public IUserDefinedFieldDefinitionsApi UserDefinedFieldDefinitions { get; }

		/// <inheritdoc />
		public IUserDefinedFieldListItemsApi UserDefinedFieldListItems { get; }

		/// <inheritdoc />
		public IUserDefinedFieldListItemsChildApi UserDefinedFieldListItemsChild { get; }

		/// <inheritdoc />
		public IWebhookEventErrorLogsApi WebhookEventErrorLogs { get; }

		/// <inheritdoc />
		public IWorkTypeModifiersApi WorkTypeModifiers { get; }

		/// <inheritdoc />
		public IZoneInformationApiIntegrationApi ZoneInformationApiIntegration { get; }
	}
}
