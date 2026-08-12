# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsOfflineInfo
The Esx.Settings.Depots.Offline.Info schema defines the information regarding an offline depot.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Description of the depot. If not set during import, it will be empty.  This property was added in __vSphere API 7.0.0.0__. | 
**SourceType** | **string** | Type of the source from which offline depot is obtained.  Possible values:   - &#x60;PULL&#x60;: Content is pulled from the URL location. The URL scheme of the value in {@link CreateSpec#location) can be http, https or file.   - &#x60;PUSH&#x60;: Content was previously uploaded using the file upload endpoint present on vCenter appliance. This endpoint is present at https://VCENTERFQDN:9087/vum-fileupload URL.   For more information see: *Esx.Settings.Depots.Offline.SourceType*.  This property was added in __vSphere API 7.0.0.0__. | 
**Location** | **string** | Location of the depot from which content is retrieved.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of source_type is *Esx.Settings.Depots.Offline.SourceType.PULL*. | [optional] 
**FileId** | **string** | File identifier returned by the file upload endpoint after file is uploaded.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of source_type is *Esx.Settings.Depots.Offline.SourceType.PUSH*. | [optional] 
**CreateTime** | **DateTime** | Time when the depot was created.  This property was added in __vSphere API 7.0.0.0__. | 
**Owner** | **string** | Name of the user creating the depot.  This property was added in __vSphere API 7.0.3.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**Ownerdata** | **string** | Private data saved by the owner of depot. It is opaque to vLCM.  This property was added in __vSphere API 7.0.3.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

