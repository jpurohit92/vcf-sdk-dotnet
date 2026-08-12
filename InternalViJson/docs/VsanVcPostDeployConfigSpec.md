# Vcenter.ViJson.OpenApi.Model.VsanVcPostDeployConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DcName** | **string** | Name of the datacenter to be created.  Default: \&quot;Datacenter\&quot;  | [optional] 
**ClusterName** | **string** | Name of the cluster to be created.  Default: \&quot;VSANCluster\&quot;  | [optional] 
**FirstHost** | [**HostConnectSpec**](HostConnectSpec.md) | Connection information about the host on which this task runs.  It will be the first host to be added to vCenter, so vCenter adopts the settings of this host for VSAN.  | [optional] 
**HostsToAdd** | [**List&lt;HostConnectSpec&gt;**](HostConnectSpec.md) | List of *HostConnectSpec* objects, one for each host that should be connected to vCenter and added to the cluster.  | [optional] 
**VsanDataEfficiencyConfig** | [**VsanDataEfficiencyConfig**](VsanDataEfficiencyConfig.md) | The data efficiency config for vSAN.  | [optional] 
**VsanLicenseKey** | **string** | Deprecated as of version 9.1. vSAN license key is no longer supported for 9.0 onwards.  vSAN License key to apply to the cluster.  If not specified, license is not changed. If specified, current license is overwritten.  | [optional] 
**HostLicenseKey** | **string** | ESX License key to apply to all hosts.  If not specified, license is not changed. If specified, current license is overwritten for hosts with version lower than 9.0, otherwise, the key is ignored, as host license key is not supported since 9.0.  | [optional] 
**TaskId** | **string** | Unique identifier of the task this progress report is for.  | [optional] 
**VsanDataEncryptionConfig** | [**VsanHostEncryptionInfo**](VsanHostEncryptionInfo.md) | The data encryption config that was used to bootstrap single node vSAN cluster when calling ESXi host API *VsanVcsaDeployerSystem.VsanPrepareVsanForVcsa*  | [optional] 
**CreateNativeKeyProviderSpec** | [**VsanHostCreateNativeKeyProviderSpec**](VsanHostCreateNativeKeyProviderSpec.md) | Specification used to create native key provider.  | [optional] 
**VsanClusterMode** | **string** | Advanced Mode configuration for vSAN(Optional).  When this parameter is not present, a vSAN OSA/ESA cluster will be created based on the vSAN datastore type on the first host. When this parmeter is present, the new vSAN cluster will be configured into the specified mode. The currently accepted value for the parameter is vim.vsan.Mode.Mode\\_Storage. Any mode other than this is not supported.  See also *VsanMode_enum*.  ***Since:*** 8.0.0.4  | [optional] 
**DeconvergedNetConfig** | [**VsanDeconvergedNetConfig**](VsanDeconvergedNetConfig.md) | De-converged network configuration for vSAN.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

