# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsNetworksWorkloadNsxNetwork
  Vcenter.NamespaceManagement.Supervisors.Networks.Workload.NsxNetwork specifies network backing configuration that is specific to the workload network.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dvs** | **string** |   *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.NsxNetwork.dvs* is the Managed Object ID of a vSphere Distributed Virtual Switch. You can use it to connect to an NSX Network.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;vSphereDistributedSwitch&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;vSphereDistributedSwitch&#x60;. | 
**NamespaceSubnetPrefix** | **long** |   *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.NsxNetwork.namespace_subnet_prefix* indicates the size of the subnet reserved for namespace segments.  This property was added in __vSphere API 8.0.0.1__.  Defaults to /28. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

