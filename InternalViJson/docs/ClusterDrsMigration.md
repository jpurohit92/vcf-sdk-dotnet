# Vcenter.ViJson.OpenApi.Model.ClusterDrsMigration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | A unique key that identifies this recommendation.  This is used as an argument to ComputeResource.applyRecommendation.  | 
**Time** | **DateTime** | The time this recommendation was computed.  | 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine selected for migration.  Refers instance of *VirtualMachine*.  | 
**CpuLoad** | **int** | Current CPU load for the virtual machine, in MHz.  This property is only populated for recommendations.  | [optional] 
**MemoryLoad** | **long** | Current memory load for the virtual machine, in bytes.  This field is only populated for recommendations.  | [optional] 
**Source** | [**ManagedObjectReference**](ManagedObjectReference.md) | Source host.  Refers instance of *HostSystem*.  | 
**SourceCpuLoad** | **int** | Current CPU load on the source host, in MHz.  | [optional] 
**SourceMemoryLoad** | **long** | Current memory usage on the source host, in bytes.  | [optional] 
**Destination** | [**ManagedObjectReference**](ManagedObjectReference.md) | Destination host.  Refers instance of *HostSystem*.  | 
**DestinationCpuLoad** | **int** | Current CPU load on the destination host, in MHz.  | [optional] 
**DestinationMemoryLoad** | **long** | Current memory usage on the destination host, in bytes.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

