# Vcenter.ViJson.OpenApi.Model.EventDescriptionEventDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Type of event being described.  | 
**Description** | **string** | A string that is a short human-parseable description of the event.  This is not the full message string (which may contain details of the arguments, etc.), but merely a more understandable, and localized, description of what the event stands for. It is meant for contexts where the _name_ of the event has to be displayed to end-users, e.g. when creating Event-based Alarms. \\&#x60; \\*   E.g., for *VmPoweredOnEvent*, the eventDescription in English might say \&quot;VM Powered On\&quot;.  | [optional] 
**Category** | **string** | A category of events.  | 
**FormatOnDatacenter** | **string** | A string that is appropriate in the context of a specific Datacenter.  For example, a renaming event in this context produces the following string:  \&quot;Renamed {vm.name} from {oldName} to {newName}\&quot;  where *oldName* and *newName* are properties of the VmRenamedEvent object.  | 
**FormatOnComputeResource** | **string** | A string that is appropriate in the context of a specific cluster.  For example, a powering on event in this context produces the following string:  \&quot;{vm.name} on {host.name} is powered on\&quot;.  | 
**FormatOnHost** | **string** | A string that is appropriate in the context of a specific Host.  For example, a powering on event in this context produces the following string:  \&quot;{vm.name} is powered on\&quot;  | 
**FormatOnVm** | **string** | A string that is appropriate for the context of a specific virtual machine.  For example, a powering on event in this context produces the following string:  \&quot;Virtual machine on {host.name} is powered on\&quot;  | 
**FullFormat** | **string** | A string whose context is not entity-specific.  For example, a powering on event produces the following string:  \&quot;{vm.name} on {host.name} in {datacenter.name} is powered on\&quot;  | 
**LongDescription** | **string** | A detailed description of the event.  It includes common causes and actions to remediate them. It may also include links to kb articles and other diagnostic information. For example, the BadUserNameSessionEvent may produce the following string:           &lt;EventLongDescription id&#x3D;\&quot;vim.event.BadUserNameSessionEvent\&quot;&gt;             &lt;description&gt;                The user could not be logged in because of an unknown or invalid                user name.             &lt;/description&gt;             &lt;cause&gt;                &lt;description&gt;The user name was unknown to the system&lt;/description&gt;                &lt;action&gt;Use a user name known to the system user directory&lt;/action&gt;                &lt;action&gt;(On Linux) Check if the user directory is correctly                        configured.&lt;/action&gt;                &lt;action&gt;Check the health of the domain controller (if you are using                        Active Directory)&lt;/action&gt;             &lt;/cause&gt;             &lt;cause&gt;                &lt;description&gt;The user provided an invalid password&lt;/description&gt;                &lt;action&gt;Supply the correct password&lt;/action&gt;             &lt;/cause&gt;          &lt;/EventLongDescription&gt;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

