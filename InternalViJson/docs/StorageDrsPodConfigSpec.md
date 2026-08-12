# Vcenter.ViJson.OpenApi.Model.StorageDrsPodConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Flag indicating whether or not storage DRS is enabled.  | [optional] 
**IoLoadBalanceEnabled** | **bool** | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  Flag indicating whether or not storage DRS takes into account storage I/O workload when making load balancing and initial placement recommendations.  | [optional] 
**DefaultVmBehavior** | **string** | Specifies the pod-wide default storage DRS behavior for virtual machines.  For currently supported storage DRS behavior, see *StorageDrsPodConfigInfoBehavior_enum*. You can override the default behavior for a virtual machine by using the *StorageDrsVmConfigInfo* object.  | [optional] 
**LoadBalanceInterval** | **int** | Specify the interval that storage DRS runs to load balance among datastores within a storage pod.  | [optional] 
**DefaultIntraVmAffinity** | **bool** | Specifies whether or not each virtual machine in this pod should have its virtual disks on the same datastore by default.  | [optional] 
**SpaceLoadBalanceConfig** | [**StorageDrsSpaceLoadBalanceConfig**](StorageDrsSpaceLoadBalanceConfig.md) | The configuration settings for load balancing storage space.  | [optional] 
**IoLoadBalanceConfig** | [**StorageDrsIoLoadBalanceConfig**](StorageDrsIoLoadBalanceConfig.md) | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  The configuration settings for load balancing I/O workload.  This takes effect only if *StorageDrsPodConfigInfo.ioLoadBalanceEnabled* is &lt;code&gt;true&lt;/code&gt;.  | [optional] 
**AutomationOverrides** | [**StorageDrsAutomationConfig**](StorageDrsAutomationConfig.md) | Configuration settings for fine-grain automation overrides on the cluster level setting.  | [optional] 
**Rule** | [**List&lt;ClusterRuleSpec&gt;**](ClusterRuleSpec.md) | Changes to the set of rules.  | [optional] 
**Option** | [**List&lt;StorageDrsOptionSpec&gt;**](StorageDrsOptionSpec.md) | Changes to advance settings.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

