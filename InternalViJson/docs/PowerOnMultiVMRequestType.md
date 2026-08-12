# Vcenter.ViJson.OpenApi.Model.PowerOnMultiVMRequestType
The parameters of *Datacenter.PowerOnMultiVM_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The virtual machines to power on.  ***Required privileges:*** VirtualMachine.Interact.PowerOn  Refers instances of *VirtualMachine*.  | 
**Option** | [**List&lt;OptionValue&gt;**](OptionValue.md) | An array of *OptionValue* options for this power-on session. The names and values of the options are defined in *ClusterPowerOnVmOption_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

