# Vcenter.ViJson.OpenApi.Model.SolutionsClusterBoundSolutionConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmCount** | **int** | The number of instances of the specified VM to be deployed across the cluster.  | 
**VmPlacementPolicies** | **List&lt;string&gt;** | VM placement policies to be configured on the VMs *SolutionsVmPlacementPolicy_enum* If omitted - no VM placement policies are configured.  | [optional] 
**VmNetworks** | [**List&lt;SolutionsVMNetworkMapping&gt;**](SolutionsVMNetworkMapping.md) | Networks defined in the OVF to be configured on the VMs.  Mutually exclusive with *SolutionsClusterBoundSolutionConfig.devices*. If omitted - no VM networks are configured.  | [optional] 
**Datastores** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Datastores to be configured as a storage of the VMs.  The first available datastore in the cluster is used. The collection cannot contain duplicate elements. If omitted - the system automatically selects the datastore. The selection takes into account the other properties of the desired state specification (the provided VM storage policies and VM devices) and the runtime state of the datastores in the cluster. It is required DRS to be enabled on the cluster.  Refers instances of *Datastore*.  | [optional] 
**Devices** | [**VirtualMachineConfigSpec**](VirtualMachineConfigSpec.md) | Devices of the VMs not defined in the OVF descriptor.  Mutually exclusive with *SolutionsClusterBoundSolutionConfig.vmNetworks*.  If *SolutionsClusterBoundSolutionConfig.datastores* is not set, the devices of the VMs not defined in the OVF descriptor should be provided to *SolutionsClusterBoundSolutionConfig.devices* and not as part of a VM lifecycle hook (VM reconfiguration). Otherwise, the compatibility of the devices with the selected host and datastore where the VM is deployed needs to be ensured by the client.  1\\. For VM initial placement the devices are added to the VM configuration. 2\\. For the reconfiguration it is checked what devices need to be added, removed, and edited on the existing VMs. NOTE: No VM relocation is executed before the VM reconfiguration.  The supported property of vim.vm.ConfigSpec is vim.vm.ConfigSpec.deviceChange. The supported vim.vm.device.VirtualDeviceSpec.operation is Operation#add. For vim.vm.device.VirtualEthernetCard the unique identifier is vim.vm.device.VirtualDevice#unitNumber.  If omitted - no additional devices will be added to the VMs.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

