# Vcenter.ViJson.OpenApi.Model.VirtualMachineConfigSpecNpivWwnOpEnum
The root WWN operation mode.  Possible values: - `generate`: Generate a new set of WWNs and assign it to the virtual machine. - `set`: Take a client-specified set of WWNs (specified in \"wwn\" property) and   assign them to the virtual machine.      If the new WWN quantity are more   than existing then we will append them to the existing list of WWNs. - `remove`: Remove the currently assigned WWNs from the virtual machine. - `extend`: Generate a new set of WWNs and append them to the existing list 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

