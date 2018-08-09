Namespace OpeningBalance

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Division,ReportingYear,GLAccount")>
	Public Class [OpeningBalanceAfterEntry]
		'''<summary>The opening balance amount of the G/L account.</summary>
		Public Property [Amount] As Double?
		'''<summary>Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.</summary>
		Public Property [BalanceSide] As String
		'''<summary>Division code.</summary>
		Public Property [Division] As Int32
		'''<summary>The balance sheet account.</summary>
		Public Property [GLAccount] As Guid
		'''<summary>The code of the G/L account.</summary>
		Public Property [GLAccountCode] As String
		'''<summary>The description of the G/L account.</summary>
		Public Property [GLAccountDescription] As String
		'''<summary>The reporting year of the opening balance.</summary>
		Public Property [ReportingYear] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Division,ReportingYear,GLAccount")>
	Public Class [OpeningBalancePreviousYearAfterEntry]
		'''<summary>The opening balance amount of the G/L account.</summary>
		Public Property [Amount] As Double?
		'''<summary>Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.</summary>
		Public Property [BalanceSide] As String
		'''<summary>Division code.</summary>
		Public Property [Division] As Int32
		'''<summary>The balance sheet account.</summary>
		Public Property [GLAccount] As Guid
		'''<summary>The code of the G/L account.</summary>
		Public Property [GLAccountCode] As String
		'''<summary>The description of the G/L account.</summary>
		Public Property [GLAccountDescription] As String
		'''<summary>The reporting year of the opening balance.</summary>
		Public Property [ReportingYear] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Division,ReportingYear,GLAccount")>
	Public Class [OpeningBalancePreviousYearProcessed]
		'''<summary>The opening balance amount of the G/L account.</summary>
		Public Property [Amount] As Double?
		'''<summary>Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.</summary>
		Public Property [BalanceSide] As String
		'''<summary>Division code.</summary>
		Public Property [Division] As Int32
		'''<summary>The balance sheet account.</summary>
		Public Property [GLAccount] As Guid
		'''<summary>The code of the G/L account.</summary>
		Public Property [GLAccountCode] As String
		'''<summary>The description of the G/L account.</summary>
		Public Property [GLAccountDescription] As String
		'''<summary>The reporting year of the opening balance.</summary>
		Public Property [ReportingYear] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Division,ReportingYear,GLAccount")>
	Public Class [OpeningBalanceProcessed]
		'''<summary>The opening balance amount of the G/L account.</summary>
		Public Property [Amount] As Double?
		'''<summary>Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.</summary>
		Public Property [BalanceSide] As String
		'''<summary>Division code.</summary>
		Public Property [Division] As Int32
		'''<summary>The balance sheet account.</summary>
		Public Property [GLAccount] As Guid
		'''<summary>The code of the G/L account.</summary>
		Public Property [GLAccountCode] As String
		'''<summary>The description of the G/L account.</summary>
		Public Property [GLAccountDescription] As String
		'''<summary>The reporting year of the opening balance.</summary>
		Public Property [ReportingYear] As Int32
	End Class

End Namespace