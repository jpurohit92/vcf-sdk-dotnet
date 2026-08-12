# Vcenter.ViJson.OpenApi.Model.HostSevInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SevState** | **string** | State of SEV on the host.  The set of supported values are described in *HostSevInfoSevState_enum*.  | 
**MaxSevEsGuests** | **long** | The maximum number of SEV-ES and SEV-SNP guests supported on this host.  | 
**SnpState** | **string** | State of SEV-SNP (SEV Secure Nested Paging) on the host.  The supported values are described in *HostSevInfoSevState_enum*.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**SnpSupported** | **bool** | SEV-SNP (SEV Secure Nested Paging) supported  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

