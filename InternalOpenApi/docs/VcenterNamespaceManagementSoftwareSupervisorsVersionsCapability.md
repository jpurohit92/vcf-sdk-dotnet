# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsVersionsCapability
The Vcenter.NamespaceManagement.Software.Supervisors.Versions.Capability schema contains the details about the new vSphere Namespaces feature and its compatibility with the current infrastructure.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the vSphere Namespaces feature.  This property was added in __vSphere API 9.0.0.0__. | 
**Status** | **string** | Supportability status of this capability with the current infrastructure (vCenter and NSX versions).  Possible values:   - &#x60;SUPPORTED&#x60;: The Supervisor capability is supported with the current infrastructure (vCenter Server and NSX versions).   - &#x60;SUPPORTED_AND_DEGRADED&#x60;: The Supervisor capability is supported in the given Supervisor version but it is unavailable with the current infrastructure (vCenter Server and NSX versions). However, to make this capability available, the infrastructure upgrade is required.   - &#x60;UNSUPPORTED&#x60;: The Supervisor capability is not supported with the current infrastructure (vCenter Server and NSX versions).   For more information see: *Vcenter.NamespaceManagement.Software.Supervisors.Versions.Status*.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

