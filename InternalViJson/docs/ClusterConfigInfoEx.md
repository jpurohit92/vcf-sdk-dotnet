# Vcenter.ViJson.OpenApi.Model.ClusterConfigInfoEx

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmSwapPlacement** | **string** | Swapfile placement policy for virtual machines within this compute resource.  Any policy except for \&quot;inherit\&quot; is a valid value for this property; the default is \&quot;vmDirectory\&quot;. This setting will be honored for each virtual machine within the compute resource for which the following is true: - The virtual machine is executing on a host that has the   *perVmSwapFiles* capability. - The virtual machine configuration&#39;s   *swapPlacement* property is set   to \&quot;inherit\&quot;.    See also *VirtualMachineConfigInfoSwapPlacementType_enum*.  | 
**SpbmEnabled** | **bool** | Flag indicating whether or not the SPBM(Storage Policy Based Management) feature is enabled on this compute resource  | [optional] 
**DefaultHardwareVersionKey** | **string** | Key for Default Hardware Version used on this compute resource in the format of *VirtualMachineConfigOptionDescriptor.key*.  This field affects *VirtualMachineConfigOptionDescriptor.defaultConfigOption* returned by *ComputeResource.environmentBrowser* of this object and all its children with this field unset.  | [optional] 
**MaximumHardwareVersionKey** | **string** | Key for Maximum Hardware Version used on this compute resource in the format of *VirtualMachineConfigOptionDescriptor.key*.  This field affects *VirtualMachineConfigOptionDescriptor.defaultConfigOption* returned by *ComputeResource.environmentBrowser* of this object and all its children with this field unset.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**SystemVMsConfig** | [**ClusterSystemVMsConfigInfo**](ClusterSystemVMsConfigInfo.md) | Deprecated as of vSphere 9.0 with no replacement. In a future release of vSphere, the vCLS functionality will be disabled, vCLS system VMs will be deleted, and vCLS APIs will be removed.  Configuration for vCLS system VMs deployment.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**DasConfig** | [**ClusterDasConfigInfo**](ClusterDasConfigInfo.md) | Cluster-wide configuration of the vSphere HA service.  | 
**DasVmConfig** | [**List&lt;ClusterDasVmConfigInfo&gt;**](ClusterDasVmConfigInfo.md) | List of virtual machine configurations for the vSphere HA service.  Each entry applies to one virtual machine.  If a virtual machine is not specified in this array, the service uses the default settings for that virtual machine.  | [optional] 
**DrsConfig** | [**ClusterDrsConfigInfo**](ClusterDrsConfigInfo.md) | Cluster-wide configuration of the VMware DRS service.  | 
**DrsVmConfig** | [**List&lt;ClusterDrsVmConfigInfo&gt;**](ClusterDrsVmConfigInfo.md) | List of virtual machine configurations for the VMware DRS service.  Each entry applies to one virtual machine.  If a virtual machine is not specified in this array, the service uses the default settings for that virtual machine.  | [optional] 
**Rule** | [**List&lt;ClusterRuleInfo&gt;**](ClusterRuleInfo.md) | Cluster-wide rules.  | [optional] 
**Orchestration** | [**ClusterOrchestrationInfo**](ClusterOrchestrationInfo.md) | Cluster-wide configuration of VM orchestration.  | [optional] 
**VmOrchestration** | [**List&lt;ClusterVmOrchestrationInfo&gt;**](ClusterVmOrchestrationInfo.md) | List of virtual machine configurations that apply during cluster wide VM orchestration.  Each entry applies to one virtual machine.  If a virtual machine is not specified in this array, the service uses the default settings for that virtual machine.  | [optional] 
**DpmConfigInfo** | [**ClusterDpmConfigInfo**](ClusterDpmConfigInfo.md) | Cluster-wide configuration of the VMware DPM service.  | [optional] 
**DpmHostConfig** | [**List&lt;ClusterDpmHostConfigInfo&gt;**](ClusterDpmHostConfigInfo.md) | List of host configurations for the VMware DPM service.  Each entry applies to one host.  If a host is not specified in this array, the service uses the cluster default settings for that host.  | [optional] 
**VsanConfigInfo** | [**VsanClusterConfigInfo**](VsanClusterConfigInfo.md) | Cluster-wide configuration of the VMware VSAN service.  | [optional] 
**VsanHostConfig** | [**List&lt;VsanHostConfigInfo&gt;**](VsanHostConfigInfo.md) | List of host configurations for the VMware VSAN service.  Each entry applies to one host.  If a host is not specified in this array, the service uses the cluster default settings for that host.  | [optional] 
**Group** | [**List&lt;ClusterGroupInfo&gt;**](ClusterGroupInfo.md) | Cluster-wide groups.  | [optional] 
**InfraUpdateHaConfig** | [**ClusterInfraUpdateHaConfigInfo**](ClusterInfraUpdateHaConfigInfo.md) | Cluster-wide configuration of the VMware InfraUpdateHA service.  | [optional] 
**ProactiveDrsConfig** | [**ClusterProactiveDrsConfigInfo**](ClusterProactiveDrsConfigInfo.md) | Cluster-wide configuration of the ProactiveDRS service.  | [optional] 
**CryptoConfig** | [**ClusterCryptoConfigInfo**](ClusterCryptoConfigInfo.md) | Cluster-wide configuration of the encryption mode.  | [optional] 
**VsanCoreConfig** | [**VsanClusterCoreConfig**](VsanClusterCoreConfig.md) | vSAN first-class settings that will be configured together with vSAN enablement.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

