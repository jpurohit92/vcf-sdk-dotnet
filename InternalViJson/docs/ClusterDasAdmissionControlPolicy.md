# Vcenter.ViJson.OpenApi.Model.ClusterDasAdmissionControlPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResourceReductionToToleratePercent** | **int** | Percentage of resource reduction that a cluster of VMs can tolerate in case of a failover.  | [optional] 
**PMemAdmissionControlEnabled** | **bool** | Deprecated as of vSphere 9.0 APIs with no replacement.  Flag that determines whether strict admission control for persistent memory is enabled.  By default, this value is false. This flag can only be set to true if *ClusterDasConfigInfo.admissionControlEnabled* is set to true. When you use persistent memory admission control, the following operations are prevented, if doing so would violate the *ClusterDasConfigInfo.admissionControlEnabled*. - Creating a virtual machine with persistent memory. - Adding a virtual persistent memory device to a virtual machine. - Increasing the capacity of a virtual persistent memory device.    ***Since:*** vSphere API Release 7.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

