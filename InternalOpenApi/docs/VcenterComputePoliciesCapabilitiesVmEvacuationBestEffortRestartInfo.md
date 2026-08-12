# Vcenter.Automation.OpenApi.Model.VcenterComputePoliciesCapabilitiesVmEvacuationBestEffortRestartInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmTag** | **string** | Identifier of a tag that can be associated with a virtual machine. All virtual machines that have the tag indicated by *Vcenter.Compute.Policies.Capabilities.Vm.Evacuation.BestEffortRestart.Info.vm_tag* will go through a guest shut-down if their host is entering maintenance-mode. If guest shut-down is unavailable or doesn&#39;t complete in time, then the VM is powered-off. Virtual machines that are in a powered-off state because of this policy will be attempted to be powered-on every few minutes. The host on which the VM will be powered-on can be different than the host where the VM was initially running.  This property was added in __vSphere API 8.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Tag:VirtualMachine&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Tag:VirtualMachine&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

