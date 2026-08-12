# Vcenter.Automation.OpenApi.Model.VcenterNamespacesManagementServicesAccessGrantsWorkloadSelectorUpdateSpec
The Vcenter.Namespaces.ManagementServices.AccessGrants.WorkloadSelectorUpdateSpec schema contains updated selection specifications of workloads that will receive the grant.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The Vcenter.Namespaces.ManagementServices.AccessGrants.WorkloadType enumerated type of workloads that will receive this grant.  Possible values:   - &#x60;VIRTUAL_MACHINE&#x60;: Scope grant to Virtual Machines managed by VM Service.   - &#x60;VSPHERE_POD&#x60;: Scope grant to vSphere Pods.   - &#x60;ANY&#x60;: Scope grant to any type of workloads in the namespace. Note that ANY WorkloadType evaluates to workloads of any current and future WorkloadTypes.   For more information see: *Vcenter.Namespaces.ManagementServices.AccessGrants.WorkloadType*.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the existing value will be unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

