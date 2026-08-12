# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementInfrastructurePoliciesConfigStatus
The Vcenter.NamespaceManagement.InfrastructurePolicies.ConfigStatus enumerated type defines the states in which infrastructure policy may be.  Possible values:   - `READY`: Infrastructure policy can be attached to vSphere Namespaces.   - `DELETING`: Infrastructure policy is pending deletion and cannot be modified or attached to new vSphere Namespaces, it will be deleted when it is no longer associated with any vSphere Namespace.   - `UNBOUND`: Associated com.vmware.vcenter.compute.Policy no longer exists and infrastructure policy cannot be used with vSphere Namespaces. Infrastructure Policies currently applied to vSphere Namespaces are not applied to workloads.   This enumeration was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

