# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsVersionsControlPlaneSizesSummary
The SizeInfo schema contains information about a particular sizing option available for a control plane VM.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Localized sizing hint label of the control plane VM.  This property was added in __vSphere API 9.1.0.0__. | 
**Identifier** | **string** | Sizing hint identifier.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.software.supervisors.versions.control_plane.Size&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.software.supervisors.versions.control_plane.Size&#x60;. | 
**MemoryInMib** | **long** | Amount of memory in mebibytes (MiB) on the control plane VM.  This property was added in __vSphere API 9.1.0.0__. | 
**VCpuCount** | **long** | Number of vCPUs on the control plane VM.  This property was added in __vSphere API 9.1.0.0__. | 
**DiskCapacityInMib** | **long** | Disk capacity in mebibytes (MiB) of the control plane VM.  This property was added in __vSphere API 9.1.0.0__. | 
**DefaultServiceCidr** | [**VcenterNamespaceManagementSoftwareSupervisorsVersionsControlPlaneSizesIpv4Cidr**](VcenterNamespaceManagementSoftwareSupervisorsVersionsControlPlaneSizesIpv4Cidr.md) | Default CIDR range from which Kubernetes allocates service cluster IP addresses.  This property was added in __vSphere API 9.1.0.0__. | 
**NsxT1Defaults** | [**VcenterNamespaceManagementSoftwareSupervisorsVersionsControlPlaneSizesNsxT1Defaults**](VcenterNamespaceManagementSoftwareSupervisorsVersionsControlPlaneSizesNsxT1Defaults.md) | Defaults when using the com.vmware.vcenter.namespace_management.supervisors.networks.NetworkProvider#NSXT_CONTAINER_PLUGIN provider.  This property was added in __vSphere API 9.1.0.0__. | 
**NsxVpcDefaults** | [**VcenterNamespaceManagementSoftwareSupervisorsVersionsControlPlaneSizesNsxVpcDefaults**](VcenterNamespaceManagementSoftwareSupervisorsVersionsControlPlaneSizesNsxVpcDefaults.md) | Defaults when using the com.vmware.vcenter.namespace_management.supervisors.networks.NetworkProvider#NSX_VPC provider.  This property was added in __vSphere API 9.1.0.0__. | 
**VsphereNetworkingDefaults** | [**VcenterNamespaceManagementSoftwareSupervisorsVersionsControlPlaneSizesVsphereNetworkingDefaults**](VcenterNamespaceManagementSoftwareSupervisorsVersionsControlPlaneSizesVsphereNetworkingDefaults.md) | Defaults when using the com.vmware.vcenter.namespace_management.supervisors.networks.NetworkProvider#VSPHERE_NETWORK provider.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

