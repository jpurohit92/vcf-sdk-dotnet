# Vcenter.ViJson.OpenApi.Model.VirtualEthernetCardNetworkBackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | The name of the device on the host system.  | 
**UseAutoDetect** | **bool** | Indicates whether the device should be auto detected instead of directly specified.  If this value is set to TRUE, deviceName is ignored.  | [optional] 
**Network** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the network managed object to which this backing applies.  This is not used during configuration.  Refers instance of *Network*.  | [optional] 
**InPassthroughMode** | **bool** | Deprecated as of vSphere API 4.0, this property is not supported. &amp;nbsp;.  &amp;nbsp;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

