# Vcenter.Automation.OpenApi.Model.VcenterVchaClusterDeploySpec
The Vcenter.Vcha.Cluster.DeploySpec schema contains the deploy specification for the three nodes of a VCHA cluster.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VcSpec** | [**VcenterVchaCredentialsSpec**](VcenterVchaCredentialsSpec.md) | Contains the active node&#39;s management vCenter server credentials.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then the active vCenter Server instance is assumed to be either self-managed or else in enhanced linked mode and managed by a linked vCenter Server instance. | [optional] 
**Deployment** | **string** | Contains the deployment type.  Possible values:   - &#x60;AUTO&#x60;: Passive and witness nodes are cloned automatically.   - &#x60;MANUAL&#x60;: Passive and witness nodes are not cloned automatically. After deployment, the customer should clone the passive and witness virtual machines.   For more information see: *Vcenter.Vcha.Cluster.Type*.  This property was added in __vSphere API 6.7.1__. | 
**Active** | [**VcenterVchaClusterActiveSpec**](VcenterVchaClusterActiveSpec.md) | Contains the active node&#39;s network configuration.  This property was added in __vSphere API 6.7.1__. | 
**Passive** | [**VcenterVchaClusterPassiveSpec**](VcenterVchaClusterPassiveSpec.md) | Contains the passive node&#39;s placement configuration.  This property was added in __vSphere API 6.7.1__. | 
**Witness** | [**VcenterVchaClusterWitnessSpec**](VcenterVchaClusterWitnessSpec.md) | Contains the witness node&#39;s placement configuration.  This property was added in __vSphere API 6.7.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

