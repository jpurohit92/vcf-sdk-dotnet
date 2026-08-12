# Vcenter.ViJson.OpenApi.Model.QueryCompatibleVmnicsFromHostsRequestType
The parameters of *DistributedVirtualSwitchManager.QueryCompatibleVmnicsFromHosts*.  ***Since:*** vSphere API Release 8.0.0.1 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The array of hosts on which the query is to be made to fetch valid PhysicalNics on each host.  Refers instances of *HostSystem*.  | [optional] 
**Dvs** | [**ManagedObjectReference**](ManagedObjectReference.md) | The distributed virtual switch on which the query is to be made.  Refers instance of *DistributedVirtualSwitch*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

