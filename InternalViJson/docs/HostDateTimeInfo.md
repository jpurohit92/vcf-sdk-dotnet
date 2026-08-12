# Vcenter.ViJson.OpenApi.Model.HostDateTimeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarTimeZone** | [**HostDateTimeSystemTimeZone**](HostDateTimeSystemTimeZone.md) | The time zone of the host.  | 
**SystemClockProtocol** | **string** | The system clock synchronization protocol.  See *HostDateTimeInfoProtocol_enum* for possible values.  | [optional] 
**NtpConfig** | [**HostNtpConfig**](HostNtpConfig.md) | The NTP configuration on the host.  | [optional] 
**PtpConfig** | [**HostPtpConfig**](HostPtpConfig.md) | The PTP configuration on the host.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**Enabled** | **bool** | Present state of the time services subsystem.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**DisableEvents** | **bool** | When not disabled Network Time service or Precision Time service will send events to Virtual Center when service fails or recovers.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**DisableFallback** | **bool** | When not disabled, if PrecisionTimeSync is configured, then the NTP configuration can run as backup.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**InFallbackState** | **bool** | Tracks if NTP is providing time to ESXi due to PTP service failure.  This is set only if disableFallback is set to false.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**ServiceSync** | **bool** | Report true if time is synchronized with remote time source For PrecisionTimeSync this is obtained from PTP Port Status value.  For NetworkTimeProtocol this obtained from Leap Indicator value.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**LastSyncTime** | **DateTime** | Timestamp when time services were last in sync with remote clock.  If not set, time services have never established synchronization.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**RemoteNtpServer** | **string** | Provides the NTP server that the host is synced with from the set of servers configured.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**NtpRunTime** | **long** | Provides the total seconds ntpd process has been running for.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**PtpRunTime** | **long** | Provides the total seconds ptpd process has been running for.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**NtpDuration** | **string** | Provides a duration in simplified, human-readable form for the lifetime of the ntp service.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**PtpDuration** | **string** | Provides a duration in simplified, human-readable form for the lifetime of the ptp service.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

