# Vcenter.ViJson.OpenApi.Model.VsanHclReleaseConstraint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The vSAN cluster.  Refers instance of *ClusterComputeResource*.  | 
**Release** | **string** | Target vSphere release.  | 
**HostDevices** | [**List&lt;VsanHostDeviceInfo&gt;**](VsanHostDeviceInfo.md) | Host devices.  | [optional] 
**Constraints** | [**List&lt;VsanHclDeviceConstraint&gt;**](VsanHclDeviceConstraint.md) | PCI Device HCL constraints.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

