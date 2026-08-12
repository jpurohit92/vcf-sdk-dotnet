# Vcenter.ViJson.OpenApi.Model.FindAllByIpRequestType
The parameters of *SearchIndex.FindAllByIp*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If specified, restricts the query to entities in a particular datacenter. If not specified, the entire inventory is searched.  Refers instance of *Datacenter*.  | [optional] 
**Ip** | **string** | The dot-decimal notation formatted IP address to find.  | 
**VmSearch** | **bool** | If true, search for virtual machines, otherwise search for hosts.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

