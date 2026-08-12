# Vcenter.ViJson.OpenApi.Model.VsanVdsGetMigrationPlanRequestType
The parameters of *VsanVdsSystem.VsanVdsGetMigrationPlan*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | Hosts of this cluster will be migrated to the new VDS  ***Required privileges:*** System.Read  Refers instance of *ComputeResource*.  | 
**VswitchName** | **string** | Name of the original VSS vSwitch  | [optional] 
**VdsName** | **string** | Name of the new VDS. Only required for the creation of a new VDS  | [optional] 
**VmnicDevices** | **List&lt;string&gt;** | Physical NICs that are currently unused to be attached to the new vDS.  | [optional] 
**InfraVm** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Infrastructure VMs that will be handled specially during migration.  Refers instances of *VirtualMachine*.  | [optional] 
**Vds** | [**ManagedObjectReference**](ManagedObjectReference.md) | The VDS which the hosts are connected to. Set this parameter when existing VDS can be leveraged.  Refers instance of *VmwareDistributedVirtualSwitch*.  | [optional] 
**Hosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | hosts in the cluster to be migrated to the VDS. Leave this field empty if all the hosts in the cluster needs to be migrated.  Refers instances of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

