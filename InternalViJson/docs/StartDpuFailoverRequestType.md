# Vcenter.ViJson.OpenApi.Model.StartDpuFailoverRequestType
The parameters of *HostNetworkSystem.startDpuFailover*.  ***Since:*** vSphere API Release 8.0.3.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DvsName** | **string** | The name of the distributed virtual switch.  | 
**TargetDpuAlias** | **string** | The alias of the DPU to failover to. If not set, it will be determined by the system. At least one vmnic backed by the DPU needs to be associated to the standby uplink of the distributed virtual switch.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

