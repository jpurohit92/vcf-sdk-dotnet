# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesVsphereNetworkConfigCreateSpec
The Vcenter.Namespaces.Instances.VsphereNetworkConfigCreateSpec schema contains *Vcenter.Namespaces.Instances.NetworkProvider.VSPHERE_NETWORK* network configurations that can be applied to a vSphere Namespace.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultWorkloadNetwork** | **string** | The default workload network to be used for workloads when they do not explicitly specify a network placement. This value must reference one of the networks provided in *Vcenter.Namespaces.Instances.CreateSpecCore.networks*.   This field does not allow update once applied. Additionally, this network cannot be removed from this vSphere Namespace.   A network with *Vcenter.NamespaceManagement.Networks.IPAssignmentMode.NONE* IP assignment mode may not be set as the default workload network.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;:     - When *Vcenter.Namespaces.Instances.CreateSpecCore.networks* is specified: the first network will be selected as the default network    - When *Vcenter.Namespaces.Instances.CreateSpecCore.networks* is unset: the Supervisor Primary Workload Network will be used       This field must be unset if *Vcenter.Namespaces.Instances.CreateSpecCore.networks* is unset.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.Network&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.Network&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

