# Vcenter.ViJson.OpenApi.Model.ClusterPreemptibleVmPairInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Server-assigned unique ID for pairs.  When adding a new pair, do not specify this property. The server will assign the key and any assigned value will be ignored.  | [optional] 
**MonitoredVm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine whose failure will cause the virtual machine specified by *ClusterPreemptibleVmPairInfo.preemptibleVm* to be terminated.  Refers instance of *VirtualMachine*.  | 
**PreemptibleVm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The preemptible virtual machine associated with the virtual machine specified as *ClusterPreemptibleVmPairInfo.monitoredVm*.  Refers instance of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

