# Vcenter.ViJson.OpenApi.Model.VsanDatastoreSourcePrecheckItem
The base class of result item for a Datastore Source precheck.  It is inherited from *VsanHealthStatusType_enum*. The type is also specified with one of the values about Datastore Source prechecks in below enumerations: *VimVsanMountPrecheckType_enum*, *VimVsanMountPrecheckTypeDIT_enum*.  See also *VimVsanMountPrecheckType_enum*, *VimVsanMountPrecheckTypeDIT_enum*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of precheck for mounting remote vSAN datastore.  All supported types are defined in below enumerations: *VimVsanMountPrecheckType_enum*, *VimVsanMountPrecheckTypeDIT_enum*.  See also *VimVsanMountPrecheckType_enum*, *VimVsanMountPrecheckTypeDIT_enum*.  | 
**Description** | [**LocalizableMessage**](LocalizableMessage.md) | The description of precheck for mounting remote vSAN datastore.  | 
**Status** | **string** | The status of precheck for mounting remote vSAN datastore.  Check *VsanHealthStatusType_enum* for all possible statuses.  See also *VsanHealthStatusType_enum*.  | 
**Reason** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | The reason why the precheck returns unsuccessful result.  It contains the error/warning message of the precheck.  | [optional] 
**IgnoreMessage** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | The warning information when the item is in \&quot;yellow\&quot; status but user wants to ignore it and proceed forcefully.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

