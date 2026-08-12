# Vcenter.ViJson.OpenApi.Model.VimClusterVSANStretchedClusterCapability

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostMoId** | **string** | ManagedEntity Id of target host  | 
**ConnStatus** | **string** | Connection status to present whether this host is connected to vCenter server, valid values include: connected, notResponding and disconnected.  | [optional] 
**IsSupported** | **bool** | Whether ESXi software of target host can support vSAN stretched cluster.  The vSAN stretched cluster feature is supported since vSphere vSAN 6.1.  | [optional] 
**HostCapability** | [**VimHostVSANStretchedClusterHostCapability**](VimHostVSANStretchedClusterHostCapability.md) | Detailed information of ESXi software to support vSAN stretched cluster, for now, it only contains the feature version information.  For vSphere vSAN 6.1, the version is 1.0; and vSphere vSAN 6.2, the version is 2.0.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

