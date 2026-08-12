# Vcenter.ViJson.OpenApi.Model.KmipServerInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name for the KMIP server.  | 
**Address** | **string** | Address of the KMIP server.  | 
**Port** | **int** | Port of the KMIP server.  | 
**ProxyAddress** | **string** | Address of the proxy server.  Set value to empty string to delete the entry.  | [optional] 
**ProxyPort** | **int** | Port of the proxy server.  Set value \&quot;-1\&quot; to delete the entry.  | [optional] 
**Reconnect** | **int** | Should auto-reconnect be done.  Set value \&quot;-1\&quot; to delete the entry.  | [optional] 
**Protocol** | **string** | KMIP library protocol handler, e.g.  KMIP1. Set value to empty string to delete the entry.  | [optional] 
**Nbio** | **int** | Non-blocking I/O required.  Set value \&quot;-1\&quot; to delete the entry.  | [optional] 
**Timeout** | **int** | I/O timeout in seconds (-1&#x3D;none,0&#x3D;infinite).  Set value \&quot;-1\&quot; to delete the entry.  | [optional] 
**UserName** | **string** | Username to authenticate to the KMIP server.  Set value to empty string to delete the entry.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

