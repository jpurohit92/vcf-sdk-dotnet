# Vcenter.ViJson.OpenApi.Model.ClusterVmReadiness

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReadyCondition** | **string** | Ready condition for a virtual machine.  See *ClusterVmReadinessReadyCondition_enum*.  If not specified at either the cluster level or the virtual machine level, this will default to *none*.  | [optional] 
**PostReadyDelay** | **int** | Additional delay in seconds after ready condition is met.  A VM is considered ready at this point.  If not specified in a VM override, cluster default setting is used. Alternatively, set to -1 in per-VM setting to use cluster default value.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

