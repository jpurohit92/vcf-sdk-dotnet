# Vcenter.ViJson.OpenApi.Model.VsanHostQueryRunIperfClientRequestType
The parameters of *HostVsanHealthSystem.VsanHostQueryRunIperfClient*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Multicast** | **bool** | True to test mutlicast network performance. False to test unicast network performance.  | 
**ServerIp** | **string** | The server IP binding to in the test  | 
**DurationSec** | **int** | The duration of the network performance test. Default is 15 seconds if not set.  | [optional] 
**Spec** | [**VsanIperfClientSpec**](VsanIperfClientSpec.md) | The additional query spec for iperf client.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

