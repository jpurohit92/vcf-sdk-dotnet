# Vcenter.ViJson.OpenApi.Model.CnsVolumeCreateResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VolumeId** | [**CnsVolumeId**](CnsVolumeId.md) | Unique identifier and datastore information for the volume.     Result object for all operations, other than create, will get volumeId as part of its input parameter and should always have this field set. For the result of create operation, this field will not be set. Please see *CnsVolumeCreateResult* for details.  | [optional] 
**Fault** | [**MethodFault**](MethodFault.md) | Fault, if any, corresponding to the specified volume ID that caused operation to fail.  Absence of fault will indicate successful result.    For create operation, volumeId field will not be set. Instead, volume name will be set, to associated fault with appropriate request. Please see *CnsVolumeCreateResult* for details.  | [optional] 
**Name** | **string** | Client specified volume name in input.     This field will be set along with fault field because if volume creation fails, then there won&#39;t be any volumeId to be set in the result.CNS API will not try to enforce any uniqueness for volume name.    But it is highly recommended to not to have duplicate volume names, especially for a single invocation of the create operation.  | [optional] 
**PlacementResults** | [**List&lt;CnsPlacementResult&gt;**](CnsPlacementResult.md) | Placement result for every datastore in the dynamic volume provisioning/create request.     The size of this array will be equal to the size of *CnsVolumeCreateSpec.datastores*.    This is an optional field and will not be set for static volume provisioning and register volume operations.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

