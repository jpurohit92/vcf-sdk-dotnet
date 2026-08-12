# Vcenter.Automation.OpenApi.Model.ContentLibraryItemFileChecksumInfo
Provides checksums for a *Content.Library.Item.File.Info* object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Algorithm** | **string** | The checksum algorithm (ChecksumAlgorithm) used to calculate the checksum.  Possible values:   - &#x60;SHA1&#x60;: Checksum algorithm: SHA-1   - &#x60;MD5&#x60;: Checksum algorithm: MD5   - &#x60;SHA256&#x60;: Checksum algorithm: SHA-256  This constant was added in __vSphere API 6.8__.   - &#x60;SHA512&#x60;: Checksum algorithm: SHA-512  This constant was added in __vSphere API 6.8__.   For more information see: *Content.Library.Item.File.ChecksumAlgorithm*.  If not specified the default checksum algorithm is *Content.Library.Item.File.ChecksumAlgorithm.SH_a1*. | [optional] 
**Checksum** | **string** | The checksum value calculated with *Content.Library.Item.File.ChecksumInfo.algorithm*. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

