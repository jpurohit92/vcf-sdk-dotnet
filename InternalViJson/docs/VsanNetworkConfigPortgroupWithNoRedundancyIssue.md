# Vcenter.ViJson.OpenApi.Model.VsanNetworkConfigPortgroupWithNoRedundancyIssue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Host on which the vmknic exists  Refers instance of *HostSystem*.  | 
**PortgroupName** | **string** | Portgroup name, in case of VMware Standard Switch (VSS).  | [optional] 
**Vds** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Virtual Distributed Switch, if in-use.  Refers instance of *DistributedVirtualSwitch*.  | [optional] 
**Pg** | [**ManagedObjectReference**](ManagedObjectReference.md) | Portgroup, either VSS or VDS.  Refers instance of *Network*.  | [optional] 
**NumPnics** | **long** | Number of configured physical NICs.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

