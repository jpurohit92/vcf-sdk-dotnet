# Vcenter.ViJson.OpenApi.Model.ClusterDasVmConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the virtual machine.  Refers instance of *VirtualMachine*.  | 
**RestartPriority** | **DasVmPriorityEnum** | Deprecated as of VI API 2.5, use *ClusterDasVmConfigInfo.dasSettings*.*ClusterDasVmSettings.restartPriority*. If you specify *ClusterDasVmConfigInfo.restartPriority* here and in *ClusterDasVmSettings*, the value in *ClusterDasVmSettings* has precedence.  Restart priority for a virtual machine.  If there is nothing specified here, then the defaults are picked up from *ClusterDasConfigInfo.defaultVmSettings*.  | [optional] 
**PowerOffOnIsolation** | **bool** | Deprecated as of VI API 2.5, use *ClusterDasVmConfigInfo.dasSettings*.*ClusterDasVmSettings.isolationResponse*. If you specify both *ClusterDasVmConfigInfo.powerOffOnIsolation* and *ClusterDasVmSettings.isolationResponse*, the value in *ClusterDasVmSettings.isolationResponse* has precedence.  Flag to indicate whether or not the virtual machine should be powered off if a host determines that it is isolated from the rest of the compute resource.  If there is nothing specified here, then the defaults are picked up from *ClusterDasConfigInfo.defaultVmSettings*.  | [optional] 
**DasSettings** | [**ClusterDasVmSettings**](ClusterDasVmSettings.md) | HA settings that apply to this virtual machine.  Values specified in this object override the cluster-wide defaults for virtual machines (*ClusterDasConfigInfo.defaultVmSettings*).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

