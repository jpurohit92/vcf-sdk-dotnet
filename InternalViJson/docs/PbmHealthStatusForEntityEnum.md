# Vcenter.ViJson.OpenApi.Model.PbmHealthStatusForEntityEnum
The enumeration type defines the set of health status values for an entity that is part of entity health operation.  Possible values: - `red`: For file share: 'red' if the file server for this file share is in error   state or any of its backing vSAN objects are degraded.      For FCD: 'red' if the datastore on which the FCD resides is not   accessible from any of the hosts it is mounted. - `yellow`: For file share: 'yellow' if some backing objects are repairing, i.e.      warning state.   For FCD: 'yellow' if the datastore on which the entity resides is   accessible only from some of the hosts it is mounted but not all. - `green`: For file share: 'green' if the file server for this file share is   running properly and all its backing vSAN objects are healthy.      For FCD: 'green' if the datastore on which the entity resides   is accessible from all the hosts it is mounted. - `unknown`: If the health status of a file share is unknown, not valid for FCD. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

