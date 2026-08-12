# Vcenter.ViJson.OpenApi.Model.ClusterConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DasConfig** | [**ClusterDasConfigInfo**](ClusterDasConfigInfo.md) | Cluster-wide configuration of the vSphere HA service.  | 
**DasVmConfig** | [**List&lt;ClusterDasVmConfigInfo&gt;**](ClusterDasVmConfigInfo.md) | List of virtual machine configurations for the vSphere HA service.  Each entry applies to one virtual machine.  If a virtual machine is not specified in this array, the service uses the default settings for that virtual machine.  | [optional] 
**DrsConfig** | [**ClusterDrsConfigInfo**](ClusterDrsConfigInfo.md) | Cluster-wide configuration of the VMware DRS service.  | 
**DrsVmConfig** | [**List&lt;ClusterDrsVmConfigInfo&gt;**](ClusterDrsVmConfigInfo.md) | List of virtual machine configurations for the VMware DRS service.  Each entry applies to one virtual machine.  If a virtual machine is not specified in this array, the service uses the default settings for that virtual machine.  | [optional] 
**Rule** | [**List&lt;ClusterRuleInfo&gt;**](ClusterRuleInfo.md) | Cluster-wide rules.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

