# Vcenter.ViJson.OpenApi.Model.HostNvmeDisconnectSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HbaName** | **string** | The device name of the NVME over Fabrics host bus adapter.  | 
**Subnqn** | **string** | NVME Qualified Name of the NVM subsystem to disconnect from.  If controllerNumber is not specified, the subsystem qualified name has to be specified and any controllers exposed by that subsystem will be disconnected from the specified adapter. This is particularly convenient for the dynamic controller model, where the mapping subsystemNQN &amp;lt;-&amp;gt; ctrlNumber is expected to be 1:1. If controllerNumber is also specified, this value is ignored.  | [optional] 
**ControllerNumber** | **int** | Controller number of the controller to be disconnected.  If this value is set, the subsystemQualifiedName can be left unset and the controller whose controllerNumber field matches this value will be disconnected from the specified adapter. If this value is not set, subsystemQualifiedName must be set.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

