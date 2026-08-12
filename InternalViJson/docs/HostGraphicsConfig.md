# Vcenter.ViJson.OpenApi.Model.HostGraphicsConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostDefaultGraphicsType** | **string** | The host default graphics type.  See *HostGraphicsConfigGraphicsType_enum* for list of supported values. This default value can be overridden by specifying graphics type for an individual device. If host supports a single graphics type, specifying an individual graphics device is optional.  | 
**SharedPassthruAssignmentPolicy** | **string** | The policy for assigning shared passthrough VMs to a host graphics device.  See *HostGraphicsConfigSharedPassthruAssignmentPolicy_enum* for list of supported values.  | 
**DeviceType** | [**List&lt;HostGraphicsConfigDeviceType&gt;**](HostGraphicsConfigDeviceType.md) | Graphics devices and their associated type.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

