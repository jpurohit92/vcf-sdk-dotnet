# Vcenter.ViJson.OpenApi.Model.OvfValidateHostResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DownloadSize** | **long** | The total amount of data that must be transferred to download the entity.  This may be inaccurate due to disk compression etc.  | [optional] 
**FlatDeploymentSize** | **long** | The total amount of space required to deploy the entity if using flat disks.  | [optional] 
**SparseDeploymentSize** | **long** | The total amount of space required to deploy the entity using sparse disks, if known.  | [optional] 
**Error** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Errors that happened during validation.  The presence of faults in this list indicates that the validation failed.  | [optional] 
**Warning** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Non-fatal warnings from the validation.  | [optional] 
**SupportedDiskProvisioning** | **List&lt;string&gt;** | An array of the disk provisioning type supported by the target host system.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

