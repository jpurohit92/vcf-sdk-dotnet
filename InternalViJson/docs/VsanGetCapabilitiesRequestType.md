# Vcenter.ViJson.OpenApi.Model.VsanGetCapabilitiesRequestType
The parameters of *VsanCapabilitySystem.VsanGetCapabilities*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Targets** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | An optional list of targeted managed objects. The supported targets are HostSystem and ClusterComputeResource instances. If a HostSystem is given, the result contains information about the capabilities of this certain host. If a cluster is passed, the result contains information about the capabilities of all hosts that reside in the cluster and the capabilities of the vCenter. If the targets parameter is empty, the result contains only the capabilities of the current vCenter.  ***Required privileges:*** System.Read  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

