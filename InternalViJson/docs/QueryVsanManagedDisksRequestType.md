# Vcenter.ViJson.OpenApi.Model.QueryVsanManagedDisksRequestType
The parameters of *VimClusterVsanVcDiskManagementSystem.QueryVsanManagedDisks*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Target host to query.  ***Required privileges:*** System.Read  Refers instance of *HostSystem*.  | 
**FilterSpec** | [**VimVsanHostQueryVsanDisksSpec**](VimVsanHostQueryVsanDisksSpec.md) | Specification to filter vSAN disks. This spec can be used to filter query results by disktype types (diskGroup/storagePool/directDisk) or by diskName. If this spec is not specified, it will return all vSAN disks in the cluster. Refer *VimVsanHostQueryVsanDisksSpec* for more details.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

