# Vcenter.ViJson.OpenApi.Model.KmipServerSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterId** | [**KeyProviderId**](KeyProviderId.md) | The ID of the KMIP cluster.  KMIP servers with the same clusterId are in one cluster and provide the same keys for redundancy.  | 
**Info** | [**KmipServerInfo**](KmipServerInfo.md) | Connection information for the KMIP server.  | 
**Password** | **string** | Password to authenticate to the KMIP server.  Set value to empty string to delete the entry.  | [optional] 
**DefaultKeyType** | **string** | Key type which the key provider generates by default.  See *KmipClusterInfoKeyType_enum* for supported values.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**KeySpec** | [**KmipServerSpecKeySpec**](KmipServerSpecKeySpec.md) | Specification of key.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

