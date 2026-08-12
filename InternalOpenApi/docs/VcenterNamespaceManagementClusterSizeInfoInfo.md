# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClusterSizeInfoInfo
The Vcenter.NamespaceManagement.ClusterSizeInfo.Info schema contains the information about limits associated with a Vcenter.NamespaceManagement.SizingHint.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumSupportedPods** | **long** | The maximum number of supported pods.  This property was added in __vSphere API 7.0.0.0__. | 
**NumSupportedServices** | **long** | The maximum number of supported services.  This property was added in __vSphere API 7.0.0.0__. | 
**DefaultServiceCidr** | [**VcenterNamespaceManagementIpv4Cidr**](VcenterNamespaceManagementIpv4Cidr.md) | Default CIDR range from which Kubernetes allocates service cluster IP addresses.  This property was added in __vSphere API 7.0.0.0__. | 
**DefaultPodCidr** | [**VcenterNamespaceManagementIpv4Cidr**](VcenterNamespaceManagementIpv4Cidr.md) | Default CIDR range from which Kubernetes allocates pod IP addresses.  This property was added in __vSphere API 7.0.0.0__. | 
**MasterVmInfo** | [**VcenterNamespaceManagementClusterSizeInfoVmInfo**](VcenterNamespaceManagementClusterSizeInfoVmInfo.md) | Information about Kubernetes API server virtual machine configuration.  This property was added in __vSphere API 7.0.0.0__. | 
**WorkerVmInfo** | [**VcenterNamespaceManagementClusterSizeInfoVmInfo**](VcenterNamespaceManagementClusterSizeInfoVmInfo.md) | Information about worker virtual machine configuration.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the configuration of the worker VM is not fixed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

