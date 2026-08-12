# Vcenter.ViJson.OpenApi.Model.VsanPerfsvcConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | vSAN performance service enablement state  | 
**Profile** | [**VirtualMachineProfileSpec**](VirtualMachineProfileSpec.md) | This field can be 3 formats: - VirtualMachineEmptyProfileSpec means to use the empty   vSAN policy.      This is not the default policy, but a policy   where all fields have default values. - VirtualMachineDefinedProfileSpec where profileId is set,   in which case this profileId will be looked up in SPBM for   the detailed policy information. - VirtualMachineDefinedProfileSpec where profileId is an   empty string and instead the profileData is set for extensionKey   &#39;com.vmware.vim.sps&#39;. In this case the objectData field can be   either the vSAN expression format, or a SPBM XML string.       If no profile is specified, SPBM will be consulted for the vSAN datastore&#39;s default profile. It is not required while disable vSAN performance service by setting field &#39;enabled&#39; to False.  | [optional] 
**DiagnosticMode** | **bool** | vSAN performance service diagnostic mode  | [optional] 
**VerboseMode** | **bool** | vSAN performance service verbose mode  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

