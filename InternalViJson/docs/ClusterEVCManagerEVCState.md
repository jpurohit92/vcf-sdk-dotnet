# Vcenter.ViJson.OpenApi.Model.ClusterEVCManagerEVCState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SupportedEVCMode** | [**List&lt;EVCMode&gt;**](EVCMode.md) | All supported EVC modes.  Identical to *Capability.supportedEVCMode*.  | 
**CurrentEVCModeKey** | **string** | If unset, then EVC is disabled.  If set, then EVC is enabled, and the value references an EVC mode described in one of the elements of the *ClusterEVCManagerEVCState.supportedEVCMode* array property. The EVC mode determines the set of guaranteed clusterwide CPU features. While EVC is enabled, CPU compatibility issues will not block any VMotion within the cluster (unless some VM is specifically configured to do different CPUID overrides).  | [optional] 
**GuaranteedCPUFeatures** | [**List&lt;HostCpuIdInfo&gt;**](HostCpuIdInfo.md) | Deprecated as of vSphere API 6.5 use *ClusterEVCManagerEVCState.featureCapability*.  When EVC is enabled, this array contains the CPU feature bits that are guaranteed (by EVC) to be the same among all hosts in the cluster.  This property has the same value as the guaranteedCPUFeatures property of the configured EVC mode. On any host in the EVC cluster, the CPU features either naturally match these values because of the CPU hardware, or else CPU feature override is used to mask out differences and enforce a match. This array is empty when EVC is disabled.  | [optional] 
**FeatureCapability** | [**List&lt;HostFeatureCapability&gt;**](HostFeatureCapability.md) | When EVC is enabled, this array contains the feature capabilities that are guaranteed (by EVC) to be the same among all hosts in the cluster.  This property has the same value as the featureCapability property of the configured EVC mode. On any host in the EVC cluster, the feature capabilities either naturally match these values because of the CPU hardware, or else feature masks are used to mask out differences and enforce a match. This array is empty when EVC is disabled.  | [optional] 
**FeatureMask** | [**List&lt;HostFeatureMask&gt;**](HostFeatureMask.md) | The masks (modifications to a host&#39;s feature capabilities) that limit a host&#39;s capabilities to that of the EVC mode baseline.  | [optional] 
**FeatureRequirement** | [**List&lt;VirtualMachineFeatureRequirement&gt;**](VirtualMachineFeatureRequirement.md) | The conditions that must be true of a host&#39;s feature capabilities in order for the host to meet the minimum requirements of the EVC mode baseline.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

