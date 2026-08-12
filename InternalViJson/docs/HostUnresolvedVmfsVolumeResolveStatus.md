# Vcenter.ViJson.OpenApi.Model.HostUnresolvedVmfsVolumeResolveStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Resolvable** | **bool** | Can this volume be resolved? There may be other reasons a volume cannot be resolved other than the fact that it is incomplete.  This boolean will authoritatively indicate if the server can resolve this volume.  | 
**IncompleteExtents** | **bool** | Is the list of extents for the volume a partial list? A volume can only be resignatured if all extents composing that volume are available.  Hence, a volume with a partial extent list cannot be resignatured.  In cases where this information is not known for a volume, this property will be unset.  | [optional] 
**MultipleCopies** | **bool** | Are there multiple copies of extents for this volume? If any extent of the volume has multiple copies then the extents to be resolved must be explicitly specified when resolving this volume.  In cases where this information is not known for a volume, this property will be unset.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

