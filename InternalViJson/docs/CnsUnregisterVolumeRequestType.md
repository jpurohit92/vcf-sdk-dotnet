# Vcenter.ViJson.OpenApi.Model.CnsUnregisterVolumeRequestType
The parameters of *CnsVolumeManager.CnsUnregisterVolume*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnregisterSpec** | [**List&lt;CnsUnregisterVolumeSpec&gt;**](CnsUnregisterVolumeSpec.md) | An array of *CnsUnregisterVolumeSpec* objects, each specifying a unique volume or PVC to be unregistered along with optional parameters for its post-unregistration state. At most one specification is supported for this operation.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

