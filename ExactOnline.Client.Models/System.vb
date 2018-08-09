Namespace System

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AccountantInfo]
		'''<summary>First address line.</summary>
		Public Property [AddressLine1] As String
		'''<summary>Second address line.</summary>
		Public Property [AddressLine2] As String
		'''<summary>Third address line.</summary>
		Public Property [AddressLine3] As String
		'''<summary>City.</summary>
		Public Property [City] As String
		'''<summary>Email.</summary>
		Public Property [Email] As String
		'''<summary>The account ID of the accountant.</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates if the customer is an accountant himself.</summary>
		Public Property [IsAccountant] As Boolean
		'''<summary>Logo.</summary>
		Public Property [Logo] As Byte()
		'''<summary>Url to retrieve the logo of the accountant.</summary>
		Public Property [MenuLogoUrl] As String
		'''<summary>The name of the accountant.</summary>
		Public Property [Name] As String
		'''<summary>Phone.</summary>
		Public Property [Phone] As String
		'''<summary>Postcode.</summary>
		Public Property [Postcode] As String
		'''<summary>Website.</summary>
		Public Property [Website] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AvailableFeature]
		'''<summary>The description of the feature.</summary>
		Public Property [Description] As String
		'''<summary>The ID of the feature.</summary>
		Public Property [ID] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Code")>
	Public Class [Division]
		'''<summary>Address line 1</summary>
		Public Property [AddressLine1] As String
		'''<summary>Address line 2</summary>
		Public Property [AddressLine2] As String
		'''<summary>Address line 3</summary>
		Public Property [AddressLine3] As String
		'''<summary>Chamber of commerce number</summary>
		Public Property [ChamberOfCommerceNumber] As String
		'''<summary>City</summary>
		Public Property [City] As String
		'''<summary>Primary key</summary>
		Public Property [Code] As Int32
		'''<summary>Country of the division. Is used for determination of legislation</summary>
		Public Property [Country] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime
		'''<summary>Default currency</summary>
		Public Property [Currency] As String
		'''<summary>True when this division is most recently used by the API</summary>
		Public Property [Current] As Boolean
		'''<summary>Owner account of the division</summary>
		Public Property [Customer] As Guid?
		'''<summary>Owner account code of the division</summary>
		Public Property [CustomerCode] As String
		'''<summary>Owner account name of the division</summary>
		Public Property [CustomerName] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Email address</summary>
		Public Property [Email] As String
		'''<summary>Company number that is assigned by the customer</summary>
		Public Property [Hid] As Int64
		'''<summary>True if the division is the main division</summary>
		Public Property [IsMainDivision] As Boolean
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime
		'''<summary>Phone number</summary>
		Public Property [Phone] As String
		'''<summary>Postcode</summary>
		Public Property [Postcode] As String
		'''<summary>State/Province code</summary>
		Public Property [State] As String
		'''<summary>Follow the Division Status 0 for Inactive, 1 for Active and 2 for Archived Divisions</summary>
		Public Property [Status] As Int32
		'''<summary>The number under which the account is known at the Value Added Tax collection agency</summary>
		Public Property [VATNumber] As String
	End Class

End Namespace