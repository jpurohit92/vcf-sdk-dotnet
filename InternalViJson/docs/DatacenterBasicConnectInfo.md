# Vcenter.ViJson.OpenApi.Model.DatacenterBasicConnectInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | Target host.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | Error encountered while querying the host.  See *Datacenter.QueryConnectionInfo* for the list of exceptions which can be represented here.  | [optional] 
**ServerIp** | **string** | IP address of the VirtualCenter already managing this host, if any.  | [optional] 
**NumVm** | **int** | Specifies the number of VMs on the host.  | [optional] 
**NumPoweredOnVm** | **int** | Specifies the number of powered-on VMs on the host.  | [optional] 
**HostProductInfo** | [**AboutInfo**](AboutInfo.md) | Information about the software running on the host.  | [optional] 
**HardwareVendor** | **string** | Hardware vendor identification.  | [optional] 
**HardwareModel** | **string** | System model identification.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

