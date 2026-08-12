# Vcenter.ViJson.OpenApi.Model.VsanVssMigrateVdsRequestType
The parameters of *VsanVdsSystem.VsanVssMigrateVds*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | Hosts of this cluster will be migrated from the specified VDS to the new VSS.  Refers instance of *ComputeResource*.  | [optional] 
**Hosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Individual hosts to be migrated from the VDS to the VSS.  Refers instances of *HostSystem*.  | [optional] 
**Vds** | [**ManagedObjectReference**](ManagedObjectReference.md) | The VDS which the hosts in the cluster are connected to.  Refers instance of *VmwareDistributedVirtualSwitch*.  | 
**VswitchName** | **string** | Name of the new VSS to be migrated to.  | [optional] 
**VmnicDevices** | **List&lt;string&gt;** | Physical NICs that are currently unused to be attached to the new VSS.  | [optional] 
**InfraVm** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Infrastructure VMs that will be handled specially during migration.  Refers instances of *VirtualMachine*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

