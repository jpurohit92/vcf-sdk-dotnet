# Vcenter.ViJson.OpenApi.Model.VsanHclFirmwareUpdateSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host onto which this Firmware should be updated.  Refers instance of *HostSystem*.  | 
**HbaDevice** | **string** | The HBA Device name (e.g.  vmhba0) to flash.  | 
**FwFiles** | [**List&lt;VsanHclFirmwareFile&gt;**](VsanHclFirmwareFile.md) | The files to use for firmware flashing.  | 
**AllowDowngrade** | **bool** | If set, will allow firmware downgrade.  Should not be used outside of controlled and validated testing. May damage the controller. Check with vendor.  | [optional] 
**FirmwareComponent** | [**List&lt;VsanHostFwComponent&gt;**](VsanHostFwComponent.md) | List of firmware components require upgrade.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

