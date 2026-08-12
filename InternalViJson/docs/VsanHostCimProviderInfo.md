# Vcenter.ViJson.OpenApi.Model.VsanHostCimProviderInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CimProviderSupported** | **bool** | True If the installed CIM provider has the correct version with the one recommended in the HCL DB or no supported CIM provider in the HCL DB  | [optional] 
**InstalledCIMProvider** | **string** | The host installed CIM provider version  | [optional] 
**CimProviderOnHcl** | **List&lt;string&gt;** | The recommended CIM provider version on HCL.  This field will be unset if there is no supported CIM provider for the controller  | [optional] 
**CimProviderLinksOnHcl** | [**List&lt;VsanDownloadItem&gt;**](VsanDownloadItem.md) | If the CIM provider shows up on the HCL, this field will list locations from which one can get the CIM provider installing package.  There is a one-to-one correspondence between this field and cimProviderOnHcl.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

