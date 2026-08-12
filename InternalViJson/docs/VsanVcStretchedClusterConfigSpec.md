# Vcenter.ViJson.OpenApi.Model.VsanVcStretchedClusterConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WitnessHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | The witness host to be added into vSAN cluster.  This host cannot be a part of target cluster.  Refers instance of *HostSystem*.  | 
**Clusters** | [**List&lt;VsanStretchedClusterConfig&gt;**](VsanStretchedClusterConfig.md) | The list of clusters to be converted to stretched or to replace witness.  | 
**WitnessDiskMappings** | [**List&lt;VsanHostDiskMapping&gt;**](VsanHostDiskMapping.md) | Disk mapping configuration of target witness host.  | [optional] 
**WitnessStoragePoolSpecs** | [**List&lt;VsanAddStoragePoolDiskSpec&gt;**](VsanAddStoragePoolDiskSpec.md) | Storage pool configuration of target witness host.  This parameter cannot be set together with witnessDiskMappings param.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

