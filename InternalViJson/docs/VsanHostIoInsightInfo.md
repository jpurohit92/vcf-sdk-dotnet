# Vcenter.ViJson.OpenApi.Model.VsanHostIoInsightInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | ESXi host on which the ioinsight tool is installed.  Refers instance of *HostSystem*.  | 
**IoinsightWorldId** | **long** | The ESXi process identifier (aka.  worldId) of running ioinsight. For stopped ioinsight the worldId value is 0.  | [optional] 
**FaultMessage** | **string** | The error message when there is any issue found.  | [optional] 
**IoinsightInfo** | [**VsanIoInsightInfo**](VsanIoInsightInfo.md) | The current ioinsight state, along with all monitored VMs if ioinsight is in running stauts, see *VsanIoInsightInfo*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

