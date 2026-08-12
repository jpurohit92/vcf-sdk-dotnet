# Vcenter.ViJson.OpenApi.Model.DestinationSwitchFull
For one of the networks that the virtual machine is using, the corresponding switch on the host is full.  If returned as part of migration checks, this is an error if either of the following is true, a warning otherwise: - The virtual ethernet card device backing is a distributed virtual switch - The virtual ethernet card device backing is a standard network and the   the device is connected 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Network** | [**ManagedObjectReference**](ManagedObjectReference.md) | A reference to the network that cannot be accessed  Refers instance of *Network*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

