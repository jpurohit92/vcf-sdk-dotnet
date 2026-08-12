# Vcenter.ViJson.OpenApi.Model.Extension

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | [**Description**](Description.md) | Description of extension.  | 
**Key** | **string** | Extension key.  Should follow java package naming conventions for uniqueness (e.g. \&quot;com.example.management\&quot;).  Extension names can only contain characters belonging to the lower ASCII character set (UTF-7) with the exception of the following characters: 1. All whitespace characters (\&quot;space\&quot; - ascii character 0x20 is allowed) 2. Control characters 3. Comma (ascii 0x2c), Forward slash (ascii 0x2f), Backward slash (ascii 0x5c),    Hash/Pound (ascii 0x23), Plus (ascii 0x2b), Greater (ascii 0x3e), Lesser (ascii 0x3c),    Equals (ascii 0x3d), Semi-colon (ascii 0x3b) and Double quote (ascii 0x22).  | 
**Company** | **string** | Company information.  | [optional] 
**Type** | **string** | Type of extension (example may include CP-DVS, NUOVA-DVS, etc.).  | [optional] 
**VarVersion** | **string** | Extension version number as a dot-separated string.  For example, \&quot;1.0.0\&quot;  | 
**SubjectName** | **string** | Subject name from client certificate.  | [optional] 
**Server** | [**List&lt;ExtensionServerInfo&gt;**](ExtensionServerInfo.md) | Servers for this extension.  | [optional] 
**VarClient** | [**List&lt;ExtensionClientInfo&gt;**](ExtensionClientInfo.md) | Clients for this extension.  | [optional] 
**TaskList** | [**List&lt;ExtensionTaskTypeInfo&gt;**](ExtensionTaskTypeInfo.md) | Definitions of tasks defined by this extension.  | [optional] 
**EventList** | [**List&lt;ExtensionEventTypeInfo&gt;**](ExtensionEventTypeInfo.md) | Definitions of events defined by this extension.  | [optional] 
**FaultList** | [**List&lt;ExtensionFaultTypeInfo&gt;**](ExtensionFaultTypeInfo.md) | Definitions of faults defined by this extension.  | [optional] 
**PrivilegeList** | [**List&lt;ExtensionPrivilegeInfo&gt;**](ExtensionPrivilegeInfo.md) | Definitions privileges defined by this extension.  | [optional] 
**ResourceList** | [**List&lt;ExtensionResourceInfo&gt;**](ExtensionResourceInfo.md) | Resource data for all locales  | [optional] 
**LastHeartbeatTime** | **DateTime** | Last extension heartbeat time.  | 
**HealthInfo** | [**ExtensionHealthInfo**](ExtensionHealthInfo.md) | Health specification provided by this extension.  | [optional] 
**OvfConsumerInfo** | [**ExtensionOvfConsumerInfo**](ExtensionOvfConsumerInfo.md) | OVF consumer specification provided by this extension.  | [optional] 
**ExtendedProductInfo** | [**ExtExtendedProductInfo**](ExtExtendedProductInfo.md) | Extended product information, such as URLs to vendor, product, etc.  | [optional] 
**ManagedEntityInfo** | [**List&lt;ExtManagedEntityInfo&gt;**](ExtManagedEntityInfo.md) | Information about entities managed by this extension.  An extension can register virtual machines as managed by itself, by setting the *managedBy* property of the virtual machine.  | [optional] 
**ShownInSolutionManager** | **bool** | Opt-in to the Solution Manager.  If set to true, this extension will be shown in the Solution Manager. If not set, or set to false, this extension is not shown in the Solution Manager.  | [optional] 
**SolutionManagerInfo** | [**ExtSolutionManagerInfo**](ExtSolutionManagerInfo.md) | Solution Manager configuration for this extension.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

