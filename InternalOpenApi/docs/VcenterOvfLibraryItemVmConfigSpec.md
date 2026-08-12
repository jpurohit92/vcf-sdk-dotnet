# Vcenter.Automation.OpenApi.Model.VcenterOvfLibraryItemVmConfigSpec
The Vcenter.Ovf.LibraryItem.VmConfigSpec defines the optional virtual machine configuration settings used when deploying an OVF template. When used, the OVF descriptor acts as a disk descriptor.  This schema was added in __vSphere API 8.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | The *Vcenter.Ovf.LibraryItem.VmConfigSpec.provider* selects a provider from the list of available providers.  Possible values:   - &#x60;XML&#x60;: A vim.vm.ConfigSpec that has been serialized to XML and base64 encoded.   For more information see: *Vcenter.Ovf.LibraryItem.VmConfigSpecProvider*.  This property was added in __vSphere API 8.0.2.0__. | 
**Xml** | **string** | The *Vcenter.Ovf.LibraryItem.VmConfigSpec.xml* is a conditional configuration made available upon selecting the *Vcenter.Ovf.LibraryItem.VmConfigSpecProvider.XML*. It is used to pass in a vim.vm.ConfigSpec for a virtual machine that has been serialized to XML and base64 encoded.  This property was added in __vSphere API 8.0.2.0__.  This property is optional and it is only relevant when the value of provider is *Vcenter.Ovf.LibraryItem.VmConfigSpecProvider.XML*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

