# Vcenter.ViJson.OpenApi.Model.ClusterComputeResourceHCIConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkflowState** | **string** | Configuration pertinent to state of the HCI workflow.  Valid values are enumerated by the *HCIWorkflowState* type.  | 
**DvsSetting** | [**List&lt;ClusterComputeResourceDVSSetting&gt;**](ClusterComputeResourceDVSSetting.md) | Contains DVS related information captured while configuring the cluster.  | [optional] 
**ConfiguredHosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Contains a list of hosts that are currently configured using *ClusterComputeResource.ConfigureHCI_Task* and *ClusterComputeResource.ExtendHCI_Task* method.  A failed host will not be part of this list.  Refers instances of *HostSystem*.  | [optional] 
**HostConfigProfile** | [**ClusterComputeResourceHostConfigurationProfile**](ClusterComputeResourceHostConfigurationProfile.md) | Configuration of host services and host settings.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

