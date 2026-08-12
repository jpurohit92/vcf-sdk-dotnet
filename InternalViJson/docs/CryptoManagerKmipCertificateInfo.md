# Vcenter.ViJson.OpenApi.Model.CryptoManagerKmipCertificateInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subject** | **string** | Subject identifies whom the certificate is issued to.  | 
**Issuer** | **string** | Issuer identifies the party that issued this certificate.  | 
**SerialNumber** | **string** | The unique serial number of the certificate given by issuer.  | 
**NotBefore** | **DateTime** | The beginning time of the period of validity.  | 
**NotAfter** | **DateTime** | The ending time of the period of validity.  | 
**Fingerprint** | **string** | The SSL SHA1 fingerprint of the certificate.  | 
**CheckTime** | **DateTime** | The timestamp when the state of the certificate is checked.  | 
**SecondsSinceValid** | **int** | Total seconds since this certificate has entered valid state.  It is the time difference between \&quot;now\&quot; and \&quot;notBefore\&quot;. If it is negative value, that means the certificate will become valid in a future time.  | [optional] 
**SecondsBeforeExpire** | **int** | Total seconds before this certificate expires.  It is the time difference between \&quot;notAfter\&quot; and \&quot;now\&quot;. If it is negative value, that means the certificate has already expired.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

