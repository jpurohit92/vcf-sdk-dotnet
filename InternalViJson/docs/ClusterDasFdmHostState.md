# Vcenter.ViJson.OpenApi.Model.ClusterDasFdmHostState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **string** | The Availability State of a host based on information reported by the entity given by the *ClusterDasFdmHostState.stateReporter* property.  See *ClusterDasFdmAvailabilityState_enum* for the set of states.  | 
**StateReporter** | [**ManagedObjectReference**](ManagedObjectReference.md) | The entity reporting the state of the host.  If the reporter is a host, the property reports which host, whereas if the reporter is vCenter Server, the property is unset.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

