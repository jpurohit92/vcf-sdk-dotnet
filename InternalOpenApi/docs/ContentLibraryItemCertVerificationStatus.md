# Vcenter.Automation.OpenApi.Model.ContentLibraryItemCertVerificationStatus
The Content.Library.Item.CertVerificationStatus enumerated type defines the certificate verification status of a library item. Currently applicable only to ovf item type  Possible values:   - `NOT_AVAILABLE`: Existing library item which can not be verified. Applying security policy to an existing library may result in this status for items.   - `VERIFIED`: Item has been fully validated during importing or file syncing.   - `INTERNAL`: The Item is cloned/created through vCenter.   - `VERIFICATION_FAILURE`: Item's certificate or manifest validation failed.   - `VERIFICATION_IN_PROGRESS`: Item certificate verification is in progress.   - `UNTRUSTED`: Certificate used to sign the item is not trusted.   This enumeration was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

