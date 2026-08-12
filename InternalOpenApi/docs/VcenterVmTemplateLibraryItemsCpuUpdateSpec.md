# Vcenter.Automation.OpenApi.Model.VcenterVmTemplateLibraryItemsCpuUpdateSpec
The Vcenter.VmTemplate.LibraryItems.CpuUpdateSpec schema describes updates to the CPU configuration of the deployed virtual machine.  This schema was added in __vSphere API 6.8__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumCpus** | **long** | Number of virtual processors in the deployed virtual machine.  This property was added in __vSphere API 6.8__.  If missing or &#x60;null&#x60;, the deployed virtual machine has the same CPU count as the source virtual machine template contained in the library item. | [optional] 
**NumCoresPerSocket** | **long** | Number of cores among which to distribute CPUs in the deployed virtual machine.  This property was added in __vSphere API 6.8__.  If missing or &#x60;null&#x60;, the deployed virtual machine has the same number of cores per socket as the source virtual machine template contained in the library item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

