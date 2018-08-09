Namespace Budget

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Budget]
		'''<summary>Budget amount (always in the default currency of the company)</summary>
		Public Property [AmountDC] As Double?
		'''<summary>Budget scenario</summary>
		Public Property [BudgetScenario] As Guid?
		'''<summary>Code of BudgetScenario</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BudgetScenarioCode] As String
		'''<summary>Description of BudgetScenario</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BudgetScenarioDescription] As String
		'''<summary>Used for cost center-specific budgets - NULL otherwise</summary>
		Public Property [Costcenter] As String
		'''<summary>Description of Costcenter</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<summary>Used for cost unit-specific budgets - NULL otherwise</summary>
		Public Property [Costunit] As String
		'''<summary>Description of Costunit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostunitDescription] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>G/L account</summary>
		Public Property [GLAccount] As Guid?
		'''<summary>Code of GLAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountCode] As String
		'''<summary>Description of GLAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountDescription] As String
		'''<summary>Numerical ID. Never displayed to the user, but it may have its use for performance reasons</summary>
		Public Property [HID] As Int64?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Used for item-specific budgets - NULL otherwise</summary>
		Public Property [Item] As Guid?
		'''<summary>Code of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Period (combined with financial year)</summary>
		Public Property [ReportingPeriod] As Int16?
		'''<summary>Financial year</summary>
		Public Property [ReportingYear] As Int16?
	End Class

End Namespace