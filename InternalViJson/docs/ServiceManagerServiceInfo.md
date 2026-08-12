# Vcenter.ViJson.OpenApi.Model.ServiceManagerServiceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceName** | **string** | A service name.  Each service is expected to create a unique name for itself that can be used to locate the service. This name does not need to be unique across hosts or other such locations though.  | 
**Location** | **List&lt;string&gt;** | A list of data that can be used to uniquely identify a particular instance of a service.  Multiple instances of a service can exist across different domains (for instance, a service that is associated with a particular virtual machine or a particular host). In such cases, the service name is insufficient to identify the service and location data can be used to identify the instance of interest. A service may publish as much location data as is needed to identify it (e.g, vmware.host.&amp;lt;hostname&amp;gt; or vmware.vm.&amp;lt;uuid&amp;gt; or both). The particular choice of locations have to be agreed upon by the client and the service.  | [optional] 
**Service** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object that presents this service.  | 
**Description** | **string** | A description of the service.  Provides help text on how to use the service.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

