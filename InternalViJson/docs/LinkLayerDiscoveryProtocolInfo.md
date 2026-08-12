# Vcenter.ViJson.OpenApi.Model.LinkLayerDiscoveryProtocolInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChassisId** | **string** | ChassisId represents the chassis identification for the device that transmitted the LLDP frame.  The receiving LLDP agent combines the Chassis ID and portId to represent the entity connected to the port where the frame was received.  | 
**PortId** | **string** | This property identifies the specific port that transmitted the LLDP frame.  The receiving LLDP agent combines the Chassis ID and Port to represent the entity connected to the port where the frame was received.  | 
**TimeToLive** | **int** | It is the duration of time in seconds for which information contained in the received LLDP frame shall be valid.  If a value of zero is sent it can also identify a device that has shut down or is no longer transmitting, prompting deletion of the record from the local database.  | 
**Parameter** | [**List&lt;KeyAnyValue&gt;**](KeyAnyValue.md) | LLDP parameters  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

