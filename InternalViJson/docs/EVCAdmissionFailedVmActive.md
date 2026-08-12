# Vcenter.ViJson.OpenApi.Model.EVCAdmissionFailedVmActive
An attempt to move or add a host into an Enhanced VMotion Compatibility cluster has failed for the following reason: - The host exposes additional compatibility-relevant CPU features beyond   those present in the baseline mandated by the cluster's EVC mode. - The host has powered-on or suspended virtual machines.    Therefore the host may not be admitted into the cluster, since its virtual machines may be using CPU features suppressed in the cluster.  Note that in rare cases, this may occur even if the host's *maxEVCModeKey* corresponds to the EVC mode of the cluster. This means that even though that EVC mode is the best match for the host's hardware, the host still has some features beyond those present in the baseline for that EVC mode. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Faults** | [**List&lt;MethodFault&gt;**](MethodFault.md) | The faults that caused this EVC test to fail (e.g.  FeatureRequirementsNotMet faults).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

