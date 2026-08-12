# Vcenter.ViJson.OpenApi.Model.EVCMode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Enumeration or literal ID being described.  | 
**GuaranteedCPUFeatures** | [**List&lt;HostCpuIdInfo&gt;**](HostCpuIdInfo.md) | Deprecated as of vSphere API 6.5 use *EVCMode.featureCapability*.  Describes the CPU feature baseline associated with the EVC mode.  On the cluster where a particular EVC mode is configured, those CPU features are guaranteed, either because the host hardware naturally matches those features or because CPU feature override is used to mask out differences and enforce a match.  | [optional] 
**FeatureCapability** | [**List&lt;HostFeatureCapability&gt;**](HostFeatureCapability.md) | Describes the feature capability baseline associated with the EVC mode.  On the cluster where a particular EVC mode is configured, these features capabilities are guaranteed, either because the host hardware naturally matches those features or because feature masks are used to mask out differences and enforce a match.  | [optional] 
**FeatureMask** | [**List&lt;HostFeatureMask&gt;**](HostFeatureMask.md) | The masks (modifications to a host&#39;s feature capabilities) that limit a host&#39;s capabilities to that of the EVC mode baseline.  | [optional] 
**FeatureRequirement** | [**List&lt;VirtualMachineFeatureRequirement&gt;**](VirtualMachineFeatureRequirement.md) | The conditions that must be true of a host&#39;s feature capabilities in order for the host to meet the minimum requirements of the EVC mode baseline.  | [optional] 
**Vendor** | **string** | CPU hardware vendor required for this mode.  | 
**Track** | **List&lt;string&gt;** | Identifiers for feature groups that are at least partially present in the *EVCMode.guaranteedCPUFeatures* array for this mode.  Use this property to compare track values from two modes. Do not use this property to determine the presence or absence of specific features.  | 
**VendorTier** | **int** | Index for ordering the set of modes that apply to a given CPU vendor.  Use this property to compare vendor tier values from two modes. Do not use this property to determine the presence or absence of specific features.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

