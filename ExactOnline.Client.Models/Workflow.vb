Namespace Workflow

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [RequestAttachment]
		'''<summary>The division</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>To get the file in its original format (xml, jpg, pdf, etc.) append &lt;b&gt;&amp;Download=1&lt;/b&gt; to the url.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DownloadUrl] As String
		'''<summary>Filename of the attachment</summary>
		Public Property [FileName] As String
		'''<summary>File size of the attachment</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [FileSize] As Double
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>The request this attachment is linked to</summary>
		Public Property [Request] As Guid?
	End Class

End Namespace