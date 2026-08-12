# Vcenter.ViJson.OpenApi.Model.VsanResourceCheckDataPersistenceResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of the component resource check result that is queried.  Please see *VsanResourceCheckComponentType_enum* for possible types.  See also *VsanResourceCheckComponentType_enum*.  | 
**DataToRebuild** | **long** | Amount of data that will rebuild asynchronously after queried operation is performed.  | [optional] 
**InaccessibleInstances** | **List&lt;string&gt;** | Persistent service instances that are predicted to become inaccessible after queried operation is performed.  Instance names are constructed as follows service:namespace:instance where: - service: Name of the persistent service. - namespace: Name of the instance namespace. - instance: Instance name given to the respective service instance   while creating it.  | [optional] 
**ReducedAvailabilityInstances** | **List&lt;string&gt;** | Persistent service instances that are predicted to have reduced availability after queried operation is performed.  Instance names are constructed as follows service:namespace:instance where: - service: Name of the persistent service. - namespace: Name of the instance namespace. - instance: Instance name given to the respective service instance   while creating it.  | [optional] 
**RebuildInstances** | **List&lt;string&gt;** | Persistent service instances that will lead to rebuild on a different entity, these instances will have reduced availability as long as the data is rebuilt.  The data may be rebuilt synchronously or asynchronously depending on the service. Instance names are constructed as follows service:namespace:instance where: - service: Name of the persistent service. - namespace: Name of the instance namespace. - instance: Instance name given to the respective service instance   while creating it.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

