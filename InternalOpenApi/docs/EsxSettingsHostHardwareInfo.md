# Vcenter.Automation.OpenApi.Model.EsxSettingsHostHardwareInfo
The Esx.Settings.HostHardwareInfo schema contains properties to describe the host's hardware specifications like vendor, model, family and oem string.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vendor** | **string** | Host&#39;s vendor name. Maps to \&quot;Manufacturer\&quot; in SMBIOS: System Information (Type 1) and offset 04h  This property was added in __vSphere API 9.0.0.0__. | 
**Models** | **List&lt;string&gt;** | Host&#39;s model name.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, model name will not be used for image selection Maps to \&quot;Product Name\&quot; in SMBIOS: System Information (Type 1) and offset 05h | [optional] 
**Families** | **List&lt;string&gt;** | Host&#39;s family name.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, family name will not be used for image selection Maps to \&quot;Family\&quot; in SMBIOS: System Information (Type 1) and offset 1Ah | [optional] 
**OemStrings** | **List&lt;string&gt;** | Host&#39;s OEM string.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, oem string will not be used for image selection Maps to SMBIOS: OEM Strings (Type 11) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

