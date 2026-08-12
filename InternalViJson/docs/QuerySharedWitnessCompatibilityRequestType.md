# Vcenter.ViJson.OpenApi.Model.QuerySharedWitnessCompatibilityRequestType
The parameters of *VimClusterVsanVcStretchedClusterSystem.QuerySharedWitnessCompatibility*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SharedWitnessHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | A host entity which would be used as a shared witness host.  Refers instance of *HostSystem*.  | 
**RoboClusters** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | A list of ROBO clusters which would use sharedWitnessHost as their witness.  Refers instances of *ClusterComputeResource*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

