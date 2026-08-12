# Vcenter.ViJson.OpenApi.Model.VsanReconfigureFileShareRequestType
The parameters of *VsanFileServiceSystem.VsanReconfigureFileShare*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareUuid** | **string** | The UUID of the file share to be reconfigured.  | 
**Config** | [**VsanFileShareConfig**](VsanFileShareConfig.md) | The file services configuration. Only set the fields that require reconfiguration, and leave the others unset. This API will update or create the labels specified in the config. Labels to be deleted should be specified in the &#39;deleteLabelKeys&#39; parameter. Other labels will remain intact.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster. Ignored when called on ESXi hosts.  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | [optional] 
**DeleteLabelKeys** | **List&lt;string&gt;** | The keys of share labels to be deleted. If a specified label key does not exist in the file share, the deletion of this label will be ignored.  | [optional] 
**Force** | **bool** | The force flag is to force the reconfiguration of a vSphere managed file share, for example, the file share managed by Cloud Native Storage (CNS) service.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

