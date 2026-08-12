# Vcenter.ViJson.OpenApi.Model.VmPodConfigForPlacement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StoragePod** | [**ManagedObjectReference**](ManagedObjectReference.md) | The pod that this initial configuration applies to.  Since there could be multiple pods in a single placement request, we may need to specify multiple initial VM configurations, one per pod.  Refers instance of *StoragePod*.  | 
**Disk** | [**List&lt;PodDiskLocator&gt;**](PodDiskLocator.md) | Array of PodDiskLocator objects.  | [optional] 
**VmConfig** | [**StorageDrsVmConfigInfo**](StorageDrsVmConfigInfo.md) | The VM configuration for the VM that is being placed.  | [optional] 
**InterVmRule** | [**List&lt;ClusterRuleInfo&gt;**](ClusterRuleInfo.md) | The initial interVmRules that should during placement of this virtual machine.  It may not always be possible to specify that the virtual machine being placed is part of the rule because the virtual machine may not have been created yet. So for simplicity, we assume the virtual machine being placed is always implicitly part of any rule specified. It will be explicitly added to the rule before it is saved to the pod config.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

