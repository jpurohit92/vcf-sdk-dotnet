# Vcenter.ViJson.OpenApi.Model.SolutionsUrlVMSource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OvfUrl** | **string** | URL to the solution&#39;s system Virtual Machine OVF.  | 
**CertificateValidation** | **bool** | Overrides the OVF URL certificate validation.  If &#x60;True&#x60; or &#x60;&lt;unset&gt;&#x60; - the certificate will be subject to standard trust validation, if &#x60;False&#x60; - any certificate will be considered trusted.  | [optional] 
**CertificatePEM** | **string** | PEM encoded certificate to use to trust the URL.  If omitted - URL will be trusted using well known methods.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

