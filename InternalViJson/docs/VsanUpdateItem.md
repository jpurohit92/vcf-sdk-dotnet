# Vcenter.ViJson.OpenApi.Model.VsanUpdateItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host for which this information is in reference to.  Refers instance of *HostSystem*.  | 
**Type** | **string** | Type of the item.  See also *VsanUpdateItemType_enum*.  | 
**Name** | **string** | Name of the item.  In case of a VIB a description that includes the unique VIB name. In case of firmware, a description of firmware and device.  | 
**VarVersion** | **string** | Version provided by this item.  Note, in case of a VIB, this may not be the VIB version, but rather the version of what the VIB contains, e.g. the version of the driver or CIM provider, which may not match exactly the version of the VIB.  | 
**ExistingVersion** | **string** | Existing version on the host, if any.  | [optional] 
**Present** | **bool** | If not present, it needs to be downloaded from the Internet, or uploaded to the Update Manager.  See respective APIs.  | 
**VibSpec** | [**List&lt;VsanVibSpec&gt;**](VsanVibSpec.md) | In case of VIB type, the spec for the VIB.  | [optional] 
**VibType** | **string** | Type of the Vib.  See also *VsanVibType_enum*.  | [optional] 
**FirmwareSpec** | [**VsanHclFirmwareUpdateSpec**](VsanHclFirmwareUpdateSpec.md) | In case of vmhba firmware type, the spec for the firmware.  | [optional] 
**DownloadInfo** | [**List&lt;VsanDownloadItem&gt;**](VsanDownloadItem.md) | Information about how to download the item.  | [optional] 
**Eula** | **string** | EULA provided by this item.  Note, in case of a VIB, this is empty, as for firmware, it is the EULA provided by the vendor.  | [optional] 
**Adapter** | **string** | The device name of adapter whose vendor tool or driver/firmware to be installed or updated by the update item  | [optional] 
**Key** | **string** | Unique key to identify the an update item.  | [optional] 
**Impact** | **string** | Impact after the update item is applied.  See also *VsanUpdateItemImpactType_enum*.  | [optional] 
**FirmwareUnknown** | **bool** | Set to true when firmware is unknown.  When it&#39;s true, it means associated firmware mgmt tool is missing, which has to be installed first.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

