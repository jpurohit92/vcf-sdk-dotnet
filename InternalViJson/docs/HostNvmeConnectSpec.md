# Vcenter.ViJson.OpenApi.Model.HostNvmeConnectSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HbaName** | **string** | The device name of the NVME over Fabrics host bus adapter.  | 
**TransportParameters** | [**HostNvmeTransportParameters**](HostNvmeTransportParameters.md) | Transport specific information necessary to connect to the controller.  | 
**Subnqn** | **string** | NVME Qualified Name of the NVM subsystem to connect to.  Corresponds to the SUBNQN field in the Connect command as referenced above.  | 
**ControllerId** | **int** | ID of the controller to connect to within the NVM subsystem.  This field corresponds to CNTLID in the Connect command. Its usage depends on whether the NVM Subsystem supports a static or dynamic controller model. In the static model, a number of controllers may be exposed. A connection to a specific one may be requested by specifying its controller ID (which is unique only within the NVM subsystem). If a value of 0xFFFE (65534 in decimal) is provided, any one of the controllers may be allocated for the connection. In the static model a value of 0xFFFF (65535 in decimal) or above is invalid. In the dynamic model, the NVM Subsystem will dynamically allocate a controller. Any value other than 0xFFFF (65535 in decimal) specified will be consider invalid. If the controllerId is unset, it defaults to 0xFFFF (the value used in the dynamic model). Whether the NVM subsystem supports the dynamic or static model can be determined by examining the corresponding *HostNvmeDiscoveryLogEntry* returned for it.  | [optional] 
**AdminQueueSize** | **int** | Size of the admin queue which will be created once connection is established.  This field corresponds to SQSIZE in the Connect command (see above). If unset, it defaults to a reasonable value which may vary between releases (currently 16).  | [optional] 
**KeepAliveTimeout** | **int** | Timeout for the keep alive feature in seconds.  This field corresponds to KATO in the Connect command (see above). If unset, it defaults to a reasonable value which may vary between releases (currently 30 seconds). For further information, see: - \&quot;NVM Express 1.3\&quot;, Section 5.21.1.15, \&quot;Keep Alive Timer\&quot;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

