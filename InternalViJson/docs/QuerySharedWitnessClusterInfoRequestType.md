# Vcenter.ViJson.OpenApi.Model.QuerySharedWitnessClusterInfoRequestType
The parameters of *VimClusterVsanVcStretchedClusterSystem.QuerySharedWitnessClusterInfo*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WitnessHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | Witness host managed entity.  Refers instance of *HostSystem*.  | 
**SkipComponentsCount** | **bool** | Skip setting in the result the number of components for each cluster on the given witness host. This can fail if the host is disconnected, set to true to avoid failure and retrieve other information in the result.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

