# Vcenter.ViJson.OpenApi.Model.HttpNfcLeaseProbeUrlsRequestType
The parameters of *HttpNfcLease.HttpNfcLeaseProbeUrls*.  ***Since:*** vSphere API Release 7.0.2.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Files** | [**List&lt;HttpNfcLeaseSourceFile&gt;**](HttpNfcLeaseSourceFile.md) | \\[in\\] List of remote source file descriptors There should be the same number of *HttpNfcLeaseSourceFile* as *HttpNfcLeaseDeviceUrl* provided by this lease.  | [optional] 
**Timeout** | **int** | \\[in\\] time in seconds for each url validation. Maximum timeout is 60.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

