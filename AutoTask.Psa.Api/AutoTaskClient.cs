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
			_client = client;
			ActionTypes = RefitFor(ActionTypes!);
			AdditionalInvoiceFieldValues = RefitFor(AdditionalInvoiceFieldValues!);
			ApiVersions = RefitFor(ApiVersions!);
			Appointments = RefitFor(Appointments!);
			AttachmentInfo = RefitFor(AttachmentInfo!);
			BillingCodes = RefitFor(BillingCodes!);
			BillingItemApprovalLevels = RefitFor(BillingItemApprovalLevels!);
			BillingItems = RefitFor(BillingItems!);
			ChangeOrderCharges = RefitFor(ChangeOrderCharges!);
			ChangeRequestLinks = RefitFor(ChangeRequestLinks!);
			ChecklistLibraries = RefitFor(ChecklistLibraries!);
			ChecklistLibraryChecklistItems = RefitFor(ChecklistLibraryChecklistItems!);
			ChecklistLibraryChecklistItemsChild = RefitFor(ChecklistLibraryChecklistItemsChild!);
			ClassificationIcons = RefitFor(ClassificationIcons!);
			ClientPortalUsers = RefitFor(ClientPortalUsers!);
			ComanagedAssociations = RefitFor(ComanagedAssociations!);
			Companies = RefitFor(Companies!);
			CompanyAlerts = RefitFor(CompanyAlerts!);
			CompanyAlertsChild = RefitFor(CompanyAlertsChild!);
			CompanyAttachments = RefitFor(CompanyAttachments!);
			CompanyAttachmentsChild = RefitFor(CompanyAttachmentsChild!);
			CompanyContactsChild = RefitFor(CompanyContactsChild!);
			CompanyLocations = RefitFor(CompanyLocations!);
			CompanyLocationsChild = RefitFor(CompanyLocationsChild!);
			CompanyNotes = RefitFor(CompanyNotes!);
			CompanyNotesChild = RefitFor(CompanyNotesChild!);
			CompanySiteConfigurations = RefitFor(CompanySiteConfigurations!);
			CompanySiteConfigurationsChild = RefitFor(CompanySiteConfigurationsChild!);
			CompanyTeams = RefitFor(CompanyTeams!);
			CompanyTeamsChild = RefitFor(CompanyTeamsChild!);
			CompanyToDos = RefitFor(CompanyToDos!);
			CompanyToDosChild = RefitFor(CompanyToDosChild!);
			CompanyWebhookExcludedResources = RefitFor(CompanyWebhookExcludedResources!);
			CompanyWebhookExcludedResourcesChild = RefitFor(CompanyWebhookExcludedResourcesChild!);
			CompanyWebhookFields = RefitFor(CompanyWebhookFields!);
			CompanyWebhookFieldsChild = RefitFor(CompanyWebhookFieldsChild!);
			CompanyWebhookUdfFields = RefitFor(CompanyWebhookUdfFields!);
			CompanyWebhookUdfFieldsChild = RefitFor(CompanyWebhookUdfFieldsChild!);
			CompanyWebhooks = RefitFor(CompanyWebhooks!);
			ConfigurationItemBillingProductAssociations = RefitFor(ConfigurationItemBillingProductAssociations!);
			ConfigurationItemBillingProductAssociationsChild = RefitFor(ConfigurationItemBillingProductAssociationsChild!);
			ConfigurationItemCategories = RefitFor(ConfigurationItemCategories!);
			ConfigurationItemCategoryUdfAssociations = RefitFor(ConfigurationItemCategoryUdfAssociations!);
			ConfigurationItemCategoryUdfAssociationsChild = RefitFor(ConfigurationItemCategoryUdfAssociationsChild!);
			ConfigurationItemExts = RefitFor(ConfigurationItemExts!);
			ConfigurationItemNotes = RefitFor(ConfigurationItemNotes!);
			ConfigurationItemNotesChild = RefitFor(ConfigurationItemNotesChild!);
			ConfigurationItemTypes = RefitFor(ConfigurationItemTypes!);
			ConfigurationItems = RefitFor(ConfigurationItems!);
			ContactBillingProductAssociations = RefitFor(ContactBillingProductAssociations!);
			ContactBillingProductAssociationsChild = RefitFor(ContactBillingProductAssociationsChild!);
			ContactGroupContacts = RefitFor(ContactGroupContacts!);
			ContactGroupContactsChild = RefitFor(ContactGroupContactsChild!);
			ContactGroups = RefitFor(ContactGroups!);
			ContactWebhookExcludedResources = RefitFor(ContactWebhookExcludedResources!);
			ContactWebhookExcludedResourcesChild = RefitFor(ContactWebhookExcludedResourcesChild!);
			ContactWebhookFields = RefitFor(ContactWebhookFields!);
			ContactWebhookFieldsChild = RefitFor(ContactWebhookFieldsChild!);
			ContactWebhookUdfFields = RefitFor(ContactWebhookUdfFields!);
			ContactWebhookUdfFieldsChild = RefitFor(ContactWebhookUdfFieldsChild!);
			ContactWebhooks = RefitFor(ContactWebhooks!);
			Contacts = RefitFor(Contacts!);
			ContractBillingRules = RefitFor(ContractBillingRules!);
			ContractBillingRulesChild = RefitFor(ContractBillingRulesChild!);
			ContractBlockHourFactors = RefitFor(ContractBlockHourFactors!);
			ContractBlockHourFactorsChild = RefitFor(ContractBlockHourFactorsChild!);
			ContractBlocks = RefitFor(ContractBlocks!);
			ContractBlocksChild = RefitFor(ContractBlocksChild!);
			ContractCharges = RefitFor(ContractCharges!);
			ContractChargesChild = RefitFor(ContractChargesChild!);
			ContractExclusionBillingCodes = RefitFor(ContractExclusionBillingCodes!);
			ContractExclusionBillingCodesChild = RefitFor(ContractExclusionBillingCodesChild!);
			ContractExclusionRoles = RefitFor(ContractExclusionRoles!);
			ContractExclusionRolesChild = RefitFor(ContractExclusionRolesChild!);
			ContractExclusionSetExcludedRoles = RefitFor(ContractExclusionSetExcludedRoles!);
			ContractExclusionSetExcludedRolesChild = RefitFor(ContractExclusionSetExcludedRolesChild!);
			ContractExclusionSetExcludedWorkTypes = RefitFor(ContractExclusionSetExcludedWorkTypes!);
			ContractExclusionSetExcludedWorkTypesChild = RefitFor(ContractExclusionSetExcludedWorkTypesChild!);
			ContractExclusionSets = RefitFor(ContractExclusionSets!);
			ContractMilestones = RefitFor(ContractMilestones!);
			ContractMilestonesChild = RefitFor(ContractMilestonesChild!);
			ContractNotes = RefitFor(ContractNotes!);
			ContractNotesChild = RefitFor(ContractNotesChild!);
			ContractRates = RefitFor(ContractRates!);
			ContractRatesChild = RefitFor(ContractRatesChild!);
			ContractRetainers = RefitFor(ContractRetainers!);
			ContractRetainersChild = RefitFor(ContractRetainersChild!);
			ContractRoleCosts = RefitFor(ContractRoleCosts!);
			ContractRoleCostsChild = RefitFor(ContractRoleCostsChild!);
			ContractServiceAdjustments = RefitFor(ContractServiceAdjustments!);
			ContractServiceAdjustmentsChild = RefitFor(ContractServiceAdjustmentsChild!);
			ContractServiceBundleAdjustments = RefitFor(ContractServiceBundleAdjustments!);
			ContractServiceBundleAdjustmentsChild = RefitFor(ContractServiceBundleAdjustmentsChild!);
			ContractServiceBundleUnits = RefitFor(ContractServiceBundleUnits!);
			ContractServiceBundleUnitsChild = RefitFor(ContractServiceBundleUnitsChild!);
			ContractServiceBundles = RefitFor(ContractServiceBundles!);
			ContractServiceBundlesChild = RefitFor(ContractServiceBundlesChild!);
			ContractServiceUnits = RefitFor(ContractServiceUnits!);
			ContractServiceUnitsChild = RefitFor(ContractServiceUnitsChild!);
			ContractServices = RefitFor(ContractServices!);
			ContractServicesChild = RefitFor(ContractServicesChild!);
			ContractTicketPurchases = RefitFor(ContractTicketPurchases!);
			ContractTicketPurchasesChild = RefitFor(ContractTicketPurchasesChild!);
			Contracts = RefitFor(Contracts!);
			Countries = RefitFor(Countries!);
			Currencies = RefitFor(Currencies!);
			Departments = RefitFor(Departments!);
			ExpenseItems = RefitFor(ExpenseItems!);
			ExpenseItemsChild = RefitFor(ExpenseItemsChild!);
			ExpenseReports = RefitFor(ExpenseReports!);
			HolidaySets = RefitFor(HolidaySets!);
			Holidays = RefitFor(Holidays!);
			HolidaysChild = RefitFor(HolidaysChild!);
			InternalLocationWithBusinessHours = RefitFor(InternalLocationWithBusinessHours!);
			InternalLocations = RefitFor(InternalLocations!);
			InventoryItemSerialNumbers = RefitFor(InventoryItemSerialNumbers!);
			InventoryItemSerialNumbersChild = RefitFor(InventoryItemSerialNumbersChild!);
			InventoryItems = RefitFor(InventoryItems!);
			InventoryLocations = RefitFor(InventoryLocations!);
			InventoryTransfers = RefitFor(InventoryTransfers!);
			InvoiceTemplates = RefitFor(InvoiceTemplates!);
			Invoices = RefitFor(Invoices!);
			MetadataApiIntegration = RefitFor(MetadataApiIntegration!);
			NotificationHistory = RefitFor(NotificationHistory!);
			Opportunities = RefitFor(Opportunities!);
			OpportunityAttachments = RefitFor(OpportunityAttachments!);
			OpportunityAttachmentsChild = RefitFor(OpportunityAttachmentsChild!);
			OrganizationalLevel1 = RefitFor(OrganizationalLevel1!);
			OrganizationalLevel2 = RefitFor(OrganizationalLevel2!);
			OrganizationalLevelAssociation = RefitFor(OrganizationalLevelAssociation!);
			OrganizationalResources = RefitFor(OrganizationalResources!);
			OrganizationalResourcesChild = RefitFor(OrganizationalResourcesChild!);
			PaymentTerms = RefitFor(PaymentTerms!);
			Phases = RefitFor(Phases!);
			PhasesChild = RefitFor(PhasesChild!);
			PriceListMaterialCodes = RefitFor(PriceListMaterialCodes!);
			PriceListProductTiers = RefitFor(PriceListProductTiers!);
			PriceListProducts = RefitFor(PriceListProducts!);
			PriceListRoles = RefitFor(PriceListRoles!);
			PriceListServiceBundles = RefitFor(PriceListServiceBundles!);
			PriceListServices = RefitFor(PriceListServices!);
			PriceListWorkTypeModifiers = RefitFor(PriceListWorkTypeModifiers!);
			ProductNotes = RefitFor(ProductNotes!);
			ProductNotesChild = RefitFor(ProductNotesChild!);
			ProductTiers = RefitFor(ProductTiers!);
			ProductTiersChild = RefitFor(ProductTiersChild!);
			ProductVendors = RefitFor(ProductVendors!);
			ProductVendorsChild = RefitFor(ProductVendorsChild!);
			Products = RefitFor(Products!);
			ProjectAttachments = RefitFor(ProjectAttachments!);
			ProjectAttachmentsChild = RefitFor(ProjectAttachmentsChild!);
			ProjectCharges = RefitFor(ProjectCharges!);
			ProjectChargesChild = RefitFor(ProjectChargesChild!);
			ProjectNotes = RefitFor(ProjectNotes!);
			ProjectNotesChild = RefitFor(ProjectNotesChild!);
			Projects = RefitFor(Projects!);
			PurchaseApprovals = RefitFor(PurchaseApprovals!);
			PurchaseOrderItemReceiving = RefitFor(PurchaseOrderItemReceiving!);
			PurchaseOrderItemReceivingChild = RefitFor(PurchaseOrderItemReceivingChild!);
			PurchaseOrderItems = RefitFor(PurchaseOrderItems!);
			PurchaseOrderItemsChild = RefitFor(PurchaseOrderItemsChild!);
			PurchaseOrders = RefitFor(PurchaseOrders!);
			QuoteItems = RefitFor(QuoteItems!);
			QuoteItemsChild = RefitFor(QuoteItemsChild!);
			QuoteLocations = RefitFor(QuoteLocations!);
			QuoteTemplates = RefitFor(QuoteTemplates!);
			Quotes = RefitFor(Quotes!);
			ResourceRoleDepartments = RefitFor(ResourceRoleDepartments!);
			ResourceRoleDepartmentsChild = RefitFor(ResourceRoleDepartmentsChild!);
			ResourceRoleQueues = RefitFor(ResourceRoleQueues!);
			ResourceRoleQueuesChild = RefitFor(ResourceRoleQueuesChild!);
			ResourceRoles = RefitFor(ResourceRoles!);
			ResourceRolesChild = RefitFor(ResourceRolesChild!);
			ResourceServiceDeskRoles = RefitFor(ResourceServiceDeskRoles!);
			ResourceServiceDeskRolesChild = RefitFor(ResourceServiceDeskRolesChild!);
			ResourceSkills = RefitFor(ResourceSkills!);
			ResourceSkillsChild = RefitFor(ResourceSkillsChild!);
			Resources = RefitFor(Resources!);
			Roles = RefitFor(Roles!);
			SalesOrders = RefitFor(SalesOrders!);
			SalesOrdersChild = RefitFor(SalesOrdersChild!);
			ServiceBundleServices = RefitFor(ServiceBundleServices!);
			ServiceBundleServicesChild = RefitFor(ServiceBundleServicesChild!);
			ServiceBundles = RefitFor(ServiceBundles!);
			ServiceCallTaskResources = RefitFor(ServiceCallTaskResources!);
			ServiceCallTaskResourcesChild = RefitFor(ServiceCallTaskResourcesChild!);
			ServiceCallTasks = RefitFor(ServiceCallTasks!);
			ServiceCallTasksChild = RefitFor(ServiceCallTasksChild!);
			ServiceCallTicketResources = RefitFor(ServiceCallTicketResources!);
			ServiceCallTicketResourcesChild = RefitFor(ServiceCallTicketResourcesChild!);
			ServiceCallTickets = RefitFor(ServiceCallTickets!);
			ServiceCallTicketsChild = RefitFor(ServiceCallTicketsChild!);
			ServiceCalls = RefitFor(ServiceCalls!);
			ServiceLevelAgreementResults = RefitFor(ServiceLevelAgreementResults!);
			ServiceLevelAgreementResultsChild = RefitFor(ServiceLevelAgreementResultsChild!);
			Services = RefitFor(Services!);
			ShippingTypes = RefitFor(ShippingTypes!);
			Skills = RefitFor(Skills!);
			SubscriptionPeriods = RefitFor(SubscriptionPeriods!);
			SubscriptionPeriodsChild = RefitFor(SubscriptionPeriodsChild!);
			Subscriptions = RefitFor(Subscriptions!);
			SurveyResults = RefitFor(SurveyResults!);
			Surveys = RefitFor(Surveys!);
			TaskAttachments = RefitFor(TaskAttachments!);
			TaskAttachmentsChild = RefitFor(TaskAttachmentsChild!);
			TaskNotes = RefitFor(TaskNotes!);
			TaskNotesChild = RefitFor(TaskNotesChild!);
			TaskPredecessors = RefitFor(TaskPredecessors!);
			TaskPredecessorsChild = RefitFor(TaskPredecessorsChild!);
			TaskSecondaryResources = RefitFor(TaskSecondaryResources!);
			TaskSecondaryResourcesChild = RefitFor(TaskSecondaryResourcesChild!);
			Tasks = RefitFor(Tasks!);
			TasksChild = RefitFor(TasksChild!);
			TaxCategories = RefitFor(TaxCategories!);
			TaxRegions = RefitFor(TaxRegions!);
			Taxes = RefitFor(Taxes!);
			ThresholdApiIntegration = RefitFor(ThresholdApiIntegration!);
			TicketAdditionalConfigurationItems = RefitFor(TicketAdditionalConfigurationItems!);
			TicketAdditionalConfigurationItemsChild = RefitFor(TicketAdditionalConfigurationItemsChild!);
			TicketAdditionalContacts = RefitFor(TicketAdditionalContacts!);
			TicketAdditionalContactsChild = RefitFor(TicketAdditionalContactsChild!);
			TicketAttachments = RefitFor(TicketAttachments!);
			TicketAttachmentsChild = RefitFor(TicketAttachmentsChild!);
			TicketCategories = RefitFor(TicketCategories!);
			TicketCategoryFieldDefaults = RefitFor(TicketCategoryFieldDefaults!);
			TicketCategoryFieldDefaultsChild = RefitFor(TicketCategoryFieldDefaultsChild!);
			TicketChangeRequestApprovals = RefitFor(TicketChangeRequestApprovals!);
			TicketChangeRequestApprovalsChild = RefitFor(TicketChangeRequestApprovalsChild!);
			TicketCharges = RefitFor(TicketCharges!);
			TicketChargesChild = RefitFor(TicketChargesChild!);
			TicketChecklistItems = RefitFor(TicketChecklistItems!);
			TicketChecklistItemsChild = RefitFor(TicketChecklistItemsChild!);
			TicketChecklistLibraries = RefitFor(TicketChecklistLibraries!);
			TicketChecklistLibrariesChild = RefitFor(TicketChecklistLibrariesChild!);
			TicketHistory = RefitFor(TicketHistory!);
			TicketNotes = RefitFor(TicketNotes!);
			TicketNotesChild = RefitFor(TicketNotesChild!);
			TicketRmaCredits = RefitFor(TicketRmaCredits!);
			TicketRmaCreditsChild = RefitFor(TicketRmaCreditsChild!);
			TicketSecondaryResources = RefitFor(TicketSecondaryResources!);
			TicketSecondaryResourcesChild = RefitFor(TicketSecondaryResourcesChild!);
			Tickets = RefitFor(Tickets!);
			TimeEntries = RefitFor(TimeEntries!);
			UserDefinedFieldDefinitions = RefitFor(UserDefinedFieldDefinitions!);
			UserDefinedFieldListItems = RefitFor(UserDefinedFieldListItems!);
			UserDefinedFieldListItemsChild = RefitFor(UserDefinedFieldListItemsChild!);
			WebhookEventErrorLogs = RefitFor(WebhookEventErrorLogs!);
			WorkTypeModifiers = RefitFor(WorkTypeModifiers!);
			ZoneInformationApiIntegration = RefitFor(ZoneInformationApiIntegration!);
		}

		private T RefitFor<T>(T _)
			=> RestService.For<T>(_client);

		private readonly HttpClient _client;

		/// <inheritdoc />
		public IActionTypes ActionTypes { get; }

		/// <inheritdoc />
		public IAdditionalInvoiceFieldValues AdditionalInvoiceFieldValues { get; }

		/// <inheritdoc />
		public IApiVersions ApiVersions { get; }

		/// <inheritdoc />
		public IAppointments Appointments { get; }

		/// <inheritdoc />
		public IAttachmentInfo AttachmentInfo { get; }

		/// <inheritdoc />
		public IBillingCodes BillingCodes { get; }

		/// <inheritdoc />
		public IBillingItemApprovalLevels BillingItemApprovalLevels { get; }

		/// <inheritdoc />
		public IBillingItems BillingItems { get; }

		/// <inheritdoc />
		public IChangeOrderCharges ChangeOrderCharges { get; }

		/// <inheritdoc />
		public IChangeRequestLinks ChangeRequestLinks { get; }

		/// <inheritdoc />
		public IChecklistLibraries ChecklistLibraries { get; }

		/// <inheritdoc />
		public IChecklistLibraryChecklistItems ChecklistLibraryChecklistItems { get; }

		/// <inheritdoc />
		public IChecklistLibraryChecklistItemsChild ChecklistLibraryChecklistItemsChild { get; }

		/// <inheritdoc />
		public IClassificationIcons ClassificationIcons { get; }

		/// <inheritdoc />
		public IClientPortalUsers ClientPortalUsers { get; }

		/// <inheritdoc />
		public IComanagedAssociations ComanagedAssociations { get; }

		/// <inheritdoc />
		public ICompanies Companies { get; }

		/// <inheritdoc />
		public ICompanyAlerts CompanyAlerts { get; }

		/// <inheritdoc />
		public ICompanyAlertsChild CompanyAlertsChild { get; }

		/// <inheritdoc />
		public ICompanyAttachments CompanyAttachments { get; }

		/// <inheritdoc />
		public ICompanyAttachmentsChild CompanyAttachmentsChild { get; }

		/// <inheritdoc />
		public ICompanyContactsChild CompanyContactsChild { get; }

		/// <inheritdoc />
		public ICompanyLocations CompanyLocations { get; }

		/// <inheritdoc />
		public ICompanyLocationsChild CompanyLocationsChild { get; }

		/// <inheritdoc />
		public ICompanyNotes CompanyNotes { get; }

		/// <inheritdoc />
		public ICompanyNotesChild CompanyNotesChild { get; }

		/// <inheritdoc />
		public ICompanySiteConfigurations CompanySiteConfigurations { get; }

		/// <inheritdoc />
		public ICompanySiteConfigurationsChild CompanySiteConfigurationsChild { get; }

		/// <inheritdoc />
		public ICompanyTeams CompanyTeams { get; }

		/// <inheritdoc />
		public ICompanyTeamsChild CompanyTeamsChild { get; }

		/// <inheritdoc />
		public ICompanyToDos CompanyToDos { get; }

		/// <inheritdoc />
		public ICompanyToDosChild CompanyToDosChild { get; }

		/// <inheritdoc />
		public ICompanyWebhookExcludedResources CompanyWebhookExcludedResources { get; }

		/// <inheritdoc />
		public ICompanyWebhookExcludedResourcesChild CompanyWebhookExcludedResourcesChild { get; }

		/// <inheritdoc />
		public ICompanyWebhookFields CompanyWebhookFields { get; }

		/// <inheritdoc />
		public ICompanyWebhookFieldsChild CompanyWebhookFieldsChild { get; }

		/// <inheritdoc />
		public ICompanyWebhookUdfFields CompanyWebhookUdfFields { get; }

		/// <inheritdoc />
		public ICompanyWebhookUdfFieldsChild CompanyWebhookUdfFieldsChild { get; }

		/// <inheritdoc />
		public ICompanyWebhooks CompanyWebhooks { get; }

		/// <inheritdoc />
		public IConfigurationItemBillingProductAssociations ConfigurationItemBillingProductAssociations { get; }

		/// <inheritdoc />
		public IConfigurationItemBillingProductAssociationsChild ConfigurationItemBillingProductAssociationsChild { get; }

		/// <inheritdoc />
		public IConfigurationItemCategories ConfigurationItemCategories { get; }

		/// <inheritdoc />
		public IConfigurationItemCategoryUdfAssociations ConfigurationItemCategoryUdfAssociations { get; }

		/// <inheritdoc />
		public IConfigurationItemCategoryUdfAssociationsChild ConfigurationItemCategoryUdfAssociationsChild { get; }

		/// <inheritdoc />
		public IConfigurationItemExts ConfigurationItemExts { get; }

		/// <inheritdoc />
		public IConfigurationItemNotes ConfigurationItemNotes { get; }

		/// <inheritdoc />
		public IConfigurationItemNotesChild ConfigurationItemNotesChild { get; }

		/// <inheritdoc />
		public IConfigurationItemTypes ConfigurationItemTypes { get; }

		/// <inheritdoc />
		public IConfigurationItems ConfigurationItems { get; }

		/// <inheritdoc />
		public IContactBillingProductAssociations ContactBillingProductAssociations { get; }

		/// <inheritdoc />
		public IContactBillingProductAssociationsChild ContactBillingProductAssociationsChild { get; }

		/// <inheritdoc />
		public IContactGroupContacts ContactGroupContacts { get; }

		/// <inheritdoc />
		public IContactGroupContactsChild ContactGroupContactsChild { get; }

		/// <inheritdoc />
		public IContactGroups ContactGroups { get; }

		/// <inheritdoc />
		public IContactWebhookExcludedResources ContactWebhookExcludedResources { get; }

		/// <inheritdoc />
		public IContactWebhookExcludedResourcesChild ContactWebhookExcludedResourcesChild { get; }

		/// <inheritdoc />
		public IContactWebhookFields ContactWebhookFields { get; }

		/// <inheritdoc />
		public IContactWebhookFieldsChild ContactWebhookFieldsChild { get; }

		/// <inheritdoc />
		public IContactWebhookUdfFields ContactWebhookUdfFields { get; }

		/// <inheritdoc />
		public IContactWebhookUdfFieldsChild ContactWebhookUdfFieldsChild { get; }

		/// <inheritdoc />
		public IContactWebhooks ContactWebhooks { get; }

		/// <inheritdoc />
		public IContacts Contacts { get; }

		/// <inheritdoc />
		public IContractBillingRules ContractBillingRules { get; }

		/// <inheritdoc />
		public IContractBillingRulesChild ContractBillingRulesChild { get; }

		/// <inheritdoc />
		public IContractBlockHourFactors ContractBlockHourFactors { get; }

		/// <inheritdoc />
		public IContractBlockHourFactorsChild ContractBlockHourFactorsChild { get; }

		/// <inheritdoc />
		public IContractBlocks ContractBlocks { get; }

		/// <inheritdoc />
		public IContractBlocksChild ContractBlocksChild { get; }

		/// <inheritdoc />
		public IContractCharges ContractCharges { get; }

		/// <inheritdoc />
		public IContractChargesChild ContractChargesChild { get; }

		/// <inheritdoc />
		public IContractExclusionBillingCodes ContractExclusionBillingCodes { get; }

		/// <inheritdoc />
		public IContractExclusionBillingCodesChild ContractExclusionBillingCodesChild { get; }

		/// <inheritdoc />
		public IContractExclusionRoles ContractExclusionRoles { get; }

		/// <inheritdoc />
		public IContractExclusionRolesChild ContractExclusionRolesChild { get; }

		/// <inheritdoc />
		public IContractExclusionSetExcludedRoles ContractExclusionSetExcludedRoles { get; }

		/// <inheritdoc />
		public IContractExclusionSetExcludedRolesChild ContractExclusionSetExcludedRolesChild { get; }

		/// <inheritdoc />
		public IContractExclusionSetExcludedWorkTypes ContractExclusionSetExcludedWorkTypes { get; }

		/// <inheritdoc />
		public IContractExclusionSetExcludedWorkTypesChild ContractExclusionSetExcludedWorkTypesChild { get; }

		/// <inheritdoc />
		public IContractExclusionSets ContractExclusionSets { get; }

		/// <inheritdoc />
		public IContractMilestones ContractMilestones { get; }

		/// <inheritdoc />
		public IContractMilestonesChild ContractMilestonesChild { get; }

		/// <inheritdoc />
		public IContractNotes ContractNotes { get; }

		/// <inheritdoc />
		public IContractNotesChild ContractNotesChild { get; }

		/// <inheritdoc />
		public IContractRates ContractRates { get; }

		/// <inheritdoc />
		public IContractRatesChild ContractRatesChild { get; }

		/// <inheritdoc />
		public IContractRetainers ContractRetainers { get; }

		/// <inheritdoc />
		public IContractRetainersChild ContractRetainersChild { get; }

		/// <inheritdoc />
		public IContractRoleCosts ContractRoleCosts { get; }

		/// <inheritdoc />
		public IContractRoleCostsChild ContractRoleCostsChild { get; }

		/// <inheritdoc />
		public IContractServiceAdjustments ContractServiceAdjustments { get; }

		/// <inheritdoc />
		public IContractServiceAdjustmentsChild ContractServiceAdjustmentsChild { get; }

		/// <inheritdoc />
		public IContractServiceBundleAdjustments ContractServiceBundleAdjustments { get; }

		/// <inheritdoc />
		public IContractServiceBundleAdjustmentsChild ContractServiceBundleAdjustmentsChild { get; }

		/// <inheritdoc />
		public IContractServiceBundleUnits ContractServiceBundleUnits { get; }

		/// <inheritdoc />
		public IContractServiceBundleUnitsChild ContractServiceBundleUnitsChild { get; }

		/// <inheritdoc />
		public IContractServiceBundles ContractServiceBundles { get; }

		/// <inheritdoc />
		public IContractServiceBundlesChild ContractServiceBundlesChild { get; }

		/// <inheritdoc />
		public IContractServiceUnits ContractServiceUnits { get; }

		/// <inheritdoc />
		public IContractServiceUnitsChild ContractServiceUnitsChild { get; }

		/// <inheritdoc />
		public IContractServices ContractServices { get; }

		/// <inheritdoc />
		public IContractServicesChild ContractServicesChild { get; }

		/// <inheritdoc />
		public IContractTicketPurchases ContractTicketPurchases { get; }

		/// <inheritdoc />
		public IContractTicketPurchasesChild ContractTicketPurchasesChild { get; }

		/// <inheritdoc />
		public IContracts Contracts { get; }

		/// <inheritdoc />
		public ICountries Countries { get; }

		/// <inheritdoc />
		public ICurrencies Currencies { get; }

		/// <inheritdoc />
		public IDepartments Departments { get; }

		/// <inheritdoc />
		public IExpenseItems ExpenseItems { get; }

		/// <inheritdoc />
		public IExpenseItemsChild ExpenseItemsChild { get; }

		/// <inheritdoc />
		public IExpenseReports ExpenseReports { get; }

		/// <inheritdoc />
		public IHolidaySets HolidaySets { get; }

		/// <inheritdoc />
		public IHolidays Holidays { get; }

		/// <inheritdoc />
		public IHolidaysChild HolidaysChild { get; }

		/// <inheritdoc />
		public IInternalLocationWithBusinessHours InternalLocationWithBusinessHours { get; }

		/// <inheritdoc />
		public IInternalLocations InternalLocations { get; }

		/// <inheritdoc />
		public IInventoryItemSerialNumbers InventoryItemSerialNumbers { get; }

		/// <inheritdoc />
		public IInventoryItemSerialNumbersChild InventoryItemSerialNumbersChild { get; }

		/// <inheritdoc />
		public IInventoryItems InventoryItems { get; }

		/// <inheritdoc />
		public IInventoryLocations InventoryLocations { get; }

		/// <inheritdoc />
		public IInventoryTransfers InventoryTransfers { get; }

		/// <inheritdoc />
		public IInvoiceTemplates InvoiceTemplates { get; }

		/// <inheritdoc />
		public IInvoices Invoices { get; }

		/// <inheritdoc />
		public IMetadataApiIntegration MetadataApiIntegration { get; }

		/// <inheritdoc />
		public INotificationHistory NotificationHistory { get; }

		/// <inheritdoc />
		public IOpportunities Opportunities { get; }

		/// <inheritdoc />
		public IOpportunityAttachments OpportunityAttachments { get; }

		/// <inheritdoc />
		public IOpportunityAttachmentsChild OpportunityAttachmentsChild { get; }

		/// <inheritdoc />
		public IOrganizationalLevel1 OrganizationalLevel1 { get; }

		/// <inheritdoc />
		public IOrganizationalLevel2 OrganizationalLevel2 { get; }

		/// <inheritdoc />
		public IOrganizationalLevelAssociation OrganizationalLevelAssociation { get; }

		/// <inheritdoc />
		public IOrganizationalResources OrganizationalResources { get; }

		/// <inheritdoc />
		public IOrganizationalResourcesChild OrganizationalResourcesChild { get; }

		/// <inheritdoc />
		public IPaymentTerms PaymentTerms { get; }

		/// <inheritdoc />
		public IPhases Phases { get; }

		/// <inheritdoc />
		public IPhasesChild PhasesChild { get; }

		/// <inheritdoc />
		public IPriceListMaterialCodes PriceListMaterialCodes { get; }

		/// <inheritdoc />
		public IPriceListProductTiers PriceListProductTiers { get; }

		/// <inheritdoc />
		public IPriceListProducts PriceListProducts { get; }

		/// <inheritdoc />
		public IPriceListRoles PriceListRoles { get; }

		/// <inheritdoc />
		public IPriceListServiceBundles PriceListServiceBundles { get; }

		/// <inheritdoc />
		public IPriceListServices PriceListServices { get; }

		/// <inheritdoc />
		public IPriceListWorkTypeModifiers PriceListWorkTypeModifiers { get; }

		/// <inheritdoc />
		public IProductNotes ProductNotes { get; }

		/// <inheritdoc />
		public IProductNotesChild ProductNotesChild { get; }

		/// <inheritdoc />
		public IProductTiers ProductTiers { get; }

		/// <inheritdoc />
		public IProductTiersChild ProductTiersChild { get; }

		/// <inheritdoc />
		public IProductVendors ProductVendors { get; }

		/// <inheritdoc />
		public IProductVendorsChild ProductVendorsChild { get; }

		/// <inheritdoc />
		public IProducts Products { get; }

		/// <inheritdoc />
		public IProjectAttachments ProjectAttachments { get; }

		/// <inheritdoc />
		public IProjectAttachmentsChild ProjectAttachmentsChild { get; }

		/// <inheritdoc />
		public IProjectCharges ProjectCharges { get; }

		/// <inheritdoc />
		public IProjectChargesChild ProjectChargesChild { get; }

		/// <inheritdoc />
		public IProjectNotes ProjectNotes { get; }

		/// <inheritdoc />
		public IProjectNotesChild ProjectNotesChild { get; }

		/// <inheritdoc />
		public IProjects Projects { get; }

		/// <inheritdoc />
		public IPurchaseApprovals PurchaseApprovals { get; }

		/// <inheritdoc />
		public IPurchaseOrderItemReceiving PurchaseOrderItemReceiving { get; }

		/// <inheritdoc />
		public IPurchaseOrderItemReceivingChild PurchaseOrderItemReceivingChild { get; }

		/// <inheritdoc />
		public IPurchaseOrderItems PurchaseOrderItems { get; }

		/// <inheritdoc />
		public IPurchaseOrderItemsChild PurchaseOrderItemsChild { get; }

		/// <inheritdoc />
		public IPurchaseOrders PurchaseOrders { get; }

		/// <inheritdoc />
		public IQuoteItems QuoteItems { get; }

		/// <inheritdoc />
		public IQuoteItemsChild QuoteItemsChild { get; }

		/// <inheritdoc />
		public IQuoteLocations QuoteLocations { get; }

		/// <inheritdoc />
		public IQuoteTemplates QuoteTemplates { get; }

		/// <inheritdoc />
		public IQuotes Quotes { get; }

		/// <inheritdoc />
		public IResourceRoleDepartments ResourceRoleDepartments { get; }

		/// <inheritdoc />
		public IResourceRoleDepartmentsChild ResourceRoleDepartmentsChild { get; }

		/// <inheritdoc />
		public IResourceRoleQueues ResourceRoleQueues { get; }

		/// <inheritdoc />
		public IResourceRoleQueuesChild ResourceRoleQueuesChild { get; }

		/// <inheritdoc />
		public IResourceRoles ResourceRoles { get; }

		/// <inheritdoc />
		public IResourceRolesChild ResourceRolesChild { get; }

		/// <inheritdoc />
		public IResourceServiceDeskRoles ResourceServiceDeskRoles { get; }

		/// <inheritdoc />
		public IResourceServiceDeskRolesChild ResourceServiceDeskRolesChild { get; }

		/// <inheritdoc />
		public IResourceSkills ResourceSkills { get; }

		/// <inheritdoc />
		public IResourceSkillsChild ResourceSkillsChild { get; }

		/// <inheritdoc />
		public IResources Resources { get; }

		/// <inheritdoc />
		public IRoles Roles { get; }

		/// <inheritdoc />
		public ISalesOrders SalesOrders { get; }

		/// <inheritdoc />
		public ISalesOrdersChild SalesOrdersChild { get; }

		/// <inheritdoc />
		public IServiceBundleServices ServiceBundleServices { get; }

		/// <inheritdoc />
		public IServiceBundleServicesChild ServiceBundleServicesChild { get; }

		/// <inheritdoc />
		public IServiceBundles ServiceBundles { get; }

		/// <inheritdoc />
		public IServiceCallTaskResources ServiceCallTaskResources { get; }

		/// <inheritdoc />
		public IServiceCallTaskResourcesChild ServiceCallTaskResourcesChild { get; }

		/// <inheritdoc />
		public IServiceCallTasks ServiceCallTasks { get; }

		/// <inheritdoc />
		public IServiceCallTasksChild ServiceCallTasksChild { get; }

		/// <inheritdoc />
		public IServiceCallTicketResources ServiceCallTicketResources { get; }

		/// <inheritdoc />
		public IServiceCallTicketResourcesChild ServiceCallTicketResourcesChild { get; }

		/// <inheritdoc />
		public IServiceCallTickets ServiceCallTickets { get; }

		/// <inheritdoc />
		public IServiceCallTicketsChild ServiceCallTicketsChild { get; }

		/// <inheritdoc />
		public IServiceCalls ServiceCalls { get; }

		/// <inheritdoc />
		public IServiceLevelAgreementResults ServiceLevelAgreementResults { get; }

		/// <inheritdoc />
		public IServiceLevelAgreementResultsChild ServiceLevelAgreementResultsChild { get; }

		/// <inheritdoc />
		public IServices Services { get; }

		/// <inheritdoc />
		public IShippingTypes ShippingTypes { get; }

		/// <inheritdoc />
		public ISkills Skills { get; }

		/// <inheritdoc />
		public ISubscriptionPeriods SubscriptionPeriods { get; }

		/// <inheritdoc />
		public ISubscriptionPeriodsChild SubscriptionPeriodsChild { get; }

		/// <inheritdoc />
		public ISubscriptions Subscriptions { get; }

		/// <inheritdoc />
		public ISurveyResults SurveyResults { get; }

		/// <inheritdoc />
		public ISurveys Surveys { get; }

		/// <inheritdoc />
		public ITaskAttachments TaskAttachments { get; }

		/// <inheritdoc />
		public ITaskAttachmentsChild TaskAttachmentsChild { get; }

		/// <inheritdoc />
		public ITaskNotes TaskNotes { get; }

		/// <inheritdoc />
		public ITaskNotesChild TaskNotesChild { get; }

		/// <inheritdoc />
		public ITaskPredecessors TaskPredecessors { get; }

		/// <inheritdoc />
		public ITaskPredecessorsChild TaskPredecessorsChild { get; }

		/// <inheritdoc />
		public ITaskSecondaryResources TaskSecondaryResources { get; }

		/// <inheritdoc />
		public ITaskSecondaryResourcesChild TaskSecondaryResourcesChild { get; }

		/// <inheritdoc />
		public ITasks Tasks { get; }

		/// <inheritdoc />
		public ITasksChild TasksChild { get; }

		/// <inheritdoc />
		public ITaxCategories TaxCategories { get; }

		/// <inheritdoc />
		public ITaxRegions TaxRegions { get; }

		/// <inheritdoc />
		public ITaxes Taxes { get; }

		/// <inheritdoc />
		public IThresholdApiIntegration ThresholdApiIntegration { get; }

		/// <inheritdoc />
		public ITicketAdditionalConfigurationItems TicketAdditionalConfigurationItems { get; }

		/// <inheritdoc />
		public ITicketAdditionalConfigurationItemsChild TicketAdditionalConfigurationItemsChild { get; }

		/// <inheritdoc />
		public ITicketAdditionalContacts TicketAdditionalContacts { get; }

		/// <inheritdoc />
		public ITicketAdditionalContactsChild TicketAdditionalContactsChild { get; }

		/// <inheritdoc />
		public ITicketAttachments TicketAttachments { get; }

		/// <inheritdoc />
		public ITicketAttachmentsChild TicketAttachmentsChild { get; }

		/// <inheritdoc />
		public ITicketCategories TicketCategories { get; }

		/// <inheritdoc />
		public ITicketCategoryFieldDefaults TicketCategoryFieldDefaults { get; }

		/// <inheritdoc />
		public ITicketCategoryFieldDefaultsChild TicketCategoryFieldDefaultsChild { get; }

		/// <inheritdoc />
		public ITicketChangeRequestApprovals TicketChangeRequestApprovals { get; }

		/// <inheritdoc />
		public ITicketChangeRequestApprovalsChild TicketChangeRequestApprovalsChild { get; }

		/// <inheritdoc />
		public ITicketCharges TicketCharges { get; }

		/// <inheritdoc />
		public ITicketChargesChild TicketChargesChild { get; }

		/// <inheritdoc />
		public ITicketChecklistItems TicketChecklistItems { get; }

		/// <inheritdoc />
		public ITicketChecklistItemsChild TicketChecklistItemsChild { get; }

		/// <inheritdoc />
		public ITicketChecklistLibraries TicketChecklistLibraries { get; }

		/// <inheritdoc />
		public ITicketChecklistLibrariesChild TicketChecklistLibrariesChild { get; }

		/// <inheritdoc />
		public ITicketHistory TicketHistory { get; }

		/// <inheritdoc />
		public ITicketNotes TicketNotes { get; }

		/// <inheritdoc />
		public ITicketNotesChild TicketNotesChild { get; }

		/// <inheritdoc />
		public ITicketRmaCredits TicketRmaCredits { get; }

		/// <inheritdoc />
		public ITicketRmaCreditsChild TicketRmaCreditsChild { get; }

		/// <inheritdoc />
		public ITicketSecondaryResources TicketSecondaryResources { get; }

		/// <inheritdoc />
		public ITicketSecondaryResourcesChild TicketSecondaryResourcesChild { get; }

		/// <inheritdoc />
		public ITickets Tickets { get; }

		/// <inheritdoc />
		public ITimeEntries TimeEntries { get; }

		/// <inheritdoc />
		public IUserDefinedFieldDefinitions UserDefinedFieldDefinitions { get; }

		/// <inheritdoc />
		public IUserDefinedFieldListItems UserDefinedFieldListItems { get; }

		/// <inheritdoc />
		public IUserDefinedFieldListItemsChild UserDefinedFieldListItemsChild { get; }

		/// <inheritdoc />
		public IWebhookEventErrorLogs WebhookEventErrorLogs { get; }

		/// <inheritdoc />
		public IWorkTypeModifiers WorkTypeModifiers { get; }

		/// <inheritdoc />
		public IZoneInformationApiIntegration ZoneInformationApiIntegration { get; }
	}
}
