# Vcenter.Automation.OpenApi.Model.ContentLibraryItemCertificateVerificationInfo
Currently, this field will available only in following cases 1. This item belongs to a secure content library 2. The item if of type ovf.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The certificate verification status of item.  Possible values:   - &#x60;NOT_AVAILABLE&#x60;: Existing library item which can not be verified. Applying security policy to an existing library may result in this status for items.   - &#x60;VERIFIED&#x60;: Item has been fully validated during importing or file syncing.   - &#x60;INTERNAL&#x60;: The Item is cloned/created through vCenter.   - &#x60;VERIFICATION_FAILURE&#x60;: Item&#39;s certificate or manifest validation failed.   - &#x60;VERIFICATION_IN_PROGRESS&#x60;: Item certificate verification is in progress.   - &#x60;UNTRUSTED&#x60;: Certificate used to sign the item is not trusted.   For more information see: *Content.Library.Item.CertVerificationStatus*.  This property was added in __vSphere API 7.0.3.0__. | 
**CertChain** | **List&lt;string&gt;** | A certificate in base64 encoding.  This property was added in __vSphere API 7.0.3.0__.  Certificate chain is unset if the item not signed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

