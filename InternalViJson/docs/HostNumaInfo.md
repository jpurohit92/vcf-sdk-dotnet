# Vcenter.ViJson.OpenApi.Model.HostNumaInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Deprecated as of vSphere API 5.1, this property is always set to \&quot;NUMA\&quot;.  The type of NUMA technology.  | 
**NumNodes** | **int** | The number of NUMA nodes on the host.  The value is 0 if the host is not NUMA-capable.  | 
**NumaNode** | [**List&lt;HostNumaNode&gt;**](HostNumaNode.md) | Information about each of the NUMA nodes on the host.  The array is empty if the host is not NUMA-capable.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

