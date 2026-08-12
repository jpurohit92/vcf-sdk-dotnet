# Vcenter.ViJson.OpenApi.Model.HostRegisterDiskRequestType
The parameters of *HostVStorageObjectManager.HostRegisterDisk*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | URL or datastore path to the running point of the virtual disk.  | 
**Name** | **string** | The descriptive name of the disk object. If unset the name will be automatically determined from the path. @see vim.vslm.BaseConfigInfo#name  | [optional] 
**ModifyControlFlags** | **bool** | Optional Parameter describing if the control Flags should be changed to default values  ***Since:*** vSphere API Release 8.0.2.0  | [optional] 
**Id** | [**ID**](ID.md) | The ID of the newly registered virtual storage object. For each new request, the ID should be a unique ID complying to RFC4122V4 (generated randomly). For retry requests with the same ID, all the other input parameters are expected to remain same. If not specified, a system generated ID will be assigned.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

