# Vcenter.Automation.OpenApi.Model.VcenterEvcModeEvcMode
The Vcenter.EvcMode.EvcMode describes a set of Vcenter.EvcMode.FeatureMask used for Enhanced vMotion Compatibility (EVC).    An EVC mode is associated with a set of CPU features. When a host is added to an EVC-enabled cluster, the vCenter Server determines the CPU compatibility to preserve vMotion compatibility within the cluster. If the host CPU is compatible with those already in the cluster, the Server adds the host to the cluster and configures it for compatible operation. Hosts that are not compatible are not allowed to join the cluster.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The system generated unique identifier for the EvcMode.  This property was added in __vSphere API 9.0.0.0__. | 
**Masks** | [**List&lt;VcenterEvcModeFeatureMask&gt;**](VcenterEvcModeFeatureMask.md) | The masks (modifications to a host&#39;s feature capabilities) that limit a host&#39;s capabilities to that of the EVC mode baseline.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

