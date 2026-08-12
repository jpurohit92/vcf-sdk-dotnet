# Vcenter.ViJson.OpenApi.Model.QueryCompatibleHostForNewDvsRequestType
The parameters of *DistributedVirtualSwitchManager.QueryCompatibleHostForNewDvs*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Container** | [**ManagedObjectReference**](ManagedObjectReference.md) | Where to look for hosts. Supported types of objects for this parameter are *Datacenter*, *ComputeResource* and *Folder*.  Refers instance of *ManagedEntity*.  | 
**Recursive** | **bool** | Whether to search for hosts in the subfolders, if applicable. In the case when container is a *Datacenter*, the recursive flag is applied to its HostFolder.  | 
**SwitchProductSpec** | [**DistributedVirtualSwitchProductSpec**](DistributedVirtualSwitchProductSpec.md) | The productSpec of a *DistributedVirtualSwitch*. If not set, it is assumed to be the default one used for DistributedVirtualSwitch creation.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

