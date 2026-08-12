# Vcenter.ViJson.OpenApi.Model.VsanVibInstallRequestType
The parameters of *VsanUpdateManager.VsanVibInstall_Task*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | Optional cluster this scan is happening in reference to.  ***Required privileges:*** Host.Config.Storage Host.Config.Settings  Refers instance of *ComputeResource*.  | [optional] 
**VibSpecs** | [**List&lt;VsanVibSpec&gt;**](VsanVibSpec.md) | List of VIB specs to installed (context is always a single host)  | [optional] 
**ScanResults** | [**List&lt;VsanVibScanResult&gt;**](VsanVibScanResult.md) | List of VIB scan results obtained from VsanVibScan()  | [optional] 
**FirmwareSpecs** | [**List&lt;VsanHclFirmwareUpdateSpec&gt;**](VsanHclFirmwareUpdateSpec.md) | List of Firmware spec to be installed (context is always a single host and vmhba)  | [optional] 
**MaintenanceSpec** | [**HostMaintenanceSpec**](HostMaintenanceSpec.md) | Maintenance spec to pass to EnterMaintenanceMode\\_Task() In case of non-rolling installs, no other vSAN action than &#39;noAction&#39; is allowed.  | [optional] 
**Rolling** | **bool** | True (default) means a 1-host-at-a-time rolling install will be performed.  | [optional] 
**NoSigCheck** | **bool** | Skip signature checking, should not be used outside of fully trusted test environments. Default: False  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

