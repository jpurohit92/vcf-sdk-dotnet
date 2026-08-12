# Vcenter.ViJson.OpenApi.Model.SubnetInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The identification of the endpoint on the host.  The format of this depends on the kind of virtual device this endpoints is used for. For example, for a VirtualEthernetCard this would be a networkname, and for a VirtualCDROM it would be a device name.  | 
**ConfigurationTag** | **List&lt;string&gt;** | List of configurations that this device is available for.  This is only filled out if more than one configuration is requested.  | [optional] 
**Id** | **string** | The ID of the subnet  | 
**SubnetFolderInfo** | [**SubnetInfoFolderInfo**](SubnetInfoFolderInfo.md) | The subnet folder info  | 
**VpcFolderInfo** | [**SubnetInfoFolderInfo**](SubnetInfoFolderInfo.md) | The VPC folder info  | 
**ProjectFolderInfo** | [**SubnetInfoFolderInfo**](SubnetInfoFolderInfo.md) | The project folder info  | [optional] 
**RootFolderInfo** | [**SubnetInfoFolderInfo**](SubnetInfoFolderInfo.md) | The root folder info.  root folder can be either \&quot;Virtual Private Clouds\&quot; or \&quot;NSX Managed Folders\&quot;  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

