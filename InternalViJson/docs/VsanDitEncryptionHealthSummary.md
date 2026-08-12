# Vcenter.ViJson.OpenApi.Model.VsanDitEncryptionHealthSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | Hostname/IP of host.  | [optional] 
**Health** | **string** | Data-in-transit health status of the host.  See also *VsanHealthStatusType_enum*.  | [optional] 
**Reason** | [**LocalizableMessage**](LocalizableMessage.md) | A message to indicate additional information about the health status.  | [optional] 
**DitEncryptionInfo** | [**VsanInTransitEncryptionInfo**](VsanInTransitEncryptionInfo.md) | Data-in-transit encryption information on the host.  Refer to *VsanInTransitEncryptionInfo*. The data-in-transit encryption information on host will be used for checking the consistency with the cluster configuration on vCenter side.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

