# Vcenter.Automation.OpenApi.Model.VcenterVchaClusterWitnessCheckSpec
The Vcenter.Vcha.Cluster.Witness.CheckSpec schema contains placement information for validation.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VcSpec** | [**VcenterVchaCredentialsSpec**](VcenterVchaCredentialsSpec.md) | Contains the active node&#39;s management vCenter server credentials.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then the active vCenter Server instance is assumed to be either self-managed or else in enhanced linked mode and managed by a linked vCenter Server instance. | [optional] 
**Placement** | [**VcenterVchaPlacementSpec**](VcenterVchaPlacementSpec.md) | Contains the node&#39;s placement information for validation.  This property was added in __vSphere API 6.7.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

