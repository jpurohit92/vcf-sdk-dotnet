# Vcenter.ViJson.OpenApi.Model.HostDateTimeConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarTimeZone** | **string** | The time zone of the host.  Must be one of the values of *HostDateTimeSystemTimeZone.key*  | [optional] 
**NtpConfig** | [**HostNtpConfig**](HostNtpConfig.md) | The NTP configuration on the host.  | [optional] 
**PtpConfig** | [**HostPtpConfig**](HostPtpConfig.md) | The PTP configuration on the host.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**Protocol** | **string** | Specify which network time configuration to discipline vmkernel clock.  See *HostDateTimeInfoProtocol_enum* for supported values.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**Enabled** | **bool** | Bring Time services subsystem up or down.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**DisableEvents** | **bool** | When Network Time service or Precision Time service are enabled any detecteced failures will result in Events being sent to Virtual Center.  Use this setting to disable Time Events.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**DisableFallback** | **bool** | When in PrecisionTimeSync, NTP configuration as set will be running as backup.  Use this setting to prevent NTP from becoming the primary time protocol in the event of a PTP service failure.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**ResetToFactoryDefaults** | **bool** | When this property is present and set true the existing configuration for Time Services will be reset to factory default.  The protocol property when set defines the scope of what is reset. If additional configuration beyond protocol is provided host will first perform factory reset followed by applying any configuration present.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

