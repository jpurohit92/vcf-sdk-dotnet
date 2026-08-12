# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsAlternativeVmSpec
The Esx.Settings.Clusters.Vms.AlternativeVmSpec schema contains properties to describe alternative VM configuration to be applied on VMs that matches a given selection criteria defined as Esx.Settings.Clusters.Vms.VmSelectionSpec.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelectionCriteria** | [**EsxSettingsClustersVmsVmSelectionSpec**](EsxSettingsClustersVmsVmSelectionSpec.md) | Selection criteria to match System VMs for which to apply this Esx.Settings.Clusters.Vms.AlternativeVmSpec.  This property was added in __vSphere API 9.1.0.0__. | 
**Devices** | **Object** | Devices of the VMs not defined in the OVF descriptor. This property takes precedence over *Esx.Settings.Clusters.Vms.ClusterSolutionSpec.devices* property.    If *Esx.Settings.Clusters.Vms.ClusterSolutionSpec.vm_datastores* is not set, the devices of the VMs not defined in the OVF descriptor should be provided to {#member devices} and not as part of a VM lifecycle hook (VM reconfiguration). Otherwise, the compatibility of the devices with the selected host and datastore where the VM is deployed needs to be ensured by the client.    1. For VM initial placement the devices are added to the VM configuration. 2. For the reconfiguration it is checked what devices need to be added, removed, and edited on the existing VMs. NOTE: No VM relocation is executed before the VM reconfiguration.    The supported property of vim.vm.ConfigSpec is vim.vm.ConfigSpec.deviceChange. The supported vim.vm.device.VirtualDeviceSpec.operation is Operation#add. For vim.vm.device.VirtualEthernetCard the unique identifier is vim.vm.device.VirtualDevice#unitNumber. *Esx.Settings.Clusters.Vms.ClusterSolutionSpec.vm_networks* and {#member devices} are mutually exclusive.     This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, *Esx.Settings.Clusters.Vms.ClusterSolutionSpec.devices* is used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

