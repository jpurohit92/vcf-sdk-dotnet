# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementInfrastructurePoliciesWorkloadMatchSpec
The Vcenter.NamespaceManagement.InfrastructurePolicies.WorkloadMatchSpec schema defines selection criteria for workloads. All the specified criteria must match.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Guest** | [**VcenterNamespaceManagementInfrastructurePoliciesGuestMatchSpec**](VcenterNamespaceManagementInfrastructurePoliciesGuestMatchSpec.md) | Matches information about the workload&#39;s guest operating system.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no guest matching is performed. | [optional] 
**Labels** | [**List&lt;VcenterNamespaceManagementInfrastructurePoliciesLabelSelectorRequirement&gt;**](VcenterNamespaceManagementInfrastructurePoliciesLabelSelectorRequirement.md) | Matches labels on the workload in question.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no label matching is performed. | [optional] 
**Kind** | **string** | Describes the kind of workload to restrict the matching to.  Possible values:   - &#x60;VIRTUAL_MACHINE&#x60;: Virtual Machine workload.   For more information see: *Vcenter.NamespaceManagement.InfrastructurePolicies.WorkloadKind*.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, all workload kinds are matched. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

