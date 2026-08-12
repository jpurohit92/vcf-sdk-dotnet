# Vcenter.ViJson.OpenApi.Model.SolutionsSolutionConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Solution** | **string** | Solution, this configuration belongs to.  | 
**DisplayName** | **string** | Display name of the solution.  | 
**DisplayVersion** | **string** | Display version of the solution.  | 
**VmSource** | [**SolutionsVMSource**](SolutionsVMSource.md) | Source of the system Virtual Machine files.  | 
**PrefixVmName** | **string** | VM name prefix.  | 
**UuidVmName** | **bool** | If set to &#x60;True&#x60; - will insert an UUID in the system Virtual Machines&#39; names created for the solution, otherwise - no additional UUID will be inserted in the system Virtual Machines&#39; names.  | 
**ResourcePool** | [**ManagedObjectReference**](ManagedObjectReference.md) | Resource pool to place the system Virtual Machine in.  If omitted a default resource pool will be used.  Refers instance of *ResourcePool*.  | [optional] 
**Folder** | [**ManagedObjectReference**](ManagedObjectReference.md) | Folder to place the system Virtual Machine in.  If omitted a default folder will be used.  Refers instance of *Folder*.  | [optional] 
**OvfProperties** | [**List&lt;SolutionsOvfProperty&gt;**](SolutionsOvfProperty.md) | User configurable OVF properties to be assigned during system Virtual Machine creation.  | [optional] 
**StoragePolicies** | [**List&lt;SolutionsStoragePolicy&gt;**](SolutionsStoragePolicy.md) | Storage policies to be applied during system Virtual Machine creation.  | [optional] 
**VmDiskProvisioning** | **string** | Provisioning type for the system Virtual Machines *SolutionsVMDiskProvisioning_enum*.  Default provisioning will be used if not specified.  | [optional] 
**VmDeploymentOptimization** | **string** | Optimization strategy for deploying Virtual Machines *SolutionsVMDeploymentOptimization_enum*.  Default optimization will be selected if not specified.  | [optional] 
**TypeSpecificConfig** | [**SolutionsTypeSpecificSolutionConfig**](SolutionsTypeSpecificSolutionConfig.md) | Solution type-specific configuration.  | 
**Hooks** | [**List&lt;SolutionsHookConfig&gt;**](SolutionsHookConfig.md) | Lifecycle hooks for the solution&#39;s virtual machines.  | [optional] 
**VmResourceSpec** | [**SolutionsVmResourceSpec**](SolutionsVmResourceSpec.md) | VMs resource configuration.  If omitted - the default resource configuration specified in the OVF descriptor is used.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

