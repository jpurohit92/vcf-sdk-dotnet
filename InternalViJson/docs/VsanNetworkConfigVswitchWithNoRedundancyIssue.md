# Vcenter.ViJson.OpenApi.Model.VsanNetworkConfigVswitchWithNoRedundancyIssue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Host on which the vmknic exists  Refers instance of *HostSystem*.  | 
**VswitchName** | **string** | Standard virtual switch name, in case of VMware Standard Switch (VSS).  | [optional] 
**Vds** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Virtual Distributed Switch, if in-use.  Refers instance of *DistributedVirtualSwitch*.  | [optional] 
**NumPnics** | **long** | Number of configured physical NICs.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

