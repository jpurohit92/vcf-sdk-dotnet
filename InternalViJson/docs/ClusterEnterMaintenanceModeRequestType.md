# Vcenter.ViJson.OpenApi.Model.ClusterEnterMaintenanceModeRequestType
The parameters of *ClusterComputeResource.ClusterEnterMaintenanceMode*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The array of hosts to put into maintenance mode.  ***Required privileges:*** Host.Config.Maintenance  Refers instances of *HostSystem*.  | 
**Option** | [**List&lt;OptionValue&gt;**](OptionValue.md) | An array of *OptionValue* options for this query. The specified options override the advanced options in *ClusterDrsConfigInfo*.  | [optional] 
**Info** | [**ClusterComputeResourceMaintenanceInfo**](ClusterComputeResourceMaintenanceInfo.md) | ***Since:*** vSphere API Release 8.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

