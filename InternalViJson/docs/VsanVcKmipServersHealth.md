# Vcenter.ViJson.OpenApi.Model.VsanVcKmipServersHealth

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Health** | **string** | The overall KMIP servers health.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | If error is set, it means there are issues when trying to retrieve Key Management Servers status.  The error message will describe the possible issues, such as \&quot;Retrieve KMIP servers status timed out\&quot;.  | [optional] 
**KmsProviderId** | **string** | The Id of the KMS cluster to use for vSAN Encryption.  | [optional] 
**KmsHealth** | [**List&lt;VsanKmsHealth&gt;**](VsanKmsHealth.md) | A list of the KMIP servers health result.  | [optional] 
**ClientCertHealth** | **string** | The client certificate status.  If the certificate is expired, the health is \&quot;red\&quot;. If the certificate expires in 30 days, the health is \&quot;yellow\&quot;. Otherwise the certificate health is \&quot;green\&quot;.  | [optional] 
**ClientCertExpireDate** | **DateTime** | The client certificate expiry date.  | [optional] 
**IsAwsKms** | **bool** | Whether vSAN encryption is using AWS KMS.  | [optional] 
**CmkHealth** | **string** | The health status of Customer Master Key (CMK) from AWS KMS.  This is only set when using AWS KMS for vSAN encryption.  | [optional] 
**KekExpireHealth** | **string** | KEK expiration state.  &#39;red&#39; means that the KEK has expired or is going to expire in very close days(10 days by default), and &#39;yellow&#39; means that the KEK will expire in certain days(30 days by default), and &#39;green&#39; means that there is still a long time(more than 30 days by default) before the KEK expires or the KEK will not expire.  | [optional] 
**KekExpireDate** | **DateTime** | Key encryption key expiration date.  | [optional] 
**HostKeyExpireHealth** | **string** | Host Key expiration state.  &#39;red&#39; means that the host key has expired or is going to expire in very close days(10 days by default), and &#39;yellow&#39; means that the host key will expire in certain days(30 days by default), and &#39;green&#39; means that there is still a long time(more than 30 days by default) before the host key expires or the host key will not expire.  | [optional] 
**HostKeyExpireDate** | **DateTime** | Host key expiration date.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

