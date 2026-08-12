# Vcenter.ViJson.OpenApi.Model.GatewayOperationRefused
Deprecated not used sine vSphere 6.5.  GatewayOperationRefused is thrown by vCenter Server when a gateway server denies to accept more connection due to resource limitation.  The fault may occur due to specific configuration of the Gateway server to work with limited resources or due to physical limitation to handle more host connections. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GatewayType** | **string** | The type of the gateway used for the connection to the host.  | 
**GatewayId** | **string** | Identifier of the gateway that is used for the connection to the host.  | 
**GatewayInfo** | **string** | Human-readable information about the host gateway server.  | 
**Details** | [**LocalizableMessage**](LocalizableMessage.md) | Details of the cause for this fault.  This is the way in which Host Gateway servers propagate opaque error messages through vCenter Server.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

