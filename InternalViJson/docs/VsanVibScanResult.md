# Vcenter.ViJson.OpenApi.Model.VsanVibScanResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host for which this information is in reference to.  Refers instance of *HostSystem*.  | 
**VibName** | **string** | Name of the VIB which uniquely identifies it among other VIBs in the host.  | 
**VibVersion** | **string** | Version provided by this VIB.  | 
**ExistingVersion** | **string** | Existing version on the host, if any.  | [optional] 
**MaintenanceModeRequired** | **bool** | True if install of this VIB will require maintenance mode.  | 
**RebootRequired** | **bool** | True if install of this VIB will require a host reboot.  | 
**MeetsSystemReq** | **bool** | True if system requirements are met.  | 
**PkgDepsMetByHost** | **bool** | True if this vibs dependency is satisfied by the host vibs.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

