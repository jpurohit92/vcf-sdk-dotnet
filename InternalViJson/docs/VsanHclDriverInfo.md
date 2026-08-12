# Vcenter.ViJson.OpenApi.Model.VsanHclDriverInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DriverVersion** | **string** | Driver version as suggested by the HCL.  | [optional] 
**DriverLink** | [**VsanDownloadItem**](VsanDownloadItem.md) | Where to get the driver from.  | [optional] 
**FwVersion** | **string** | The firmware version of the controller as suggested by the HCL.  | [optional] 
**FwLinks** | [**List&lt;VsanDownloadItem&gt;**](VsanDownloadItem.md) | Where to get the firmware files from.  Can be multiple files belonging to the same firmware, or separate firmwares for different parts of the system. Required to be unique file format types.  | [optional] 
**ToolsLinks** | [**List&lt;VsanDownloadItem&gt;**](VsanDownloadItem.md) | Any additional tools that should be installed alongside the driver.  May include tools required for firmware patching.  | [optional] 
**Eula** | **string** | EULA provided by this item.  Note, in case of a VIB, this is empty, as for Firmware, it is the EULA provided by the vendor.  | [optional] 
**DriverType** | **string** | The type of this specific driver listed on HCL.  Supported drivers type are inbox and async.  | [optional] 
**DriverName** | **string** | Driver name as suggested by the HCL.  | [optional] 
**DiskModes** | **List&lt;string&gt;** | The disk mode supported by this driver and firmware as suggested by the HCL.  E.g., \\[&#39;All-Flash&#39;, &#39;Hybrid&#39;\\].  | [optional] 
**SupportedFeatures** | **List&lt;string&gt;** | Features supported by this driver and firmware pair as suggested by the HCL.  E.g., \\[&#39;RoCE v2&#39;\\]  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

