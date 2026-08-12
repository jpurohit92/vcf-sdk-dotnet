# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesResourceNamingStrategy
The Vcenter.Namespaces.Instances.ResourceNamingStrategy enumerated type represents the strategy to generate the Kubernetes resource names in a Supervisor namespace for items in a Content Library associated with the namespace. The relevant Kubernetes resources include namespace scoped ContentLibraryItem, and VirtualMachineImage resources in the namespace.  Possible values:   - `FROM_ITEM_ID`: The naming strategy to generate the Kubernetes resource name based on the corresponding Content Library item identifier.   - `PREFER_ITEM_SOURCE_ID`: The naming strategy to generate the Kubernetes resource name based on the source identifier of the corresponding Content Library item if the Content Library is a subscribed Content Library, otherwise still based on the corresponding Content Library item identifier. With this naming strategy, the Kubernetes resources for images from different subscribed Content Libraries subscribing to the same published Content Library can have the same names across Supervisor namespaces with such subscribed Content Library associated.   Use this strategy if you have multiple Content Libraries that are subscribing to the same published Content Library, and want to consume the same resource names in the namespace for VM images originated from that published Content Library, regardless which Content Library is associated with the namespace.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

