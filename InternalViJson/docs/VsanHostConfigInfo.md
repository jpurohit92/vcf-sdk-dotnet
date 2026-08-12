# Vcenter.ViJson.OpenApi.Model.VsanHostConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Whether the VSAN service is currently enabled on this host.  | [optional] 
**HostSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | The *HostSystem* for this host.  This argument is required when this configuration is specified as an input to VC-level APIs. When this configuration is specified to a host-level direct API, this argument may be omitted.  See also *ComputeResource.ReconfigureComputeResource_Task*, *HostVsanSystem.UpdateVsan_Task*.  Refers instance of *HostSystem*.  | [optional] 
**ClusterInfo** | [**VsanHostConfigInfoClusterInfo**](VsanHostConfigInfoClusterInfo.md) | The VSAN service cluster configuration for this host.  | [optional] 
**StorageInfo** | [**VsanHostConfigInfoStorageInfo**](VsanHostConfigInfoStorageInfo.md) | The VSAN storage configuration for this host.  VSAN storage configuration settings are independent of the current value of *VsanHostConfigInfo.enabled*.  | [optional] 
**NetworkInfo** | [**VsanHostConfigInfoNetworkInfo**](VsanHostConfigInfoNetworkInfo.md) | The VSAN network configuration for this host.  VSAN network configuration settings are independent of the current value of *VsanHostConfigInfo.enabled*.  | [optional] 
**FaultDomainInfo** | [**VsanHostFaultDomainInfo**](VsanHostFaultDomainInfo.md) | The VSAN fault domain configuration for this host.  VSAN host fault domain settings are independent of the current value of *VsanHostConfigInfo.enabled*.  | [optional] 
**VsanEsaEnabled** | **bool** | Whether the vSAN ESA is enabled on this host.  This can only be enabled when vSAN is enabled on this host.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**VsanCyberRecoveryEnabled** | **bool** | Whether the vSAN Cyber Recovery is enabled on this host.  This can only be enabled when vSAN ESA is enabled on this host.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

