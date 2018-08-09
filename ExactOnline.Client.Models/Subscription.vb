Namespace Subscription

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("EntryID")>
	Public Class [Subscription]
		'''<summary>Indicates if subscription is blocked for time cost entry</summary>
		Public Property [BlockEntry] As Boolean?
		'''<summary>Date of cancellation</summary>
		Public Property [CancellationDate] As DateTime?
		'''<summary>Reference to Classification</summary>
		Public Property [Classification] As Guid?
		'''<summary>Code of Classification</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ClassificationCode] As String
		'''<summary>Description of Classification</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ClassificationDescription] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Currency code</summary>
		Public Property [Currency] As String
		'''<summary>Purchase order number of customer</summary>
		Public Property [CustomerPONumber] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>End date</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [EntryID] As Guid
		'''<summary>Invoice Day</summary>
		Public Property [InvoiceDay] As Byte?
		'''<summary>Invoice date</summary>
		Public Property [InvoicedTo] As DateTime?
		'''<summary>Reference to invoice account</summary>
		Public Property [InvoiceTo] As Guid?
		'''<summary>Reference to contact person of invoice account</summary>
		Public Property [InvoiceToContactPerson] As Guid?
		'''<summary>Name of contact person of invoice account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceToContactPersonFullName] As String
		'''<summary>Name of invoice account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceToName] As String
		'''<summary>Invoicing start date</summary>
		Public Property [InvoicingStartDate] As DateTime?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Remarks</summary>
		Public Property [Notes] As String
		'''<summary>Number</summary>
		Public Property [Number] As Int32
		'''<summary>Reference to order account</summary>
		Public Property [OrderedBy] As Guid?
		'''<summary>Reference of contact person of order account</summary>
		Public Property [OrderedByContactPerson] As Guid?
		'''<summary>Name of contact person of order account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderedByContactPersonFullName] As String
		'''<summary>Name of order account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderedByName] As String
		'''<summary>Payment condition</summary>
		Public Property [PaymentCondition] As String
		'''<summary>Description of PaymentCondition</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionDescription] As String
		'''<summary>Indicates if subscription is printed</summary>
		Public Property [Printed] As Boolean
		'''<summary>Reference to reason cancelled</summary>
		Public Property [ReasonCancelled] As Guid?
		'''<summary>Code of ReasonCancelled</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReasonCancelledCode] As String
		'''<summary>Description of ReasonCancelled</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReasonCancelledDescription] As String
		'''<summary>Start date</summary>
		Public Property [StartDate] As DateTime
		'''<summary>Collection of subscription lines</summary>
		Public Property [SubscriptionLines] As IEnumerable(Of Models.Subscription.SubscriptionLine)
		'''<summary>Collection of restriction employees</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionRestrictionEmployees] As IEnumerable(Of Models.Subscription.SubscriptionRestrictionEmployee)
		'''<summary>Collection of restriction items</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionRestrictionItems] As IEnumerable(Of Models.Subscription.SubscriptionRestrictionItem)
		'''<summary>Reference to subscription type</summary>
		Public Property [SubscriptionType] As Guid
		'''<summary>Code of SubscriptionType</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionTypeCode] As String
		'''<summary>Description of SubscriptionType</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionTypeDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [SubscriptionLine]
		'''<summary>Amount in the default currency of the company</summary>
		Public Property [AmountDC] As Double
		'''<summary>Amount in the currency of the transaction</summary>
		Public Property [AmountFC] As Double
		'''<summary>Cost center</summary>
		Public Property [Costcenter] As String
		'''<summary>Cost unit</summary>
		Public Property [Costunit] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Discount percentage</summary>
		Public Property [Discount] As Double?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Entry ID</summary>
		Public Property [EntryID] As Guid
		'''<summary>From date</summary>
		Public Property [FromDate] As DateTime
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Reference to Item</summary>
		Public Property [Item] As Guid
		'''<summary>Description of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Line number</summary>
		Public Property [LineNumber] As Int32
		'''<summary>Reference to LineType</summary>
		Public Property [LineType] As Int16?
		'''<summary>Description of LineType</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineTypeDescription] As String
		'''<summary>Net price in the currency of the transaction</summary>
		Public Property [NetPrice] As Double
		'''<summary>Remarks</summary>
		Public Property [Notes] As String
		'''<summary>Quantity</summary>
		Public Property [Quantity] As Double
		'''<summary>To date</summary>
		Public Property [ToDate] As DateTime?
		'''<summary>Unit code</summary>
		Public Property [UnitCode] As String
		'''<summary>Description of Unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>Unit price in the currency of the transaction (price * unit factor)</summary>
		Public Property [UnitPrice] As Double
		'''<summary>Vat Amount in the currency of the transaction</summary>
		Public Property [VATAmountFC] As Double?
		'''<summary>VATCode</summary>
		Public Property [VATCode] As String
		'''<summary>Description of VATCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [SubscriptionLineType]
		'''<summary>Description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Description] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Int16
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [SubscriptionReasonCode]
		'''<summary>Indicates if the reason code is active</summary>
		Public Property [Active] As Boolean
		'''<summary>Subscription reason code</summary>
		Public Property [Code] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Remarks</summary>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(True, True, False, True)>
	<DataServiceKey("ID")>
	Public Class [SubscriptionRestrictionEmployee]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Employee linked to the restriction</summary>
		Public Property [Employee] As Guid?
		'''<summary>Name of employee</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeFullName] As String
		'''<summary>Readable ID of employee</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeHID] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Reference to subscription</summary>
		Public Property [Subscription] As Guid
		'''<summary>Description of subscription</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<summary>Number of subscription</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionNumber] As Int32
	End Class

	<SupportedActionsSDK(True, True, False, True)>
	<DataServiceKey("ID")>
	Public Class [SubscriptionRestrictionItem]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Item linked to the restriction</summary>
		Public Property [Item] As Guid?
		'''<summary>Code of item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Reference to subscription</summary>
		Public Property [Subscription] As Guid
		'''<summary>Description of subscription</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<summary>Number of subscription</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionNumber] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [SubscriptionType]
		'''<summary>Code</summary>
		Public Property [Code] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
	End Class

End Namespace