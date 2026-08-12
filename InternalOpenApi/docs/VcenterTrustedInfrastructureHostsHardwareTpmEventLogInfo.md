# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureHostsHardwareTpmEventLogInfo
The Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.EventLog.Info schema contains information that describes an event log.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the event log.  Possible values:   - &#x60;EFI_TCG2_EVENT_LOG_FORMAT_TCG_2&#x60;: TCG EFI Protocol Specification, Family \&quot;2.0\&quot;, Level 00 Revision 00.13, March 30, 2016, Section 5.2 Crypto Agile Log Entry Format.   For more information see: *Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.EventLog.Type*.  This property was added in __vSphere API 8.0.0.1__. | 
**Data** | **byte[]** | Event log data in the format described by *Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.EventLog.Info.type*.  This property was added in __vSphere API 8.0.0.1__.  This property is currently required. It may be optional in a future version. | [optional] 
**Truncated** | **bool** | Indicates if the event log is truncated.    An event log is truncated when there was insufficient memory to store one or more event entries.  This property was added in __vSphere API 8.0.0.1__. | 
**Banks** | [**List&lt;VcenterTrustedInfrastructureHostsHardwareTpmPcrBank&gt;**](VcenterTrustedInfrastructureHostsHardwareTpmPcrBank.md) | The resulting PCR banks from event log replay.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

