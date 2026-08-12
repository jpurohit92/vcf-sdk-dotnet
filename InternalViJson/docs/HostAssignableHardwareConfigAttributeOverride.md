# Vcenter.ViJson.OpenApi.Model.HostAssignableHardwareConfigAttributeOverride

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceId** | **string** | Instance ID of the Assignable Hardware instance node where the attribute specified by name is overridden.  | 
**Name** | **string** | Name of attribute to override.  | 
**Value** | [**Any**](Any.md) | When AssignableHardwareConfig is a returned data object: Value returned will always be set.  When AssignableHardwareConfig is used as a parameter to an operation updating Assignable Hardware configuration: If value is set, an existing AttributeOverride with matching instanceId and name will have its value updated; if there is no existing AttributeOverride that matches, a new AttributeOverride is created. The type of the value must match the type of the attribute value being overridden. If value is not set, an existing AttributeOverride matching the specified instanceId and name is deleted.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

