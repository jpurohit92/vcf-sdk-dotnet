# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementInfrastructurePoliciesEnforcementMode
The Vcenter.NamespaceManagement.InfrastructurePolicies.EnforcementMode enumerated type defines whether a policy will be automatically applied to workloads by default.  Possible values:   - `MANDATORY`: Policy will be automatically evaluated against all workloads in the vSphere Namespace this policy is applied to.   - `OPTIONAL`: A policy will not be applied automatically. A user with access to the vSphere Namespace will be eligible to apply it to any workload in that namespace. The workload must match the conditions defined in *Vcenter.NamespaceManagement.InfrastructurePolicies.MatchSpec* for the policy to be effective.   This enumeration was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

