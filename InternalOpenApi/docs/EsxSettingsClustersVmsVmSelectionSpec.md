# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsVmSelectionSpec
The Esx.Settings.Clusters.Vms.VmSelectionSpec schema contains properties to describe the criteria used to select System VMs to which an Esx.Settings.Clusters.Vms.AlternativeVmSpec configuration is applied.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelectionType** | **string** | Selection type for this Esx.Settings.Clusters.Vms.VmSelectionSpec.  Possible values:   - &#x60;VM_EXTRA_CONFIG&#x60;: Select System VMs that have a specific property configured in the VM extra configuration. The property has a key&#x3D;&#39;com.vmware.vim.eam.selection&#39;. The value represents a unique identifier used for VM selection and is provided by the client.   For more information see: *Esx.Settings.Clusters.Vms.VmSelectionSpec.VmSelectionType*.  This property was added in __vSphere API 9.1.0.0__. | 
**ExtraConfigValue** | **string** | Unique VM extra configuration property value. The recommended usage is with an UUID.    See *Esx.Settings.Clusters.Vms.VmSelectionSpec.VmSelectionType.VM_EXTRA_CONFIG*.  This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of selection_type is *Esx.Settings.Clusters.Vms.VmSelectionSpec.VmSelectionType.VM_EXTRA_CONFIG*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

