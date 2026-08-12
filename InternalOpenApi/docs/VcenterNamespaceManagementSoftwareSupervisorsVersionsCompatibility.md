# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsVersionsCompatibility
The Vcenter.NamespaceManagement.Software.Supervisors.Versions.Compatibility enumerated type represents the compatibility of a Supervisor image with the current infrastructure.  Possible values:   - `COMPATIBLE`: The Supervisor image is compatible with the current infrastructure (vCenter Server, ESX and NSX versions).   - `COMPATIBLE_AND_DEGRADED`: The Supervisor image is compatible with the current infrastructure and will continue to work after the Supervisor upgrade. However, few new features released as part of Supervisor release may not be available until the vCenter is upgraded.   - `INCOMPATIBLE`: The Supervisor image is incompatible with the current infrastructure.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

