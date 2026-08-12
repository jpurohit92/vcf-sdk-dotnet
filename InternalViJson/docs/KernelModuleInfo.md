# Vcenter.ViJson.OpenApi.Model.KernelModuleInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Module ID.  | 
**Name** | **string** | Module name.  | 
**VarVersion** | **string** | Version string.  | 
**Filename** | **string** | Module filename, without the path.  | 
**OptionString** | **string** | Option string configured to be passed to the kernel module when loaded.  Note that this is not necessarily the option string currently in use by the kernel module.  | 
**Loaded** | **bool** | Is the module loaded?  | 
**Enabled** | **bool** | Is the module enabled?  | 
**UseCount** | **int** | Number of references to this module.  | 
**ReadOnlySection** | [**KernelModuleSectionInfo**](KernelModuleSectionInfo.md) | Read-only section information.  | 
**WritableSection** | [**KernelModuleSectionInfo**](KernelModuleSectionInfo.md) | Writable section information.  | 
**TextSection** | [**KernelModuleSectionInfo**](KernelModuleSectionInfo.md) | Text section information.  | 
**DataSection** | [**KernelModuleSectionInfo**](KernelModuleSectionInfo.md) | Data section information.  | 
**BssSection** | [**KernelModuleSectionInfo**](KernelModuleSectionInfo.md) | BSS section information.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

