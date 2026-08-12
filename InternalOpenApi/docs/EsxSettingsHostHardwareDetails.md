# Vcenter.Automation.OpenApi.Model.EsxSettingsHostHardwareDetails
The Esx.Settings.HostHardwareDetails schema contains properties to describe host's hardware details.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostUuid** | **string** | Host&#39;s uuid. Maps to \&quot;UUID\&quot; in SMBIOS: System Information (Type 1) and offset 08h  This property was added in __vSphere API 9.0.0.0__. | 
**Vendor** | **string** | Host&#39;s vendor name. Maps to \&quot;Manufacturer\&quot; in SMBIOS: System Information (Type 1) and offset 04h  This property was added in __vSphere API 9.0.0.0__. | 
**Model** | **string** | Host&#39;s model name. Maps to \&quot;Product Name\&quot; in SMBIOS: System Information (Type 1) and offset 05h  This property was added in __vSphere API 9.0.0.0__. | 
**Family** | **string** | Host&#39;s family name. Maps to \&quot;Family\&quot; in SMBIOS: System Information (Type 1) and offset 1Ah  This property was added in __vSphere API 9.0.0.0__. | 
**OemStrings** | **List&lt;string&gt;** | Host&#39;s OEM string. Maps to SMBIOS: OEM Strings (Type 11)  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

