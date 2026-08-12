# Vcenter.Automation.OpenApi.Model.ContentLibraryItemUpdatesessionWarningBehavior
The Content.Library.Item.Updatesession.WarningBehavior schema defines the session behavior if the warning is raised during the update session.  This schema was added in __vSphere API 6.8__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The warning type which may be raised during the update session.  Possible values:   - &#x60;SELF_SIGNED_CERTIFICATE&#x60;: The certificate used for signing the content is self-signed.   - &#x60;EXPIRED_CERTIFICATE&#x60;: The certificate used for signing the content is expired.   - &#x60;NOT_YET_VALID_CERTIFICATE&#x60;: The certificate used for signing the content is not yet valid.   - &#x60;UNTRUSTED_CERTIFICATE&#x60;: The certificate used for signing the content is not trusted.   For more information see: *Content.Library.Item.Updatesession.WarningType*.  This property was added in __vSphere API 6.8__. | 
**Ignored** | **bool** | Indicates if this warning will be ignored during session complete operation.  This property was added in __vSphere API 6.8__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

