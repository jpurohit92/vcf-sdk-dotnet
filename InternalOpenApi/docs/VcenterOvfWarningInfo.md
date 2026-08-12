# Vcenter.Automation.OpenApi.Model.VcenterOvfWarningInfo
The Vcenter.Ovf.WarningInfo schema provides information about the warnings which are raised during the OVF package deployment.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The warning type raised during the OVF package deployment.  Possible values:   - &#x60;SELF_SIGNED_CERTIFICATE&#x60;: The certificate used for signing the OVF package content is self-signed.   - &#x60;EXPIRED_CERTIFICATE&#x60;: The certificate used for signing the OVF package content is expired.   - &#x60;NOT_YET_VALID_CERTIFICATE&#x60;: The certificate used for signing the OVF package content is not yet valid.   - &#x60;UNTRUSTED_CERTIFICATE&#x60;: The certificate used for signing the OVF package content is not trusted.   For more information see: *Vcenter.Ovf.WarningType*.  This property was added in __vSphere API 7.0.2.0__. | 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The message specifying more details about the warning.  This property was added in __vSphere API 7.0.2.0__. | 
**Ignored** | **bool** | Indicates if this warning will be ignored when deploying the OVF package.    The value is set to be &#x60;false&#x60; when it is returned from *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action&#x3D;filter*, it should be updated to be &#x60;true&#x60; when calling *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action&#x3D;deploy* if the warning can be ignored, otherwise the OVF package deployment will fail.  This property was added in __vSphere API 7.0.2.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

