# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsOfflineCreateSpec
The Esx.Settings.Depots.Offline.CreateSpec schema defines the information used to create a depot.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthenticationSpec** | [**EsxSettingsDepotsOfflineAuthenticationSpec**](EsxSettingsDepotsOfflineAuthenticationSpec.md) | Describe the authentication to be used for connecting to the remote depot.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no authentication will be done. | [optional] 
**Description** | **string** | Description of the depot.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the description will be empty. | [optional] 
**SourceType** | **string** | Type of the source from which offline bundle is obtained.  Possible values:   - &#x60;PULL&#x60;: Content is pulled from the URL location. The URL scheme of the value in {@link CreateSpec#location) can be http, https or file.   - &#x60;PUSH&#x60;: Content was previously uploaded using the file upload endpoint present on vCenter appliance. This endpoint is present at https://VCENTERFQDN:9087/vum-fileupload URL.   For more information see: *Esx.Settings.Depots.Offline.SourceType*.  This property was added in __vSphere API 7.0.0.0__. | 
**Location** | **string** | Location of the depot from which content should be retrieved.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of source_type is *Esx.Settings.Depots.Offline.SourceType.PULL*. | [optional] 
**FileId** | **string** | File identifier returned by the file upload endpoint after file is uploaded.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of source_type is *Esx.Settings.Depots.Offline.SourceType.PUSH*. | [optional] 
**Ownerdata** | **string** | Private data saved by the *Esx.Settings.Depots.Offline.Info.owner* of the depot. It is opaque to vLCM.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, no ownerdata will be saved. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

