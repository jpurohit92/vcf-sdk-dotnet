# Vcenter.ViJson.OpenApi.Model.QueryVMotionCompatibilityExRequestType
The parameters of *VirtualMachineProvisioningChecker.QueryVMotionCompatibilityEx_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The set of virtual machines to analyze for compatibility. All virtual machines are assumed to be powered-on for the purposes of this operation.  Refers instances of *VirtualMachine*.  | 
**Host** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The set of hosts to analyze for compatibility. All hosts are assumed to be connected and not in maintenance mode for the purposes of this operation.  Refers instances of *HostSystem*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

