# Vcenter.ViJson.OpenApi.Model.VsanUnmapConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **bool** | Whether SCSI unmap command is supported on vSAN datastore.  If this setting is switched from disabled to enabled, for any unmap request to vSAN datastore from powered on VMs will take effect and succeed immediately; And if it is switched from enabled to disabled dynamically, running VMs reside on this vSAN datastore won&#39;t know this change until VM rebooting happen. vSAN will fail any unmap request, and the failure will be handled by guest OS gracefully.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

