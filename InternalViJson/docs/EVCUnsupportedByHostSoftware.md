# Vcenter.ViJson.OpenApi.Model.EVCUnsupportedByHostSoftware

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Faults** | [**List&lt;MethodFault&gt;**](MethodFault.md) | The faults that caused this EVC test to fail, such as *FeatureRequirementsNotMet* faults.  | [optional] 
**Host** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The set of hosts which are blocking EVC because their virtualization software does not support CPUID override.  Refers instances of *HostSystem*.  | 
**HostName** | **List&lt;string&gt;** | The names of the hosts in the host array.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

