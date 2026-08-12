# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsWorkloadsImagesSettingsInfo
The Vcenter.NamespaceManagement.Supervisors.Workloads.Images.Settings.Info schema provides information about the current images configuration for Virtual Machines, Kubernetes nodes, and vSphere Pods on a Supervisor's workload components.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Registry** | [**VcenterNamespaceManagementSupervisorsWorkloadsImagesSettingsImageRegistry**](VcenterNamespaceManagementSupervisorsWorkloadsImagesSettingsImageRegistry.md) | The *Vcenter.NamespaceManagement.Supervisors.Workloads.Images.Settings.Info.registry* schema contains the specification required to configure a vSphere Pods image registry endpoint.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, defaults to Docker Hub (&#x60;docker.io&#x60;). | [optional] 
**Repository** | **string** | The *Vcenter.NamespaceManagement.Supervisors.Workloads.Images.Settings.Info.repository* specifies the default vSphere Pods image repository to use when a vSphere Pod specification does not specify it. For example, &#x60;hub.docker.com&#x60; is the image repository for a vSphere Pod whose image specification is &#x60;hub.docker.com/nginx&#x60;.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, defaults to &#x60;&#39;library&#39;&#x60; when Docker Hub is the registry, and is empty otherwise. | [optional] 
**ContentLibraries** | [**List&lt;VcenterNamespaceManagementSupervisorsWorkloadsImagesSettingsContentLibrarySpec&gt;**](VcenterNamespaceManagementSupervisorsWorkloadsImagesSettingsContentLibrarySpec.md) | *Vcenter.NamespaceManagement.Supervisors.Workloads.Images.Settings.Info.content_libraries* is a list of Content Libraries that are associated with the Supervisor&#39;s workload components. This list refers to existing Content Libraries in the vSphere inventory. These Content Libraries and the Content Library items belonging to them will be read-only across all vSphere Namespaces, and will be used as images for Virtual Machines and Kubernetes nodes.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no content libraries are associated with the Supervisor workload components. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

