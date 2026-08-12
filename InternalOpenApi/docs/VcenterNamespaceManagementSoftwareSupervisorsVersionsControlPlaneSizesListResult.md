# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsVersionsControlPlaneSizesListResult
The Vcenter.NamespaceManagement.Software.Supervisors.Versions.ControlPlane.Sizes.ListResult schema contains information about all possible sizes for the control plane VM for a specific Supervisor version.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sizes** | [**List&lt;VcenterNamespaceManagementSoftwareSupervisorsVersionsControlPlaneSizesSummary&gt;**](VcenterNamespaceManagementSoftwareSupervisorsVersionsControlPlaneSizesSummary.md) | Information for each size.  This property was added in __vSphere API 9.1.0.0__. | 
**DefaultSizeIdentifier** | **string** | The default size that will be used for enablement if none is provided.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.software.supervisors.versions.control_plane.Size&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.software.supervisors.versions.control_plane.Size&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

