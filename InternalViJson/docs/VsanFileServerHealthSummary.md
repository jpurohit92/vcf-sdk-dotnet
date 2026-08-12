# Vcenter.ViJson.OpenApi.Model.VsanFileServerHealthSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DomainName** | **string** | The domain name on which the file server is checked against.  | [optional] 
**FileServerIp** | **string** | The IP address of the file server.  | [optional] 
**NfsdHealth** | **string** | Whether the NFS daemon of the file server is running or not.  | [optional] 
**NetworkHealth** | **string** | Whether the ip address of the file server is present or not.  | [optional] 
**RootfsHealth** | **string** | Whether the root filesystem is responsive to the file server or not.  | [optional] 
**Description** | **string** | The description of the health state.  | [optional] 
**SmbConnections** | **int** | The count of client connections to SMB daemon of the file service.  | [optional] 
**SmbDaemonHealth** | **string** | Whether the SMB daemon of the file server is running or not.  | [optional] 
**AdTestJoinHealth** | **string** | Whether File server AD join configuration and connectivity is correct or not.  | [optional] 
**DnsLookupHealth** | **string** | Whether File server DNS configuration and connectivity is correct or not.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

