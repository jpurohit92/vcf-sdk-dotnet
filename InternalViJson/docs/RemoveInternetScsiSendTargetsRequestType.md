# Vcenter.ViJson.OpenApi.Model.RemoveInternetScsiSendTargetsRequestType
The parameters of *HostStorageSystem.RemoveInternetScsiSendTargets*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IScsiHbaDevice** | **string** | The device of the Internet SCSI HBA adapter.  | 
**Targets** | [**List&lt;HostInternetScsiHbaSendTarget&gt;**](HostInternetScsiHbaSendTarget.md) | An array of iSCSI send targets to remove.  | 
**Force** | **bool** | flag for forced removal of iSCSI send targets. If unset, force flag will be treated as false.  ***Since:*** vSphere API Release 7.0.1.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

