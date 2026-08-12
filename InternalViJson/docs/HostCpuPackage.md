# Vcenter.ViJson.OpenApi.Model.HostCpuPackage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **int** | Package index, starting from zero.  | 
**Vendor** | **string** | CPU vendor name, possible names currently are \&quot;Intel\&quot;, \&quot;AMD\&quot;, \&quot;arm\&quot;, \&quot;hygon\&quot;, or \&quot;unknown\&quot;.  | 
**Hz** | **long** | CPU speed in HZ.  | 
**BusHz** | **long** | Bus speed in HZ.  | 
**Description** | **string** | String summary description of CPU (for display purposes).  | 
**ThreadId** | **List&lt;int&gt;** | The logical CPU threads on this package.  | 
**CpuFeature** | [**List&lt;HostCpuIdInfo&gt;**](HostCpuIdInfo.md) | The CPU feature bit on this particular CPU.  This is independent of the product and licensing capabilities.  | [optional] 
**Family** | **int** | Family ID for the CPU  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 
**Model** | **int** | Model number of the CPU  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 
**Stepping** | **int** | Stepping ID of the CPU  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

