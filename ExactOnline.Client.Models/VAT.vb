Namespace VAT

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [VATCode]
		'''<summary>Tax account</summary>
		Public Property [Account] As Guid?
		'''<summary>Code of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<summary>Name of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Indicates how to calculate the tax. 0 = based on the gross amount, 1 = based on the gross amount + another tax</summary>
		Public Property [CalculationBasis] As Byte?
		'''<summary>Indicates if transactions using the VAT code are transactions of the domestic VAT charging regulation (such as those for subcontractors) or transactions that are registered within the EU. If Charged=1 and linked to a purchase invoice, both a line for the VAT to pay and a line for the VAT to claim are being created</summary>
		Public Property [Charged] As Boolean?
		'''<summary>VAT code</summary>
		Public Property [Code] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Country] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of the VAT code</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Used in all legislations except France. Indicates if and how transactions using the VAT code appear on the ICT return (EU sales list). L = Listing goods, N = No listing, S = Listing services, T = Triangulation</summary>
		Public Property [EUSalesListing] As String
		'''<summary>Indicates the purchase discount GL account linked to the VAT codes for German legislation</summary>
		Public Property [GLDiscountPurchase] As Guid?
		'''<summary>Code of GLDiscountPurchase</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLDiscountPurchaseCode] As String
		'''<summary>Description of GLDiscountPurchase</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLDiscountPurchaseDescription] As String
		'''<summary>Indicates the sales discount GL account linked to the VAT codes for German legislation</summary>
		Public Property [GLDiscountSales] As Guid?
		'''<summary>Code of GLDiscountSales</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLDiscountSalesCode] As String
		'''<summary>Description of GLDiscountSales</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLDiscountSalesDescription] As String
		'''<summary>G/L account that is used to book the VAT to claim. If you enter purchases with a VAT code, the VAT amount to be claimed is entered to this VAT account. Must be of type VAT</summary>
		Public Property [GLToClaim] As Guid?
		'''<summary>Code of GLToClaim</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLToClaimCode] As String
		'''<summary>Description of GLToClaim</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLToClaimDescription] As String
		'''<summary>G/L account that is used to book the VAT to pay. If you enter sales with a VAT code, the VAT amount to be paid is entered to this VAT account. Must be of type VAT</summary>
		Public Property [GLToPay] As Guid?
		'''<summary>Code of GLToPay</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLToPayCode] As String
		'''<summary>Description of GLToPay</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLToPayDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Used in all legislations except France. Indicates if intrastat is used</summary>
		Public Property [IntraStat] As Boolean?
		'''<summary>Used in France legislation only. Indicates if and how transactions using the VAT code appear on the DEB/DES return. L = Goods, N = Empty, S = Services</summary>
		Public Property [IntrastatType] As String
		'''<summary>Indicates if the VAT code may still be used</summary>
		Public Property [IsBlocked] As Boolean?
		'''<summary>Legal description for VAT code to print in the total block of the invoice</summary>
		Public Property [LegalText] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>User name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Percentage of the VAT code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Percentage] As Double?
		'''<summary>Indicates what type of Taxcode it is: can be VAT, IncomeTax</summary>
		Public Property [TaxReturnType] As Int16?
		'''<summary>Indicates how the VAT amount should be calculated in relation to the invoice amount. B = VAT 0% (Only base amount), E = Excluding, I = Including, N = No VAT</summary>
		Public Property [Type] As String
		'''<summary>Field in VAT code maintenance to calculate different VATs depending on the selected document type. P = purchase invoice, F = freelance invoice, E = expense voucher. The field is valid for witholding tax type</summary>
		Public Property [VatDocType] As String
		'''<summary>The VAT margin scheme is used for the trade of secondhand goods which are purchased without VAT (for example when a company buys a secondhand good from a private person). In the VAT margin scheme, the VAT is not calculated based on the sales price. Instead of that, the VAT is calculated based on the margin (gross sales price minus the gross purchase price)</summary>
		Public Property [VatMargin] As Byte
		'''<summary>Partial ratio explains which part of the VAT the company has to pay. Used in some branches where the sellers have a bad reputation, so the buyers have to take over the VAT-liability</summary>
		Public Property [VATPartialRatio] As Int16?
		'''<summary>VAT percentages. You can have several VAT percentages, with start and end dates</summary>
		Public Property [VATPercentages] As IEnumerable(Of Models.VAT.VatPercentage)
		'''<summary>Indicates the type of transactions for which the VAT code may be used. B = Both, P = Purchase, S = Sales</summary>
		Public Property [VATTransactionType] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [VatPercentage]
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
		'''<summary>End date of the date range during which this percentage is valid</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Line number</summary>
		Public Property [LineNumber] As Int32?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Percentage</summary>
		Public Property [Percentage] As Double?
		'''<summary>Start date of the date range during which this percentage is valid</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>0 = Normal, 1 = Extra duty</summary>
		Public Property [Type] As Int16
		'''<summary>VAT code</summary>
		Public Property [VATCodeID] As Guid
	End Class

End Namespace