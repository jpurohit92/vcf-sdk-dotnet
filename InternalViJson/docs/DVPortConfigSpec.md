# Vcenter.ViJson.OpenApi.Model.DVPortConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operation** | **string** | The operation to remove or modify the existing ports.  The valid values are: - *edit* - *remove*  | 
**Key** | **string** | Key of the port to be reconfigured.  | [optional] 
**Name** | **string** | The name of the port.  | [optional] 
**Scope** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Deprecated as of vSphere API 5.5.  The eligible entities that can connect to the port, for detail see *DVPortConfigInfo.scope*.  Refers instances of *ManagedEntity*.  | [optional] 
**Description** | **string** | The description string of the port.  | [optional] 
**Setting** | [**DVPortSetting**](DVPortSetting.md) | The network setting of the port.  | [optional] 
**ConfigVersion** | **string** | The version string of the configuration.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

