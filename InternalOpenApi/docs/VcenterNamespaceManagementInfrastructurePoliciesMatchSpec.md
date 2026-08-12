# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementInfrastructurePoliciesMatchSpec
The Vcenter.NamespaceManagement.InfrastructurePolicies.MatchSpec schema defines comprehensive matching criteria for policies.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Op** | **string** | Describes the boolean operation used to evaluate the elements from the match field. This field does not apply to the workload field. It is always boolean AND&#39;d together with the results of the match field.  Possible values:   - &#x60;AND&#x60;: All conditions must match (logical AND).   - &#x60;OR&#x60;: At least one condition must match (logical OR).   For more information see: *Vcenter.NamespaceManagement.InfrastructurePolicies.BooleanOperation*.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, defaults to AND. | [optional] 
**Match** | [**List&lt;VcenterNamespaceManagementInfrastructurePoliciesMatchSpec&gt;**](VcenterNamespaceManagementInfrastructurePoliciesMatchSpec.md) | Describes additional matchers that are evaluated using the boolean operation described by the op field.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no additional matching is performed. | [optional] 
**Workload** | [**VcenterNamespaceManagementInfrastructurePoliciesWorkloadMatchSpec**](VcenterNamespaceManagementInfrastructurePoliciesWorkloadMatchSpec.md) | Matches information about the workload.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no workload matching is performed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

