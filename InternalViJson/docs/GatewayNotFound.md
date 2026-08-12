# Vcenter.ViJson.OpenApi.Model.GatewayNotFound
Deprecated not used since vSphere 6.5.  GatewayNotFound is thrown by vCenter Server, if no host gateway with the specified type/id and available resources is known to the vCenter Server. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GatewayType** | **string** | The type of the gateway used for the connection to the host.  | 
**GatewayId** | **string** | Identifier of the gateway that is used for the connection to the host.  | 
**GatewayInfo** | **string** | Human-readable information about the host gateway server.  | 
**Details** | [**LocalizableMessage**](LocalizableMessage.md) | Details of the cause for this fault.  This is the way in which Host Gateway servers propagate opaque error messages through vCenter Server.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

