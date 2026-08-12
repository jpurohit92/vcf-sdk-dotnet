# Vcenter.ViJson.OpenApi.Model.FeatureEVCMode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Enumeration or literal ID being described.  | 
**Mask** | [**List&lt;HostFeatureMask&gt;**](HostFeatureMask.md) | The masks (modifications to a host&#39;s feature capabilities) that limit a host&#39;s capabilities to that of the EVC mode baseline.  | [optional] 
**Capability** | [**List&lt;HostFeatureCapability&gt;**](HostFeatureCapability.md) | Describes the feature capability baseline associated with the EVC mode.  On the cluster where a particular EVC mode is configured, these features capabilities are guaranteed, either because the host hardware naturally matches those features or because feature masks are used to mask out differences and enforce a match.  | [optional] 
**Requirement** | [**List&lt;VirtualMachineFeatureRequirement&gt;**](VirtualMachineFeatureRequirement.md) | The conditions that must be true of a host&#39;s feature capabilities in order for the host to meet the minimum requirements of the EVC mode baseline.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

