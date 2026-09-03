using System.Collections.Concurrent;
using System.Text;

namespace AutoTask.Psa.Api;

/// <summary>
/// API client is mainly responsible for making the HTTP call to the API backend.
/// </summary>
public class AutoTaskClient : IDisposable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public AutoTaskClient(
		AutoTaskClientOptions options,
		ILogger logger)
		: this(new HttpClient(new AuthenticatedHttpClientHandler(options, logger))
		{
			BaseAddress = new Uri($"https://webservices{options.ServerId}.autotask.net/atservicesrest/")
		})
	{
		_shouldDisposeHttpClient = true;
	}

	/// <summary>
	/// Initialises a new instance of <see cref="AutoTaskClient"/> using a pre-configured <see cref="HttpClient"/>.
	/// </summary>
	/// <param name="client">The HTTP client to use for all API requests.</param>
	public AutoTaskClient(HttpClient client)
	{
		_httpClient = client;
		_refitSettings = new RefitSettings();
	}

	/// <summary>
	/// Returns the Refit-generated implementation of <typeparamref name="T"/>, building it on first
	/// use and reusing it afterwards, so only the endpoints a caller actually touches are built.
	/// </summary>
	private T Get<T>()
		=> (T)_endpoints.GetOrAdd(typeof(T), _ => RestService.For<T>(_httpClient, _refitSettings)!);

	private readonly ConcurrentDictionary<Type, object> _endpoints = new();
	private readonly HttpClient _httpClient;
	private readonly RefitSettings _refitSettings;
	private readonly bool _shouldDisposeHttpClient;
	private bool _isDisposed;

	/// <inheritdoc />
	public IActionTypes ActionTypes => Get<IActionTypes>();

	/// <inheritdoc />
	public IAdditionalInvoiceFieldValues AdditionalInvoiceFieldValues => Get<IAdditionalInvoiceFieldValues>();

	/// <inheritdoc />
	public IApiVersions ApiVersions => Get<IApiVersions>();

	/// <inheritdoc />
	public IAppointments Appointments => Get<IAppointments>();

	/// <inheritdoc />
	public IAttachmentInfo AttachmentInfo => Get<IAttachmentInfo>();

	/// <inheritdoc />
	public IBillingCodes BillingCodes => Get<IBillingCodes>();

	/// <inheritdoc />
	public IBillingItemApprovalLevels BillingItemApprovalLevels => Get<IBillingItemApprovalLevels>();

	/// <inheritdoc />
	public IBillingItems BillingItems => Get<IBillingItems>();

	/// <inheritdoc />
	public IChangeOrderCharges ChangeOrderCharges => Get<IChangeOrderCharges>();

	/// <inheritdoc />
	public IChangeRequestLinks ChangeRequestLinks => Get<IChangeRequestLinks>();

	/// <inheritdoc />
	public IChecklistLibraries ChecklistLibraries => Get<IChecklistLibraries>();

	/// <inheritdoc />
	public IChecklistLibraryChecklistItems ChecklistLibraryChecklistItems => Get<IChecklistLibraryChecklistItems>();

	/// <inheritdoc />
	public IChecklistLibraryChecklistItemsChild ChecklistLibraryChecklistItemsChild => Get<IChecklistLibraryChecklistItemsChild>();

	/// <inheritdoc />
	public IClassificationIcons ClassificationIcons => Get<IClassificationIcons>();

	/// <inheritdoc />
	public IClientPortalUsers ClientPortalUsers => Get<IClientPortalUsers>();

	/// <inheritdoc />
	public IComanagedAssociations ComanagedAssociations => Get<IComanagedAssociations>();

	/// <inheritdoc />
	public ICompanies Companies => Get<ICompanies>();

	/// <inheritdoc />
	public ICompanyAlerts CompanyAlerts => Get<ICompanyAlerts>();

	/// <inheritdoc />
	public ICompanyAlertsChild CompanyAlertsChild => Get<ICompanyAlertsChild>();

	/// <inheritdoc />
	public ICompanyAttachments CompanyAttachments => Get<ICompanyAttachments>();

	/// <inheritdoc />
	public ICompanyAttachmentsChild CompanyAttachmentsChild => Get<ICompanyAttachmentsChild>();

	/// <inheritdoc />
	public ICompanyContactsChild CompanyContactsChild => Get<ICompanyContactsChild>();

	/// <inheritdoc />
	public ICompanyLocations CompanyLocations => Get<ICompanyLocations>();

	/// <inheritdoc />
	public ICompanyLocationsChild CompanyLocationsChild => Get<ICompanyLocationsChild>();

	/// <inheritdoc />
	public ICompanyNotes CompanyNotes => Get<ICompanyNotes>();

	/// <inheritdoc />
	public ICompanyNotesChild CompanyNotesChild => Get<ICompanyNotesChild>();

	/// <inheritdoc />
	public ICompanySiteConfigurations CompanySiteConfigurations => Get<ICompanySiteConfigurations>();

	/// <inheritdoc />
	public ICompanySiteConfigurationsChild CompanySiteConfigurationsChild => Get<ICompanySiteConfigurationsChild>();

	/// <inheritdoc />
	public ICompanyTeams CompanyTeams => Get<ICompanyTeams>();

	/// <inheritdoc />
	public ICompanyTeamsChild CompanyTeamsChild => Get<ICompanyTeamsChild>();

	/// <inheritdoc />
	public ICompanyToDos CompanyToDos => Get<ICompanyToDos>();

	/// <inheritdoc />
	public ICompanyToDosChild CompanyToDosChild => Get<ICompanyToDosChild>();

	/// <inheritdoc />
	public ICompanyWebhookExcludedResources CompanyWebhookExcludedResources => Get<ICompanyWebhookExcludedResources>();

	/// <inheritdoc />
	public ICompanyWebhookExcludedResourcesChild CompanyWebhookExcludedResourcesChild => Get<ICompanyWebhookExcludedResourcesChild>();

	/// <inheritdoc />
	public ICompanyWebhookFields CompanyWebhookFields => Get<ICompanyWebhookFields>();

	/// <inheritdoc />
	public ICompanyWebhookFieldsChild CompanyWebhookFieldsChild => Get<ICompanyWebhookFieldsChild>();

	/// <inheritdoc />
	public ICompanyWebhookUdfFields CompanyWebhookUdfFields => Get<ICompanyWebhookUdfFields>();

	/// <inheritdoc />
	public ICompanyWebhookUdfFieldsChild CompanyWebhookUdfFieldsChild => Get<ICompanyWebhookUdfFieldsChild>();

	/// <inheritdoc />
	public ICompanyWebhooks CompanyWebhooks => Get<ICompanyWebhooks>();

	/// <inheritdoc />
	public IConfigurationItemBillingProductAssociations ConfigurationItemBillingProductAssociations => Get<IConfigurationItemBillingProductAssociations>();

	/// <inheritdoc />
	public IConfigurationItemBillingProductAssociationsChild ConfigurationItemBillingProductAssociationsChild => Get<IConfigurationItemBillingProductAssociationsChild>();

	/// <inheritdoc />
	public IConfigurationItemCategories ConfigurationItemCategories => Get<IConfigurationItemCategories>();

	/// <inheritdoc />
	public IConfigurationItemCategoryUdfAssociations ConfigurationItemCategoryUdfAssociations => Get<IConfigurationItemCategoryUdfAssociations>();

	/// <inheritdoc />
	public IConfigurationItemCategoryUdfAssociationsChild ConfigurationItemCategoryUdfAssociationsChild => Get<IConfigurationItemCategoryUdfAssociationsChild>();

	/// <inheritdoc />
	public IConfigurationItemExts ConfigurationItemExts => Get<IConfigurationItemExts>();

	/// <inheritdoc />
	public IConfigurationItemNotes ConfigurationItemNotes => Get<IConfigurationItemNotes>();

	/// <inheritdoc />
	public IConfigurationItemNotesChild ConfigurationItemNotesChild => Get<IConfigurationItemNotesChild>();

	/// <inheritdoc />
	public IConfigurationItemTypes ConfigurationItemTypes => Get<IConfigurationItemTypes>();

	/// <inheritdoc />
	public IConfigurationItems ConfigurationItems => Get<IConfigurationItems>();

	/// <inheritdoc />
	public IContactBillingProductAssociations ContactBillingProductAssociations => Get<IContactBillingProductAssociations>();

	/// <inheritdoc />
	public IContactBillingProductAssociationsChild ContactBillingProductAssociationsChild => Get<IContactBillingProductAssociationsChild>();

	/// <inheritdoc />
	public IContactGroupContacts ContactGroupContacts => Get<IContactGroupContacts>();

	/// <inheritdoc />
	public IContactGroupContactsChild ContactGroupContactsChild => Get<IContactGroupContactsChild>();

	/// <inheritdoc />
	public IContactGroups ContactGroups => Get<IContactGroups>();

	/// <inheritdoc />
	public IContactWebhookExcludedResources ContactWebhookExcludedResources => Get<IContactWebhookExcludedResources>();

	/// <inheritdoc />
	public IContactWebhookExcludedResourcesChild ContactWebhookExcludedResourcesChild => Get<IContactWebhookExcludedResourcesChild>();

	/// <inheritdoc />
	public IContactWebhookFields ContactWebhookFields => Get<IContactWebhookFields>();

	/// <inheritdoc />
	public IContactWebhookFieldsChild ContactWebhookFieldsChild => Get<IContactWebhookFieldsChild>();

	/// <inheritdoc />
	public IContactWebhookUdfFields ContactWebhookUdfFields => Get<IContactWebhookUdfFields>();

	/// <inheritdoc />
	public IContactWebhookUdfFieldsChild ContactWebhookUdfFieldsChild => Get<IContactWebhookUdfFieldsChild>();

	/// <inheritdoc />
	public IContactWebhooks ContactWebhooks => Get<IContactWebhooks>();

	/// <inheritdoc />
	public IContacts Contacts => Get<IContacts>();

	/// <inheritdoc />
	public IContractBillingRules ContractBillingRules => Get<IContractBillingRules>();

	/// <inheritdoc />
	public IContractBillingRulesChild ContractBillingRulesChild => Get<IContractBillingRulesChild>();

	/// <inheritdoc />
	public IContractBlockHourFactors ContractBlockHourFactors => Get<IContractBlockHourFactors>();

	/// <inheritdoc />
	public IContractBlockHourFactorsChild ContractBlockHourFactorsChild => Get<IContractBlockHourFactorsChild>();

	/// <inheritdoc />
	public IContractBlocks ContractBlocks => Get<IContractBlocks>();

	/// <inheritdoc />
	public IContractBlocksChild ContractBlocksChild => Get<IContractBlocksChild>();

	/// <inheritdoc />
	public IContractCharges ContractCharges => Get<IContractCharges>();

	/// <inheritdoc />
	public IContractChargesChild ContractChargesChild => Get<IContractChargesChild>();

	/// <inheritdoc />
	public IContractExclusionBillingCodes ContractExclusionBillingCodes => Get<IContractExclusionBillingCodes>();

	/// <inheritdoc />
	public IContractExclusionBillingCodesChild ContractExclusionBillingCodesChild => Get<IContractExclusionBillingCodesChild>();

	/// <inheritdoc />
	public IContractExclusionRoles ContractExclusionRoles => Get<IContractExclusionRoles>();

	/// <inheritdoc />
	public IContractExclusionRolesChild ContractExclusionRolesChild => Get<IContractExclusionRolesChild>();

	/// <inheritdoc />
	public IContractExclusionSetExcludedRoles ContractExclusionSetExcludedRoles => Get<IContractExclusionSetExcludedRoles>();

	/// <inheritdoc />
	public IContractExclusionSetExcludedRolesChild ContractExclusionSetExcludedRolesChild => Get<IContractExclusionSetExcludedRolesChild>();

	/// <inheritdoc />
	public IContractExclusionSetExcludedWorkTypes ContractExclusionSetExcludedWorkTypes => Get<IContractExclusionSetExcludedWorkTypes>();

	/// <inheritdoc />
	public IContractExclusionSetExcludedWorkTypesChild ContractExclusionSetExcludedWorkTypesChild => Get<IContractExclusionSetExcludedWorkTypesChild>();

	/// <inheritdoc />
	public IContractExclusionSets ContractExclusionSets => Get<IContractExclusionSets>();

	/// <inheritdoc />
	public IContractMilestones ContractMilestones => Get<IContractMilestones>();

	/// <inheritdoc />
	public IContractMilestonesChild ContractMilestonesChild => Get<IContractMilestonesChild>();

	/// <inheritdoc />
	public IContractNotes ContractNotes => Get<IContractNotes>();

	/// <inheritdoc />
	public IContractNotesChild ContractNotesChild => Get<IContractNotesChild>();

	/// <inheritdoc />
	public IContractRates ContractRates => Get<IContractRates>();

	/// <inheritdoc />
	public IContractRatesChild ContractRatesChild => Get<IContractRatesChild>();

	/// <inheritdoc />
	public IContractRetainers ContractRetainers => Get<IContractRetainers>();

	/// <inheritdoc />
	public IContractRetainersChild ContractRetainersChild => Get<IContractRetainersChild>();

	/// <inheritdoc />
	public IContractRoleCosts ContractRoleCosts => Get<IContractRoleCosts>();

	/// <inheritdoc />
	public IContractRoleCostsChild ContractRoleCostsChild => Get<IContractRoleCostsChild>();

	/// <inheritdoc />
	public IContractServiceAdjustments ContractServiceAdjustments => Get<IContractServiceAdjustments>();

	/// <inheritdoc />
	public IContractServiceAdjustmentsChild ContractServiceAdjustmentsChild => Get<IContractServiceAdjustmentsChild>();

	/// <inheritdoc />
	public IContractServiceBundleAdjustments ContractServiceBundleAdjustments => Get<IContractServiceBundleAdjustments>();

	/// <inheritdoc />
	public IContractServiceBundleAdjustmentsChild ContractServiceBundleAdjustmentsChild => Get<IContractServiceBundleAdjustmentsChild>();

	/// <inheritdoc />
	public IContractServiceBundleUnits ContractServiceBundleUnits => Get<IContractServiceBundleUnits>();

	/// <inheritdoc />
	public IContractServiceBundleUnitsChild ContractServiceBundleUnitsChild => Get<IContractServiceBundleUnitsChild>();

	/// <inheritdoc />
	public IContractServiceBundles ContractServiceBundles => Get<IContractServiceBundles>();

	/// <inheritdoc />
	public IContractServiceBundlesChild ContractServiceBundlesChild => Get<IContractServiceBundlesChild>();

	/// <inheritdoc />
	public IContractServiceUnits ContractServiceUnits => Get<IContractServiceUnits>();

	/// <inheritdoc />
	public IContractServiceUnitsChild ContractServiceUnitsChild => Get<IContractServiceUnitsChild>();

	/// <inheritdoc />
	public IContractServices ContractServices => Get<IContractServices>();

	/// <inheritdoc />
	public IContractServicesChild ContractServicesChild => Get<IContractServicesChild>();

	/// <inheritdoc />
	public IContractTicketPurchases ContractTicketPurchases => Get<IContractTicketPurchases>();

	/// <inheritdoc />
	public IContractTicketPurchasesChild ContractTicketPurchasesChild => Get<IContractTicketPurchasesChild>();

	/// <inheritdoc />
	public IContracts Contracts => Get<IContracts>();

	/// <inheritdoc />
	public ICountries Countries => Get<ICountries>();

	/// <inheritdoc />
	public ICurrencies Currencies => Get<ICurrencies>();

	/// <inheritdoc />
	public IDepartments Departments => Get<IDepartments>();

	/// <inheritdoc />
	public IExpenseItems ExpenseItems => Get<IExpenseItems>();

	/// <inheritdoc />
	public IExpenseItemsChild ExpenseItemsChild => Get<IExpenseItemsChild>();

	/// <inheritdoc />
	public IExpenseReports ExpenseReports => Get<IExpenseReports>();

	/// <inheritdoc />
	public IHolidaySets HolidaySets => Get<IHolidaySets>();

	/// <inheritdoc />
	public IHolidays Holidays => Get<IHolidays>();

	/// <inheritdoc />
	public IHolidaysChild HolidaysChild => Get<IHolidaysChild>();

	/// <inheritdoc />
	public IInternalLocationWithBusinessHours InternalLocationWithBusinessHours => Get<IInternalLocationWithBusinessHours>();

	/// <inheritdoc />
	public IInternalLocations InternalLocations => Get<IInternalLocations>();

	/// <inheritdoc />
	public IInventoryItemSerialNumbers InventoryItemSerialNumbers => Get<IInventoryItemSerialNumbers>();

	/// <inheritdoc />
	public IInventoryItemSerialNumbersChild InventoryItemSerialNumbersChild => Get<IInventoryItemSerialNumbersChild>();

	/// <inheritdoc />
	public IInventoryItems InventoryItems => Get<IInventoryItems>();

	/// <inheritdoc />
	public IInventoryLocations InventoryLocations => Get<IInventoryLocations>();

	/// <inheritdoc />
	public IInventoryTransfers InventoryTransfers => Get<IInventoryTransfers>();

	/// <inheritdoc />
	public IInvoiceTemplates InvoiceTemplates => Get<IInvoiceTemplates>();

	/// <inheritdoc />
	public IInvoices Invoices => Get<IInvoices>();

	/// <inheritdoc />
	public IMetadataApiIntegration MetadataApiIntegration => Get<IMetadataApiIntegration>();

	/// <inheritdoc />
	public INotificationHistory NotificationHistory => Get<INotificationHistory>();

	/// <inheritdoc />
	public IOpportunities Opportunities => Get<IOpportunities>();

	/// <inheritdoc />
	public IOpportunityAttachments OpportunityAttachments => Get<IOpportunityAttachments>();

	/// <inheritdoc />
	public IOpportunityAttachmentsChild OpportunityAttachmentsChild => Get<IOpportunityAttachmentsChild>();

	/// <inheritdoc />
	public IOrganizationalLevel1 OrganizationalLevel1 => Get<IOrganizationalLevel1>();

	/// <inheritdoc />
	public IOrganizationalLevel2 OrganizationalLevel2 => Get<IOrganizationalLevel2>();

	/// <inheritdoc />
	public IOrganizationalLevelAssociation OrganizationalLevelAssociation => Get<IOrganizationalLevelAssociation>();

	/// <inheritdoc />
	public IOrganizationalResources OrganizationalResources => Get<IOrganizationalResources>();

	/// <inheritdoc />
	public IOrganizationalResourcesChild OrganizationalResourcesChild => Get<IOrganizationalResourcesChild>();

	/// <inheritdoc />
	public IPaymentTerms PaymentTerms => Get<IPaymentTerms>();

	/// <inheritdoc />
	public IPhases Phases => Get<IPhases>();

	/// <inheritdoc />
	public IPhasesChild PhasesChild => Get<IPhasesChild>();

	/// <inheritdoc />
	public IPriceListMaterialCodes PriceListMaterialCodes => Get<IPriceListMaterialCodes>();

	/// <inheritdoc />
	public IPriceListProductTiers PriceListProductTiers => Get<IPriceListProductTiers>();

	/// <inheritdoc />
	public IPriceListProducts PriceListProducts => Get<IPriceListProducts>();

	/// <inheritdoc />
	public IPriceListRoles PriceListRoles => Get<IPriceListRoles>();

	/// <inheritdoc />
	public IPriceListServiceBundles PriceListServiceBundles => Get<IPriceListServiceBundles>();

	/// <inheritdoc />
	public IPriceListServices PriceListServices => Get<IPriceListServices>();

	/// <inheritdoc />
	public IPriceListWorkTypeModifiers PriceListWorkTypeModifiers => Get<IPriceListWorkTypeModifiers>();

	/// <inheritdoc />
	public IProductNotes ProductNotes => Get<IProductNotes>();

	/// <inheritdoc />
	public IProductNotesChild ProductNotesChild => Get<IProductNotesChild>();

	/// <inheritdoc />
	public IProductTiers ProductTiers => Get<IProductTiers>();

	/// <inheritdoc />
	public IProductTiersChild ProductTiersChild => Get<IProductTiersChild>();

	/// <inheritdoc />
	public IProductVendors ProductVendors => Get<IProductVendors>();

	/// <inheritdoc />
	public IProductVendorsChild ProductVendorsChild => Get<IProductVendorsChild>();

	/// <inheritdoc />
	public IProducts Products => Get<IProducts>();

	/// <inheritdoc />
	public IProjectAttachments ProjectAttachments => Get<IProjectAttachments>();

	/// <inheritdoc />
	public IProjectAttachmentsChild ProjectAttachmentsChild => Get<IProjectAttachmentsChild>();

	/// <inheritdoc />
	public IProjectCharges ProjectCharges => Get<IProjectCharges>();

	/// <inheritdoc />
	public IProjectChargesChild ProjectChargesChild => Get<IProjectChargesChild>();

	/// <inheritdoc />
	public IProjectNotes ProjectNotes => Get<IProjectNotes>();

	/// <inheritdoc />
	public IProjectNotesChild ProjectNotesChild => Get<IProjectNotesChild>();

	/// <inheritdoc />
	public IProjects Projects => Get<IProjects>();

	/// <inheritdoc />
	public IPurchaseApprovals PurchaseApprovals => Get<IPurchaseApprovals>();

	/// <inheritdoc />
	public IPurchaseOrderItemReceiving PurchaseOrderItemReceiving => Get<IPurchaseOrderItemReceiving>();

	/// <inheritdoc />
	public IPurchaseOrderItemReceivingChild PurchaseOrderItemReceivingChild => Get<IPurchaseOrderItemReceivingChild>();

	/// <inheritdoc />
	public IPurchaseOrderItems PurchaseOrderItems => Get<IPurchaseOrderItems>();

	/// <inheritdoc />
	public IPurchaseOrderItemsChild PurchaseOrderItemsChild => Get<IPurchaseOrderItemsChild>();

	/// <inheritdoc />
	public IPurchaseOrders PurchaseOrders => Get<IPurchaseOrders>();

	/// <inheritdoc />
	public IQuoteItems QuoteItems => Get<IQuoteItems>();

	/// <inheritdoc />
	public IQuoteItemsChild QuoteItemsChild => Get<IQuoteItemsChild>();

	/// <inheritdoc />
	public IQuoteLocations QuoteLocations => Get<IQuoteLocations>();

	/// <inheritdoc />
	public IQuoteTemplates QuoteTemplates => Get<IQuoteTemplates>();

	/// <inheritdoc />
	public IQuotes Quotes => Get<IQuotes>();

	/// <inheritdoc />
	public IResourceRoleDepartments ResourceRoleDepartments => Get<IResourceRoleDepartments>();

	/// <inheritdoc />
	public IResourceRoleDepartmentsChild ResourceRoleDepartmentsChild => Get<IResourceRoleDepartmentsChild>();

	/// <inheritdoc />
	public IResourceRoleQueues ResourceRoleQueues => Get<IResourceRoleQueues>();

	/// <inheritdoc />
	public IResourceRoleQueuesChild ResourceRoleQueuesChild => Get<IResourceRoleQueuesChild>();

	/// <inheritdoc />
	public IResourceRoles ResourceRoles => Get<IResourceRoles>();

	/// <inheritdoc />
	public IResourceRolesChild ResourceRolesChild => Get<IResourceRolesChild>();

	/// <inheritdoc />
	public IResourceServiceDeskRoles ResourceServiceDeskRoles => Get<IResourceServiceDeskRoles>();

	/// <inheritdoc />
	public IResourceServiceDeskRolesChild ResourceServiceDeskRolesChild => Get<IResourceServiceDeskRolesChild>();

	/// <inheritdoc />
	public IResourceSkills ResourceSkills => Get<IResourceSkills>();

	/// <inheritdoc />
	public IResourceSkillsChild ResourceSkillsChild => Get<IResourceSkillsChild>();

	/// <inheritdoc />
	public IResources Resources => Get<IResources>();

	/// <inheritdoc />
	public IRoles Roles => Get<IRoles>();

	/// <inheritdoc />
	public ISalesOrders SalesOrders => Get<ISalesOrders>();

	/// <inheritdoc />
	public ISalesOrdersChild SalesOrdersChild => Get<ISalesOrdersChild>();

	/// <inheritdoc />
	public IServiceBundleServices ServiceBundleServices => Get<IServiceBundleServices>();

	/// <inheritdoc />
	public IServiceBundleServicesChild ServiceBundleServicesChild => Get<IServiceBundleServicesChild>();

	/// <inheritdoc />
	public IServiceBundles ServiceBundles => Get<IServiceBundles>();

	/// <inheritdoc />
	public IServiceCallTaskResources ServiceCallTaskResources => Get<IServiceCallTaskResources>();

	/// <inheritdoc />
	public IServiceCallTaskResourcesChild ServiceCallTaskResourcesChild => Get<IServiceCallTaskResourcesChild>();

	/// <inheritdoc />
	public IServiceCallTasks ServiceCallTasks => Get<IServiceCallTasks>();

	/// <inheritdoc />
	public IServiceCallTasksChild ServiceCallTasksChild => Get<IServiceCallTasksChild>();

	/// <inheritdoc />
	public IServiceCallTicketResources ServiceCallTicketResources => Get<IServiceCallTicketResources>();

	/// <inheritdoc />
	public IServiceCallTicketResourcesChild ServiceCallTicketResourcesChild => Get<IServiceCallTicketResourcesChild>();

	/// <inheritdoc />
	public IServiceCallTickets ServiceCallTickets => Get<IServiceCallTickets>();

	/// <inheritdoc />
	public IServiceCallTicketsChild ServiceCallTicketsChild => Get<IServiceCallTicketsChild>();

	/// <inheritdoc />
	public IServiceCalls ServiceCalls => Get<IServiceCalls>();

	/// <inheritdoc />
	public IServiceLevelAgreementResults ServiceLevelAgreementResults => Get<IServiceLevelAgreementResults>();

	/// <inheritdoc />
	public IServiceLevelAgreementResultsChild ServiceLevelAgreementResultsChild => Get<IServiceLevelAgreementResultsChild>();

	/// <inheritdoc />
	public IServices Services => Get<IServices>();

	/// <inheritdoc />
	public IShippingTypes ShippingTypes => Get<IShippingTypes>();

	/// <inheritdoc />
	public ISkills Skills => Get<ISkills>();

	/// <inheritdoc />
	public ISubscriptionPeriods SubscriptionPeriods => Get<ISubscriptionPeriods>();

	/// <inheritdoc />
	public ISubscriptionPeriodsChild SubscriptionPeriodsChild => Get<ISubscriptionPeriodsChild>();

	/// <inheritdoc />
	public ISubscriptions Subscriptions => Get<ISubscriptions>();

	/// <inheritdoc />
	public ISurveyResults SurveyResults => Get<ISurveyResults>();

	/// <inheritdoc />
	public ISurveys Surveys => Get<ISurveys>();

	/// <inheritdoc />
	public ITaskAttachments TaskAttachments => Get<ITaskAttachments>();

	/// <inheritdoc />
	public ITaskAttachmentsChild TaskAttachmentsChild => Get<ITaskAttachmentsChild>();

	/// <inheritdoc />
	public ITaskNotes TaskNotes => Get<ITaskNotes>();

	/// <inheritdoc />
	public ITaskNotesChild TaskNotesChild => Get<ITaskNotesChild>();

	/// <inheritdoc />
	public ITaskPredecessors TaskPredecessors => Get<ITaskPredecessors>();

	/// <inheritdoc />
	public ITaskPredecessorsChild TaskPredecessorsChild => Get<ITaskPredecessorsChild>();

	/// <inheritdoc />
	public ITaskSecondaryResources TaskSecondaryResources => Get<ITaskSecondaryResources>();

	/// <inheritdoc />
	public ITaskSecondaryResourcesChild TaskSecondaryResourcesChild => Get<ITaskSecondaryResourcesChild>();

	/// <inheritdoc />
	public ITasks Tasks => Get<ITasks>();

	/// <inheritdoc />
	public ITasksChild TasksChild => Get<ITasksChild>();

	/// <inheritdoc />
	public ITaxCategories TaxCategories => Get<ITaxCategories>();

	/// <inheritdoc />
	public ITaxRegions TaxRegions => Get<ITaxRegions>();

	/// <inheritdoc />
	public ITaxes Taxes => Get<ITaxes>();

	/// <inheritdoc />
	public IThresholdApiIntegration ThresholdApiIntegration => Get<IThresholdApiIntegration>();

	/// <inheritdoc />
	public ITicketAdditionalConfigurationItems TicketAdditionalConfigurationItems => Get<ITicketAdditionalConfigurationItems>();

	/// <inheritdoc />
	public ITicketAdditionalConfigurationItemsChild TicketAdditionalConfigurationItemsChild => Get<ITicketAdditionalConfigurationItemsChild>();

	/// <inheritdoc />
	public ITicketAdditionalContacts TicketAdditionalContacts => Get<ITicketAdditionalContacts>();

	/// <inheritdoc />
	public ITicketAdditionalContactsChild TicketAdditionalContactsChild => Get<ITicketAdditionalContactsChild>();

	/// <inheritdoc />
	public ITicketAttachments TicketAttachments => Get<ITicketAttachments>();

	/// <inheritdoc />
	public ITicketAttachmentsChild TicketAttachmentsChild => Get<ITicketAttachmentsChild>();

	/// <inheritdoc />
	public ITicketCategories TicketCategories => Get<ITicketCategories>();

	/// <inheritdoc />
	public ITicketCategoryFieldDefaults TicketCategoryFieldDefaults => Get<ITicketCategoryFieldDefaults>();

	/// <inheritdoc />
	public ITicketCategoryFieldDefaultsChild TicketCategoryFieldDefaultsChild => Get<ITicketCategoryFieldDefaultsChild>();

	/// <inheritdoc />
	public ITicketChangeRequestApprovals TicketChangeRequestApprovals => Get<ITicketChangeRequestApprovals>();

	/// <inheritdoc />
	public ITicketChangeRequestApprovalsChild TicketChangeRequestApprovalsChild => Get<ITicketChangeRequestApprovalsChild>();

	/// <inheritdoc />
	public ITicketCharges TicketCharges => Get<ITicketCharges>();

	/// <inheritdoc />
	public ITicketChargesChild TicketChargesChild => Get<ITicketChargesChild>();

	/// <inheritdoc />
	public ITicketChecklistItems TicketChecklistItems => Get<ITicketChecklistItems>();

	/// <inheritdoc />
	public ITicketChecklistItemsChild TicketChecklistItemsChild => Get<ITicketChecklistItemsChild>();

	/// <inheritdoc />
	public ITicketChecklistLibraries TicketChecklistLibraries => Get<ITicketChecklistLibraries>();

	/// <inheritdoc />
	public ITicketChecklistLibrariesChild TicketChecklistLibrariesChild => Get<ITicketChecklistLibrariesChild>();

	/// <inheritdoc />
	public ITicketHistory TicketHistory => Get<ITicketHistory>();

	/// <inheritdoc />
	public ITicketNotes TicketNotes => Get<ITicketNotes>();

	/// <inheritdoc />
	public ITicketNotesChild TicketNotesChild => Get<ITicketNotesChild>();

	/// <inheritdoc />
	public ITicketRmaCredits TicketRmaCredits => Get<ITicketRmaCredits>();

	/// <inheritdoc />
	public ITicketRmaCreditsChild TicketRmaCreditsChild => Get<ITicketRmaCreditsChild>();

	/// <inheritdoc />
	public ITicketSecondaryResources TicketSecondaryResources => Get<ITicketSecondaryResources>();

	/// <inheritdoc />
	public ITicketSecondaryResourcesChild TicketSecondaryResourcesChild => Get<ITicketSecondaryResourcesChild>();

	/// <inheritdoc />
	public ITickets Tickets => Get<ITickets>();

	/// <inheritdoc />
	public ITimeEntries TimeEntries => Get<ITimeEntries>();

	/// <inheritdoc />
	public IUserDefinedFieldDefinitions UserDefinedFieldDefinitions => Get<IUserDefinedFieldDefinitions>();

	/// <inheritdoc />
	public IUserDefinedFieldListItems UserDefinedFieldListItems => Get<IUserDefinedFieldListItems>();

	/// <inheritdoc />
	public IUserDefinedFieldListItemsChild UserDefinedFieldListItemsChild => Get<IUserDefinedFieldListItemsChild>();

	/// <inheritdoc />
	public IWebhookEventErrorLogs WebhookEventErrorLogs => Get<IWebhookEventErrorLogs>();

	/// <inheritdoc />
	public IWorkTypeModifiers WorkTypeModifiers => Get<IWorkTypeModifiers>();

	/// <inheritdoc />
	public IZoneInformationApiIntegration ZoneInformationApiIntegration => Get<IZoneInformationApiIntegration>();

	/// <summary>
	/// Performs a GET request and deserialises the response body as a <see cref="JsonObject"/>.
	/// </summary>
	/// <param name="subUrl">The relative URL to request.</param>
	/// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
	/// <returns>The deserialised <see cref="JsonObject"/>, or <see langword="null"/> if the response body is empty.</returns>
	public Task<JsonObject?> GetJsonObjectAsync(string subUrl, CancellationToken cancellationToken)
		=> SendForJsonObjectAsync(new HttpRequestMessage(HttpMethod.Get, subUrl), cancellationToken);

	/// <summary>
	/// Performs a GET request to the specified URL.
	/// </summary>
	/// <exception cref="FormatException"></exception>
	public Task<List<JsonObject>> GetAllAsync(string subUrl, CancellationToken cancellationToken)
		=> GetAllInternalAsync(HttpMethod.Get, subUrl, null, cancellationToken);

	/// <summary>
	/// Performs a GET request to the specified URL.
	/// </summary>
	/// <exception cref="FormatException"></exception>
	public Task<List<JsonObject>> GetAllAsync(string subUrl, string body, CancellationToken cancellationToken)
		=> GetAllInternalAsync(HttpMethod.Post, subUrl, body, cancellationToken);

	/// <summary>
	/// Perform a query using HTTP POST and return all the results.
	/// </summary>
	/// <exception cref="FormatException"></exception>
	private async Task<List<JsonObject>> GetAllInternalAsync(
		HttpMethod httpMethod,
		string subUrl,
		string? body,
		CancellationToken cancellationToken)
	{
		var list = new List<JsonObject>();

		var nextSubUrl = subUrl;
		while (nextSubUrl is not null)
		{
			var jsonObject = await SendForJsonObjectAsync(
				CreateRequest(httpMethod, nextSubUrl, body),
				cancellationToken) ?? throw new FormatException("Cannot deserialize items.");

			list.AddRange(GetItems(jsonObject));
			nextSubUrl = GetNextPageUrl(jsonObject);
		}

		return list;
	}

	/// <summary>
	/// Builds a request for <paramref name="subUrl"/>, attaching <paramref name="body"/> as JSON when supplied.
	/// </summary>
	private static HttpRequestMessage CreateRequest(HttpMethod httpMethod, string subUrl, string? body)
	{
		var httpRequestMessage = new HttpRequestMessage(httpMethod, subUrl);
		if (body is not null)
		{
			httpRequestMessage.Content = new StringContent(body, Encoding.UTF8, "application/json");
		}

		return httpRequestMessage;
	}

	/// <summary>
	/// Sends a request and deserialises a successful response body as a <see cref="JsonObject"/>.
	/// </summary>
	/// <returns>The deserialised <see cref="JsonObject"/>, or <see langword="null"/> if the response body is empty.</returns>
	private async Task<JsonObject?> SendForJsonObjectAsync(
		HttpRequestMessage httpRequestMessage,
		CancellationToken cancellationToken)
	{
		var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage, cancellationToken);
		if (!httpResponseMessage.IsSuccessStatusCode)
		{
			throw await ApiException.Create(httpRequestMessage, HttpMethod.Get, httpResponseMessage, _refitSettings);
		}

		var json = await httpResponseMessage
			.Content
			.ReadAsStringAsync(cancellationToken);

		return string.IsNullOrEmpty(json) ? null : JsonNode.Parse(json)?.AsObject();
	}

	/// <summary>
	/// Reads the "items" array from a query response.
	/// </summary>
	/// <exception cref="FormatException">The response carried no deserialisable "items" array.</exception>
	private static IEnumerable<JsonObject> GetItems(JsonObject jsonObject)
		=> jsonObject["items"] is JsonArray items
			? items.Select(item => item as JsonObject ?? throw new FormatException("Cannot deserialize items."))
			: throw new FormatException("Cannot deserialize items.");

	/// <summary>
	/// Returns the URL of the next page of results, or <see langword="null"/> if this was the last page.
	/// </summary>
	private static string? GetNextPageUrl(JsonObject jsonObject)
	{
		var nextPageUrl = jsonObject["pageDetails"]?["nextPageUrl"]?.ToString();
		return string.IsNullOrWhiteSpace(nextPageUrl) ? null : nextPageUrl;
	}

	/// <summary>
	/// Perform a query using HTTP POST and return all the results.
	/// </summary>
	/// <exception cref="FormatException"></exception>
	public async Task DeleteAsync(
		string subUrl,
		CancellationToken cancellationToken)
	{
		var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, subUrl);
		var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage, cancellationToken);
		if (!httpResponseMessage.IsSuccessStatusCode)
		{
			throw await ApiException.Create(httpRequestMessage, HttpMethod.Get, httpResponseMessage, _refitSettings);
		}
	}

	/// <summary>
	/// Releases the resources used by this instance.
	/// </summary>
	/// <param name="disposing"><see langword="true"/> to release managed resources.</param>
	protected virtual void Dispose(bool disposing)
	{
		if (!_isDisposed)
		{
			if (disposing)
			{
				if (_shouldDisposeHttpClient)
				{
					_httpClient.Dispose();
				}
			}

			_isDisposed = true;
		}
	}

	/// <summary>
	/// Releases all resources used by this <see cref="AutoTaskClient"/>.
	/// </summary>
	public void Dispose()
	{
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
