# Vcenter.ViJson.OpenApi.Model.VsanKmsHealth

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServerName** | **string** | KMS server name.  | 
**Health** | **string** | The KMS connection status.  All of possible values are \&quot;green\&quot; and \&quot;red\&quot;. If the ESXi host can connect to the KMS and get key from it, the status is \&quot;green\&quot;. Otherwise it is \&quot;red\&quot; that indicates the ESXi host cannot connect to the KMS.  | 
**Error** | [**MethodFault**](MethodFault.md) | If error is set, it means there are issues when connecting to the Key Management Server.  The error message will describe the connection issues, such as \&quot;User authentication failed to Key Management Server\&quot; or \&quot;Connection timeout to Key Management Server\&quot;.  | [optional] 
**TrustHealth** | **string** | This field indicates whether vCenter could establish trusted connection to KMS.  If vCenter and KMS could trust each other, the health is \&quot;green\&quot;. Otherwise it is \&quot;red\&quot;. It is only set on vCenter side.  | [optional] 
**CertHealth** | **string** | The server certificate status.  If the certificate is expired, the health is \&quot;red\&quot;. If the certificate will expire within threshold days, the health is \&quot;yellow\&quot;. Otherwise the certificate health is \&quot;green\&quot;. It is only set on vCenter side.  | [optional] 
**CertExpireDate** | **DateTime** | The server certificate expiry date.  It is only set on vCenter side.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

