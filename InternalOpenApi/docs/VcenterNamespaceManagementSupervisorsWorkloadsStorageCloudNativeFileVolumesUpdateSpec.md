# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsWorkloadsStorageCloudNativeFileVolumesUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.Workloads.Storage.CloudNative.FileVolumes.UpdateSpec schema contains the specification required to activate the FileVolumes support for the given Supervisor.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileVolumesEnabled** | **bool** | Indicates whether Cloud Native File Volume is enabled on the Supervisor. This feature provides support for provisioning ReadWriteMany persistent volumes on this Supervisor.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no change will be performed to accommodate future properties that may be selectively specified in this spec. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

