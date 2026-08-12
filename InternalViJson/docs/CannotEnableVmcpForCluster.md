# Vcenter.ViJson.OpenApi.Model.CannotEnableVmcpForCluster

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Report the host with APD timeout disabled.  If the host is set it points to the host which is the reason for this fault i.e this host has ADPTimeout disabled.  Refers instance of *HostSystem*.  | [optional] 
**HostName** | **string** | If set this reports the hostName.  This is used for printing the host name in the localized message as the host may have been removed from the vCenter&#39;s inventory by the time localization would be taking place.  | [optional] 
**Reason** | **string** | This reports the reason for host not meeting the requirements for enabling vSphere VMCP.  It can be the following reason. - APDTimeout disabled.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

