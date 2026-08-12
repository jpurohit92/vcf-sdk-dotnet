# Vcenter.ViJson.OpenApi.Model.VsanAddStoragePoolDiskRequestType
The parameters of *VimClusterVsanVcDiskManagementSystem.VsanAddStoragePoolDisk*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Specs** | [**List&lt;VsanAddStoragePoolDiskSpec&gt;**](VsanAddStoragePoolDiskSpec.md) | The specifications to add disks to vSAN storage pool. Please reference to VimVsanHostAddStoragePoolDiskSpec. Multiple specs can be used by AddStoragePoolDisks to add disks on different hosts in one API call. All hosts should in same vSAN cluster.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

