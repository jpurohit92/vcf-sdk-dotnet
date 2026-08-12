# Vcenter.ViJson.OpenApi.Model.VsanQueryClusterNetworkPerfTestRequestType
The parameters of *VsanClusterHealthSystem.VsanQueryClusterNetworkPerfTest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hosts** | **List&lt;string&gt;** | The vSAN hosts  | 
**EsxRootPassword** | **string** | The root password for the host. The password should be the same for all of hosts in the vSAN cluster  | 
**Multicast** | **bool** | True to test vSAN multicast network performance. False to test vSAN unicast network performance.  | 
**DurationSec** | **int** | The duration time for the Network Performance test. Default is 15 seconds if not set.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

