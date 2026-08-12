# Vcenter.ViJson.OpenApi.Model.FindAllByDnsNameRequestType
The parameters of *SearchIndex.FindAllByDnsName*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If specified, restricts the query to entities in a particular datacenter. If not specified, the entire inventory is searched.  Refers instance of *Datacenter*.  | [optional] 
**DnsName** | **string** | The fully qualified domain name to find.  | 
**VmSearch** | **bool** | If true, search for virtual machines, otherwise search for hosts.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

