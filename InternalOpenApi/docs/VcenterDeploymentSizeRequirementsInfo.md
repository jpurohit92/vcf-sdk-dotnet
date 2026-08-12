# Vcenter.Automation.OpenApi.Model.VcenterDeploymentSizeRequirementsInfo
The {name RequirementsInfo} schema contains the details about the requirements that are needed to scale up the vCenter to a given deployment size  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExtraCpuCountNeeded** | **long** | Extra number of CPUs for a given deployment type.  This property was added in __vSphere API 9.1.0.0__. | 
**ExtraMemoryNeeded** | [**VcenterDeploymentMemoryDimension**](VcenterDeploymentMemoryDimension.md) | Extra memory or RAM for a given deployment type  This property was added in __vSphere API 9.1.0.0__. | 
**ExtraTotalDiskSpaceNeeded** | [**VcenterDeploymentDiskDimension**](VcenterDeploymentDiskDimension.md) | Extra disk space needed for a given deployment size.  This property was added in __vSphere API 9.1.0.0__. | 
**RestartRequired** | **bool** | Flag to indicate whether vCenter restart is needed  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

