# Vcenter.ViJson.OpenApi.Model.VsanPolicySatisfiability

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | UUID of the object.  | [optional] 
**IsSatisfiable** | **bool** | Can the policy be satisfied given the assumptions of the API that queried satisfiability.  See also *HostVsanInternalSystem.ReconfigurationSatisfiable*.  | 
**Reason** | [**LocalizableMessage**](LocalizableMessage.md) | Reason for not being able to satisfy the policy; This is unset if policy can be satisfied.  | [optional] 
**Cost** | [**VsanPolicyCost**](VsanPolicyCost.md) | Cost of satisfying the new policy; This is unset if policy cannot be satisfied.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

