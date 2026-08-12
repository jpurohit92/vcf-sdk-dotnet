# Vcenter.ViJson.OpenApi.Model.ActiveVMsBlockingEVC

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Faults** | [**List&lt;MethodFault&gt;**](MethodFault.md) | The faults that caused this EVC test to fail, such as *FeatureRequirementsNotMet* faults.  | [optional] 
**EvcMode** | **string** | The requested EVC mode.  | [optional] 
**Host** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Hosts with active virtual machines that are blocking the operation, because the hosts expose compatibility-relevant CPU features not present in the baseline of the requested EVC mode.  Note that in rare cases, a host may be on this list even if its *maxEVCModeKey* corresponds to the requested EVC mode. This means that even though that EVC mode is the best match for the host&#39;s hardware, the host still has some features beyond those present in the baseline for that EVC mode.  Refers instances of *HostSystem*.  | [optional] 
**HostName** | **List&lt;string&gt;** | The names of the hosts in the host array.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

