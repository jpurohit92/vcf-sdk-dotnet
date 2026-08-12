# Vcenter.ViJson.OpenApi.Model.CnsAsyncQueryResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VolumeId** | [**CnsVolumeId**](CnsVolumeId.md) | Unique identifier and datastore information for the volume.     Result object for all operations, other than create, will get volumeId as part of its input parameter and should always have this field set. For the result of create operation, this field will not be set. Please see *CnsVolumeCreateResult* for details.  | [optional] 
**Fault** | [**MethodFault**](MethodFault.md) | Fault, if any, corresponding to the specified volume ID that caused operation to fail.  Absence of fault will indicate successful result.    For create operation, volumeId field will not be set. Instead, volume name will be set, to associated fault with appropriate request. Please see *CnsVolumeCreateResult* for details.  | [optional] 
**QueryResult** | [**CnsQueryResult**](CnsQueryResult.md) | Query result object.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

