# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsPrechecksFilterSpec
The Vcenter.NamespaceManagement.Software.Supervisors.Prechecks.FilterSpec schema contains request filter(s) for fetching the Supervisor upgrade pre-checks.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetVersion** | **string** | Supervisor upgrade version for which pre-check results should be queried.  This property was added in __vSphere API 8.0.3.0__.  If set, return the pre-check results only for the specified target version. If missing or &#x60;null&#x60;, return the pre-check results for all the Supervisor upgrade versions against which pre-checks have already been executed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

