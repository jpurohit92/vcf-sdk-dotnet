# Vcenter.ViJson.OpenApi.Model.HostTpmAttestationReport

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TpmPcrValues** | [**List&lt;HostTpmDigestInfo&gt;**](HostTpmDigestInfo.md) | The array of PCR digest values stored in the TPM device since the last host boot time.  | 
**TpmEvents** | [**List&lt;HostTpmEventLogEntry&gt;**](HostTpmEventLogEntry.md) | Log of TPM software stack attestation events.  | 
**TpmLogReliable** | **bool** | This flag indicates whether the provided TPM events are a complete and reliable information about host boot status.  TPM event log may be incomplete (and therefore unreliable) if certain modules have inappropriate origin or if the package information is incomplete. Only first 1000 events are recorded by the kernel. Further events will not be recorded in the log and will cause the log to be marked as unreliable.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

