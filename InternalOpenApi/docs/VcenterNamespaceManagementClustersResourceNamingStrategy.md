# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClustersResourceNamingStrategy
The Vcenter.NamespaceManagement.Clusters.ResourceNamingStrategy enumerated type represents the strategy to generate the Kubernetes resource names in a Supervisor for items in a Content Library associated with the Supervisor. The relevant Kubernetes resources include cluster scoped ClusterContentLibraryItem, and ClusterVirtualMachineImage resources in the Supervisor.  Possible values:   - `FROM_ITEM_ID`: The naming strategy to generate the Kubernetes resource name based on the corresponding Content Library item identifier.   - `PREFER_ITEM_SOURCE_ID`: The naming strategy to generate the Kubernetes resource name based on the source identifier of the corresponding Content Library item if the Content Library is a subscribed Content Library, otherwise still based on the corresponding Content Library item identifier. With this naming strategy, the Kubernetes resources for images from different subscribed Content Libraries subscribing to the same published Content Library can have the same names across Supervisors with such subscribed Content Library associated.   Use this strategy if you have multiple Content Libraries that are subscribing to the same published Content Library, and want to consume the same resource names in the Supervisor for VM images originated from that published Content Library, regardless which Content Library is associated with the Supervisor.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

