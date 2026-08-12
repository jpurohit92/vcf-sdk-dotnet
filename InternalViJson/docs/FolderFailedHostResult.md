# Vcenter.ViJson.OpenApi.Model.FolderFailedHostResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostName** | **string** | Host name for which fault belongs to.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host for which fault belongs to.  Only set when the HostSystem reference is available as a result of Host being part of inventory.  Refers instance of *HostSystem*.  | [optional] 
**Context** | [**LocalizableMessage**](LocalizableMessage.md) | Message describing context where the failure happened.  | 
**Fault** | [**MethodFault**](MethodFault.md) | Exception encountered while operating on this host.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

