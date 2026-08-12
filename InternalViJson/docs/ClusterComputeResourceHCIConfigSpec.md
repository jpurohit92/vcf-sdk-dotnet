# Vcenter.ViJson.OpenApi.Model.ClusterComputeResourceHCIConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DvsProf** | [**List&lt;ClusterComputeResourceDvsProfile&gt;**](ClusterComputeResourceDvsProfile.md) | Information related to network configuration.  For each DvsProfile object, specify either *ClusterComputeResourceDvsProfile.dvsName* or *ClusterComputeResourceDvsProfile.dvSwitch*. Across all DvsProfile objects, specify exactly one *ClusterComputeResourceDvsProfileDVPortgroupSpecToServiceMapping.dvPortgroup* or *ClusterComputeResourceDvsProfileDVPortgroupSpecToServiceMapping.dvPortgroupSpec* per *ClusterComputeResourceDvsProfileDVPortgroupSpecToServiceMapping.service*.  | [optional] 
**HostConfigProfile** | [**ClusterComputeResourceHostConfigurationProfile**](ClusterComputeResourceHostConfigurationProfile.md) | Configuration of host services and host settings.  | [optional] 
**VSanConfigSpec** | [**SDDCBase**](SDDCBase.md) | vSan configuration specification.  This is vim.vsan.ReconfigSpec object represented via the VIM object.  | [optional] 
**VcProf** | [**ClusterComputeResourceVCProfile**](ClusterComputeResourceVCProfile.md) | Describes cluster and EVC configuration.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

