# Vcenter.Automation.OpenApi.Model.VapiMetadataPrivilegeServiceInfo
The Vapi.Metadata.Privilege.ServiceInfo schema contains privilege information of a service element.    For an explanation of privilege information contained within service elements, see *Vapi.Metadata.Privilege.Service*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operations** | [**Dictionary&lt;string, VapiMetadataPrivilegeOperationInfo&gt;**](VapiMetadataPrivilegeOperationInfo.md) | Information about all operation elements contained in this service element that contain privilege information. The key in the map is the identifier of the operation element and the value in the map is the privilege information for the operation element.    For an explanation of containment of privilege information within operation elements, see *Vapi.Metadata.Privilege.Service.Operation*.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.vapi.operation&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.vapi.operation&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

