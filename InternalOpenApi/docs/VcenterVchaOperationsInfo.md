# Vcenter.Automation.OpenApi.Model.VcenterVchaOperationsInfo
The Vcenter.Vcha.Operations.Info schema contains information about which the VCHA operations cannot be invoked in the current state of the system and the list of currently active VCHA operations.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Disabled** | **List&lt;string&gt;** | Identifiers of the operations that are current disabled. These operation strings are one of *Vcenter.Vcha.Operations.CLUSTER_DEPLOY_OP*, *Vcenter.Vcha.Operations.CLUSTER_FAILOVER_OP*, *Vcenter.Vcha.Operations.PASSIVE_REDEPLOY_OP*, *Vcenter.Vcha.Operations.WITNESS_REDEPLOY_OP*, *Vcenter.Vcha.Operations.MODE_SET_OP*, *Vcenter.Vcha.Operations.CLUSTER_UNDEPLOY_OP* and *Vcenter.Vcha.Operations.CLUSTER_GET_OP*.  This property was added in __vSphere API 6.7.1__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vapi.operation&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vapi.operation&#x60;. | 
**Active** | **List&lt;string&gt;** | Identifiers of the operations that are currently running. These operation strings are one of *Vcenter.Vcha.Operations.CLUSTER_DEPLOY_OP*, *Vcenter.Vcha.Operations.CLUSTER_FAILOVER_OP*, *Vcenter.Vcha.Operations.PASSIVE_REDEPLOY_OP*, *Vcenter.Vcha.Operations.WITNESS_REDEPLOY_OP*, *Vcenter.Vcha.Operations.MODE_SET_OP*, and *Vcenter.Vcha.Operations.CLUSTER_UNDEPLOY_OP*.  This property was added in __vSphere API 6.7.1__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vapi.operation&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vapi.operation&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

