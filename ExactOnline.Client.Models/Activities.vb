Namespace Activities

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [CommunicationNote]
		'''<summary>The account that is related to the communication note</summary>
		Public Property [Account] As Guid?
		'''<summary>The name of the account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Attachments linked to the communication note</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Attachments] As IEnumerable(Of Models.Workflow.RequestAttachment)
		'''<summary>The campaign linked to the communication note</summary>
		Public Property [Campaign] As Guid?
		'''<summary>Description of the campaign</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CampaignDescription] As String
		'''<summary>The contact person that is related to the communication note</summary>
		Public Property [Contact] As Guid?
		'''<summary>The name of the contact person</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactFullName] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>The date</summary>
		Public Property [Date] As DateTime?
		'''<summary>The division</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>The document that is linked to the communication note</summary>
		Public Property [Document] As Guid?
		'''<summary>The subject of the document</summary>
		Public Property [DocumentSubject] As String
		'''<summary>The human readable key</summary>
		Public Property [HID] As Int32?
		'''<summary>The Primary key</summary>
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
		'''<summary>The notes of the communication note</summary>
		Public Property [Notes] As String
		'''<summary>The opportunity linked to the communication note</summary>
		Public Property [Opportunity] As Guid?
		'''<summary>The name of the opportunity</summary>
		Public Property [OpportunityName] As String
		'''<summary>Status: 0 = Void, 5 = Rejected, 10 = Draft, 20 = Open, 30 = Approved, 40 = Realized, 50 = Processed </summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int32?
		'''<summary>The description of the status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<summary>A short description of the communication note</summary>
		Public Property [Subject] As String
		'''<summary>The user that the communication note is assigned to</summary>
		Public Property [User] As Guid?
		'''<summary>The user name</summary>
		Public Property [UserFullName] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Complaint]
		'''<summary>The account that is related to the complaint</summary>
		Public Property [Account] As Guid?
		'''<summary>The name of the account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>The user that the complaint is assigned to</summary>
		Public Property [AssignedTo] As Guid?
		'''<summary>The user name</summary>
		Public Property [AssignedToFullName] As String
		'''<summary>Attachments linked to the complaint</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Attachments] As IEnumerable(Of Models.Workflow.RequestAttachment)
		'''<summary>A short description of the complaint</summary>
		Public Property [Complaint] As String
		'''<summary>The contact person that is related to the complaint</summary>
		Public Property [Contact] As Guid?
		'''<summary>The name of the contact person</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactFullName] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>The division</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>The document that is linked to the complaint</summary>
		Public Property [Document] As Guid?
		'''<summary>The subject of the document</summary>
		Public Property [DocumentSubject] As String
		'''<summary>The human readable key</summary>
		Public Property [HID] As Int32?
		'''<summary>The Primary key</summary>
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
		'''<summary>The date indicating by when the next action has to be taken</summary>
		Public Property [NextAction] As DateTime?
		'''<summary>The notes of the complaint</summary>
		Public Property [Notes] As String
		'''<summary>The date the complaint was received</summary>
		Public Property [ReceiptDate] As DateTime?
		'''<summary>Status: 0 = Void, 5 = Rejected, 10 = Draft, 20 = Open, 30 = Approved, 40 = Realized, 50 = Processed </summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int32?
		'''<summary>The description of the status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Event]
		'''<summary>The account that is related to the event</summary>
		Public Property [Account] As Guid?
		'''<summary>The name of the account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Attachments linked to the event</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Attachments] As IEnumerable(Of Models.Workflow.RequestAttachment)
		'''<summary>The campaign linked to the event</summary>
		Public Property [Campaign] As Guid?
		'''<summary>Description of the campaign</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CampaignDescription] As String
		'''<summary>The contact person that is related to the event</summary>
		Public Property [Contact] As Guid?
		'''<summary>The name of the contact person</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactFullName] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>The description</summary>
		Public Property [Description] As String
		'''<summary>The division</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>The document that is linked to the event</summary>
		Public Property [Document] As Guid?
		'''<summary>The subject of the document</summary>
		Public Property [DocumentSubject] As String
		'''<summary>The end date and time</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>The human readable key</summary>
		Public Property [HID] As Int32?
		'''<summary>The Primary key</summary>
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
		'''<summary>The notes of the event</summary>
		Public Property [Notes] As String
		'''<summary>The opportunity linked to the event</summary>
		Public Property [Opportunity] As Guid?
		'''<summary>The name of the opportunity</summary>
		Public Property [OpportunityName] As String
		'''<summary>The project linked to the event</summary>
		Public Property [Project] As Guid?
		'''<summary>The description of the project</summary>
		Public Property [ProjectDescription] As String
		'''<summary>The start date and time</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Status: 0 = Void, 5 = Rejected, 10 = Draft, 20 = Open, 30 = Approved, 40 = Realized, 50 = Processed </summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int32?
		'''<summary>The description of the status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<summary>The user that has the event</summary>
		Public Property [User] As Guid?
		'''<summary>The user name</summary>
		Public Property [UserFullName] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ServiceRequest]
		'''<summary>The account that is related to the service request</summary>
		Public Property [Account] As Guid?
		'''<summary>The name of the account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>The user that the service request is assigned to</summary>
		Public Property [AssignedTo] As Guid?
		'''<summary>The user name</summary>
		Public Property [AssignedToFullName] As String
		'''<summary>Attachments linked to the service request</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Attachments] As IEnumerable(Of Models.Workflow.RequestAttachment)
		'''<summary>The contact person that is related to the service request</summary>
		Public Property [Contact] As Guid?
		'''<summary>The name of the contact person</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactFullName] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>The description</summary>
		Public Property [Description] As String
		'''<summary>The division</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>The document that is linked to the service request</summary>
		Public Property [Document] As Guid?
		'''<summary>The subject of the document</summary>
		Public Property [DocumentSubject] As String
		'''<summary>The human readable key</summary>
		Public Property [HID] As Int32?
		'''<summary>The Primary key</summary>
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
		'''<summary>The date indicating by when the next action has to be taken</summary>
		Public Property [NextAction] As DateTime?
		'''<summary>The notes of the service request</summary>
		Public Property [Notes] As String
		'''<summary>The date the service request was received</summary>
		Public Property [ReceiptDate] As DateTime?
		'''<summary>Status: 0 = Void, 5 = Rejected, 10 = Draft, 20 = Open, 30 = Approved, 40 = Realized, 50 = Processed </summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int32?
		'''<summary>The description of the status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Task]
		'''<summary>The account that is related to the task</summary>
		Public Property [Account] As Guid?
		'''<summary>The name of the account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>The end date by which the task has to be realized</summary>
		Public Property [ActionDate] As DateTime?
		'''<summary>Attachments linked to the task</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Attachments] As IEnumerable(Of Models.Workflow.RequestAttachment)
		'''<summary>The contact person that is related to the task</summary>
		Public Property [Contact] As Guid?
		'''<summary>The name of the contact person</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactFullName] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Custom type of the task. If both TaskType and CustomTaskType are specified then TaskType is preferred. This value is write-only.</summary>
		Public Property [CustomTaskType] As Guid?
		'''<summary>The description of the task</summary>
		Public Property [Description] As String
		'''<summary>The division of the task</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>The document that is linked to the task</summary>
		Public Property [Document] As Guid?
		'''<summary>The subject of the document</summary>
		Public Property [DocumentSubject] As String
		'''<summary>The human readable key</summary>
		Public Property [HID] As Int32?
		'''<summary>The Primary key</summary>
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
		'''<summary>The notes of the task</summary>
		Public Property [Notes] As String
		'''<summary>The opportunity linked to the task</summary>
		Public Property [Opportunity] As Guid?
		'''<summary>The name of the opportunity</summary>
		Public Property [OpportunityName] As String
		'''<summary>The project linked to the task</summary>
		Public Property [Project] As Guid?
		'''<summary>The description of the project</summary>
		Public Property [ProjectDescription] As String
		'''<summary>Status: 0 = Void, 5 = Rejected, 10 = Draft, 20 = Open, 30 = Approved, 40 = Realized, 50 = Processed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int32?
		'''<summary>The description of the status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<summary>The type of the task. This value is write-only.0 = Other (default), 1 = Call, 2 = Request for information, 3 = Investigate, 4 = Correspondence, 5 = Create an appointment, 6 = Create a quotation</summary>
		Public Property [TaskType] As Int32?
		'''<summary>The description of the type of the task</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaskTypeDescription] As String
		'''<summary>The user that has to realize the task</summary>
		Public Property [User] As Guid?
		'''<summary>The user name</summary>
		Public Property [UserFullName] As String
	End Class

End Namespace