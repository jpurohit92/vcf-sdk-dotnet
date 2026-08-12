# Vcenter.ViJson.OpenApi.Model.EVCModeUnsupportedByHosts

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Faults** | [**List&lt;MethodFault&gt;**](MethodFault.md) | The faults that caused this EVC test to fail, such as *FeatureRequirementsNotMet* faults.  | [optional] 
**EvcMode** | **string** | The requested EVC mode.  | [optional] 
**Host** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The set of hosts which are blocking EVC because their CPU hardware does not support the requested EVC mode.  Refers instances of *HostSystem*.  | [optional] 
**HostName** | **List&lt;string&gt;** | The names of the hosts in the host array.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

