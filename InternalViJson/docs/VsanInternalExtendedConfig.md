# Vcenter.ViJson.OpenApi.Model.VsanInternalExtendedConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VcMaxDiskVersion** | **int** | This configuration is the highest disk version that vCenter server can understand and manage.  vCenter server passes this configuration to ESXi hosts so that ESXi hosts will not choose a higher disk version that vCenter server cannot understand when creating a disk group. The default value on ESXi host is 0 when it is unset, meaning that the host is not managed by any vCenter server. Note that older vCenter server before v6.7 update 3 won&#39;t know this value hence will not set it.  | [optional] 
**StretchedClient** | **bool** | This configuration indicates if the host works in stretched compute only cluster.  This configuration only serves ESX reconfiguration purpose, but not returned via get API.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

