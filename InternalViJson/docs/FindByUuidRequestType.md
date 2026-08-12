# Vcenter.ViJson.OpenApi.Model.FindByUuidRequestType
The parameters of *SearchIndex.FindByUuid*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If specified, restricts the query to entities in a particular datacenter. If not specified, the entire inventory is searched.  Refers instance of *Datacenter*.  | [optional] 
**Uuid** | **string** | The UUID to find. If vmSearch is true, the uuid can be either BIOS or instance UUID.  | 
**VmSearch** | **bool** | If true, search for virtual machines, otherwise search for hosts.  | 
**InstanceUuid** | **bool** | Should only be set when vmSearch is true. If specified, search for virtual machines whose instance UUID matches the given uuid. Otherwise, search for virtual machines whose BIOS UUID matches the given uuid.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

