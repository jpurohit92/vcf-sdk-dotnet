# Vcenter.ViJson.OpenApi.Model.FaultToleranceConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MetaDataPath** | [**FaultToleranceMetaSpec**](FaultToleranceMetaSpec.md) | Metadata file information  | [optional] 
**SecondaryVmSpec** | [**FaultToleranceVMConfigSpec**](FaultToleranceVMConfigSpec.md) | Placement information for secondary  | [optional] 
**MetroFtEnabled** | **bool** | Indicates whether FT Metro Cluster is enabled/disabled.  \\- If TRUE, FT Metro Cluster is enabled for the VM. An implicit Anti-HostGroup will be generated from HostGroup defined for FT primary, then affine the primary with one HostGroup and affine the secondary with another HostGroup. \\- If FALSE or unset, FT Metro Cluster is disabled for the VM. Both FT primary and secondary will be put in the same HostGroup.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 
**MetroFtHostGroup** | **string** | Indicate the Host Group (*ClusterHostGroup*) for FT Metro Cluster enabled Virtual Machine.  Based on the selected Host Group, FT can divide the hosts in the cluster into two groups and ensure to place FT primary and FT secondary in different groups.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

