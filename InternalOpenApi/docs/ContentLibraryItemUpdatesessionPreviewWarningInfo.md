# Vcenter.Automation.OpenApi.Model.ContentLibraryItemUpdatesessionPreviewWarningInfo
The Content.Library.Item.Updatesession.PreviewWarningInfo schema provides information about the warnings which are raised during the update session preview.  This schema was added in __vSphere API 6.8__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The warning type raised during preview of the update session.  Possible values:   - &#x60;SELF_SIGNED_CERTIFICATE&#x60;: The certificate used for signing the content is self-signed.   - &#x60;EXPIRED_CERTIFICATE&#x60;: The certificate used for signing the content is expired.   - &#x60;NOT_YET_VALID_CERTIFICATE&#x60;: The certificate used for signing the content is not yet valid.   - &#x60;UNTRUSTED_CERTIFICATE&#x60;: The certificate used for signing the content is not trusted.   For more information see: *Content.Library.Item.Updatesession.WarningType*.  This property was added in __vSphere API 6.8__. | 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The message specifying more details about the warning.  This property was added in __vSphere API 6.8__. | 
**Ignored** | **bool** | Indicates if this warning will be ignored during session complete operation.  This property was added in __vSphere API 6.8__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

