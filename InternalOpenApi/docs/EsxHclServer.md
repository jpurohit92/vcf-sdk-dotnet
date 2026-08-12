# Vcenter.Automation.OpenApi.Model.EsxHclServer
The Esx.Hcl.Server schema contains properties describing information about a server.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelName** | **string** | The name of the server model (for example, \&quot;PowerEdge R740xd\&quot;). | 
**Vendor** | **string** | The name of the vendor (for example, \&quot;Dell\&quot;). | 
**CpuSeries** | **string** | The CPU series name (for example, \&quot;Intel Xeon Gold 6100/5100, Silver 4100, Bronze 3100 (Skylake-SP) Series\&quot;).    __Note__: This property is initialized with the CPU *model* name; it&#39;s updated to the actual CPU series later, based on recognizing one of the CPU series the server hardware is certified with in the VCG.s | 
**CpuFeatures** | **string** | The current CPU features. | 
**Bios** | [**EsxHclFirmware**](EsxHclFirmware.md) | Currently installed BIOS of the server. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

