# Vcenter.ViJson.OpenApi.Model.HostHardwareSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vendor** | **string** | The hardware vendor identification.  | 
**Model** | **string** | The system model identification.  | 
**Family** | **string** | The system family identification.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**Uuid** | **string** | The hardware BIOS identification.  | 
**OtherIdentifyingInfo** | [**List&lt;HostSystemIdentificationInfo&gt;**](HostSystemIdentificationInfo.md) | Other identification information.  This information may be vendor specific.  | [optional] 
**MemorySize** | **long** | The physical memory size in bytes.  | 
**CpuModel** | **string** | The CPU model.  | 
**CpuMhz** | **int** | The speed of the CPU cores.  This is an average value if there are multiple speeds. The product of cpuMhz and numCpuCores is approximately equal to the sum of the MHz for all the individual cores on the host.  | 
**NumCpuPkgs** | **int** | Number of physical CPU packages on the host.  Physical CPU packages are chips that contain one or more processors. Processors contained by a package are also known as CPU cores. For example, one dual-core package is comprised of one chip that contains two CPU cores.  | 
**NumCpuCores** | **int** | Number of physical CPU cores on the host.  Physical CPU cores are the processors contained by a CPU package.  | 
**NumCpuThreads** | **int** | Number of physical CPU threads on the host.  | 
**NumNics** | **int** | The number of network adapters.  | 
**NumHBAs** | **int** | The number of host bus adapters (HBAs).  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

