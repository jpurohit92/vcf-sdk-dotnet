# Vcenter.ViJson.OpenApi.Model.QueryVMotionCompatibilityRequestType
The parameters of *ServiceInstance.QueryVMotionCompatibility*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine that is the designated VMotion candidate.  Refers instance of *VirtualMachine*.  | 
**Host** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The group of hosts to analyze for compatibility.  Refers instances of *HostSystem*.  | 
**Compatibility** | **List&lt;string&gt;** | The set of compatibility types to investigate. Each is a string chosen from VMotionCompatibilityType. If this argument is not set, then all compatibility types are investigated.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

