# Vcenter.ViJson.OpenApi.Model.VAppIPAssignmentInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SupportedAllocationScheme** | **List&lt;string&gt;** | Specifies the IP allocation schemes supported by the guest software.  When updating this field, an empty array will be interpreted as no changes. An array of the form \\[\&quot;\&quot;\\] will clear all settings. Otherwise, the supplied value will overwrite the current setting.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**IpAllocationPolicy** | **string** | Specifies how IP allocation should be managed by the VI platform.  This is typically specified by the deployer. The set of valid options for the policy is based on the capabilities of the vApp software, as specified by the supportedAllocationSchemes property.  Reconfigure privilege: VApp.InstanceConfig  | [optional] 
**SupportedIpProtocol** | **List&lt;string&gt;** | Specifies the IP protocols supported by the guest software.  When updating this field, an empty array will be interpreted as no changes. An array of the form \\[\&quot;\&quot;\\] will clear all settings. Otherwise, the supplied value will overwrite the current setting.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**IpProtocol** | **string** | Specifies the chosen IP protocol for this deployment.  This must be one of the values in the supportedIpProtocol field.  Reconfigure privilege: VApp.InstanceConfig  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

